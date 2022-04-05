using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BioRails.Core.Model;
using BR.Inv.Model;
using BR.Inv.Api;
using BR.Ord.Model;
using BR.Ord.Api;

namespace BR6WSInteractive
{
    public partial class frmOrdUpdate : Form
    {
        //encapsulated variables
        Session _session;
        string _url;
        BRInvWrapper _invOps;
        BROrderWrapper _ordOps;
        BRCatalogWrapper _catOps;
        Font _bigFont;
        Font _normFont;

        public frmOrdUpdate(Session wsSession, string url)
        {
            //set private variables
            _session = wsSession;
            _url = url;
            _bigFont = new Font("Times New Roman", 12.0f);
            _normFont = new Font("Times New Roman", 10.0f);
            _invOps = new BRInvWrapper(_session, _url);
            _ordOps = new BROrderWrapper(_session, _url);
            _catOps = new BRCatalogWrapper(_session, _url);
            InitializeComponent();
        }

        private void BtnGetOrder_Click(object sender, EventArgs e)
        {
            try
            {
                //instantiate order object and populate with existing order using order_get
                Order ord = _ordOps.GetOrder(txtOrderName.Text);
                dgvOrder.Columns.Clear();
                dgvOrder.AllowUserToAddRows = true;
                //_coreWS.WSClient.
                //get protection type names and populate combo
                BioRails.Core.Model.NamedArray states = _catOps.GetDictVals("/Root/Catalogue/State/State", "", 100, 0);
                CoreWSCombos.PopulateCombo(cmbState, states);
                //state not exposed on order so if you want to get it then you would need some SQL here
                //populate the data grid with the order details
                OrderDataGridConverter.ConvertOrderToDataGrid(ord, dgvOrder);
                //prevent user adding rows which would confuse the update
                dgvOrder.AllowUserToAddRows = false;
            }
            catch (BR.Ord.Client.ApiException apiEx)
            {
                string msg = BRExceptionCleaner.GetErrorMessageFromBioRailsError(apiEx.Message);
                RichTextBoxExtensions.AppendText(rtbWSOutput, "Updating Order Items Failed - " + msg, Color.Red, _normFont);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //create order item collection and populate based on contents of data grid which may have been edited by end user
                OrderItemArray oitems = OrderDataGridConverter.ConvertDataGridToUpdateOrderItems(dgvOrder);
                //attempt to update order items
                OrderItemArray updatedItems = _ordOps.UpdateOrderItems(oitems);
                RichTextBoxExtensions.AppendText(rtbWSOutput, "Updating Order Items Successful", Color.Green, _normFont);
            }
            catch (BR.Ord.Client.ApiException apiEx)
            {
                string msg = BRExceptionCleaner.GetErrorMessageFromBioRailsError(apiEx.Message);
                RichTextBoxExtensions.AppendText(rtbWSOutput, "Updating Order Items Failed - " + msg, Color.Red, _normFont);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred. " + ex.Message, "Error");
            }
        }

        private void btnOrdState_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (txtOrderName.Text != "" & cmbState.Text != "")
            //    {
            //        //attempt to update order items
            //        BROrderReference.Status os = _ordWS.WSClient.order_update_state(_session.session_id, txtOrderName.Text, cmbState.Text);
            //        //MessageBox("This method does not exist in 6.0. So commented out");
            //        //display update outcome on form
            //        OrdWSOutcome.ProcessUpdateStatus(os, rtbWSOutput);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Please enter an order and a state", "Guidance");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error");
            //}
        }
    }
}
