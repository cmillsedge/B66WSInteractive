using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BioRails.Core.Api;
using BioRails.Core.Model;
using BR.Inv.Model;
using BR.Inv.Api;
using BR.Ord.Model;
using BR.Ord.Api;


namespace BR6WSInteractive
{
    public partial class frmOrdCreate : Form
    {
        //private member variables
        Session _session;
        string _url;
        BRInvWrapper _invOps;
        BROrderWrapper _ordOps;
        BRCatalogWrapper _catOps;
        Font _bigFont;
        Font _normFont;

        public frmOrdCreate(Session wsSession, string url)
        {
            //set member vals
            _session = wsSession;
            _url = url;
            _bigFont = new Font("Times New Roman", 12.0f);
            _normFont = new Font("Times New Roman", 10.0f);
            _invOps = new BRInvWrapper(_session, _url);
            _ordOps = new BROrderWrapper(_session, _url);
            _catOps = new BRCatalogWrapper(_session, _url);
            InitializeComponent();
            ConfigureForm();
        }


        private void ConfigureForm()
        {
            try
            {
                //Instantiate ordering name array and get order types then populate combo
                OrderTypeArray nmdord = _ordOps.GetAllOrderTypes();
                OrdWSCombos.PopulateCombo(cmbOType, nmdord);
                //Instantiate inventory name array and get sample types then populate combo
                SampleTypeArray nmd = _invOps.GetAllSampleTypes();
                InvWSCombos.PopulateCombo(cmbSType, nmd);
                //Get container layouts and populate combo
                ContainerLayoutArray nmdLay = _invOps.GetAllContainerLayouts();
                InvWSCombos.PopulateCombo(cmbLayout, nmdLay);
                //Get container types and populate combo
                ContainerTypeArray nmdType = _invOps.GetAllContainerTypes();
                InvWSCombos.PopulateCombo(cmbLayout, nmdLay);
                //get otype
                cmbOType.SelectedIndex = 0;
                OrderType otOld = cmbOType.SelectedItem as OrderType;
                OrderType ot = _ordOps.GetOrderType(otOld.Id);
                //populate the data grid with the order type columns
                OrderDataGridConverter.ConvertOTypeToDataGrid(ot, dgvOrder, cmbSType.Text, cmbTypes.Text, cmbLayout.Text);
                dgvOrder.AllowUserToAddRows = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred. " + ex.Message, "Error");
            }
        }

        private void cmbSamples_TextChanged(object sender, EventArgs e)
        {
            //this method will get a list of valid sample names based on the sample type and a letter typed into the samples combo
            string s = cmbSamples.Text;
            bool inlist = false;
            try
            {
                foreach (string si in cmbSamples.Items)
                {
                    if (si == s) { inlist = true; }
                }
                if (!inlist)
                {
                    SampleType stype = _invOps.GetSampleType(cmbSType.Text);
                    BioRails.Core.Model.NamedArray nmdcore = _catOps.GetDictVals(stype.DataElementPath, "", 100, 0);
                    CoreWSCombos.PopulateCombo(cmbSamples, nmdcore);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }


        }

        private void BtnAddSample_Click(object sender, EventArgs e)
        {
            ////add samples to list box
            if (dgvOrder.CurrentCell == null)
            { dgvOrder[1, 0].Value = cmbSamples.Text; }
            else
            { dgvOrder[1, dgvOrder.CurrentCell.RowIndex].Value = cmbSamples.Text; }

        }

        private Order BuildOrder()
        {
            //create an order object
            Order ord = new Order();
            try
            {
                //set order properties based on form controls 
                dgvOrder.AllowUserToAddRows = false;
                ord.Name = dgvOrder[0, 0].Value.ToString();
                ord.OrderTypeName = cmbOType.Text;
                ord.Description = cmbOType.Text;
                //pass the order into a static method to set all the order item properties and return a completed order object
                ord = OrderDataGridConverter.ConvertDataGridToCreateOrderItems(ord, dgvOrder, cmbSType.Text, cmbTypes.Text, cmbLayout.Text);
                dgvOrder.AllowUserToAddRows = true;
                return ord;

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred. " + ex.Message, "Error");
                return ord;
            }
        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            try
            {
                //build the order based on the form contents
                Order ord = BuildOrder();
                //place the order 
                Order myOrd = MakeOrder(ord);
                //update the form with the order create outcome
                RichTextBoxExtensions.AppendText(rtbWSOutput, "Create Order Successful", Color.Red, _normFont);
            }
            catch (BR.Ord.Client.ApiException apiEx)
            {
                string msg = BRExceptionCleaner.GetErrorMessageFromBioRailsError(apiEx.Message);
                RichTextBoxExtensions.AppendText(rtbWSOutput, "Create Order Failed - " + msg, Color.Red, _normFont);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                //build the order based on the form contents
                Order ord = BuildOrder();
                //check the order without placing it e.g. is it a valid order
                Order myOrder = CheckOrder(ord);
                //if the order is valid then enable the order create button
                btnOrder.Enabled = true;
                RichTextBoxExtensions.AppendText(rtbWSOutput, "Check Order Succesful ", Color.Red, _normFont);

            }
            catch (BR.Ord.Client.ApiException apiEx)
            {
                string msg = BRExceptionCleaner.GetErrorMessageFromBioRailsError(apiEx.Message);
                RichTextBoxExtensions.AppendText(rtbWSOutput, "Check Order Failed - " + msg, Color.Red, _normFont);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private Order CheckOrder(Order ord)
        {

            //simple call to order_check method passing order object
            //!needs changing to CHECK ORDER
            Order myOrder = _ordOps.CheckOrder(ord);
            return ord;
        }

        private Order MakeOrder(Order ord)
        {
            Order myOrd = new Order();
            try
            {
                //simple call to order_create method passing order object
                myOrd = _ordOps.CreateOrder(ord);
            }
            catch (BR.Ord.Client.ApiException apiEx)
            {
                string msg = BRExceptionCleaner.GetErrorMessageFromBioRailsError(apiEx.Message);
                RichTextBoxExtensions.AppendText(rtbWSOutput, "Updating Order Items Failed - " + msg, Color.Red, _normFont);
            }
            return ord;
        }

        private void CmbOType_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //instantiate order object and populate with existing order using order_get
                dgvOrder.Columns.Clear();
                dgvOrder.AllowUserToAddRows = true;
                OrderType otOld = cmbOType.SelectedItem as OrderType;
                OrderType ot = _ordOps.GetOrderType(otOld.Id);
                //populate the data grid with the order type columns
                OrderDataGridConverter.ConvertOTypeToDataGrid(ot, dgvOrder, cmbSType.Text, cmbTypes.Text, cmbLayout.Text);

            }
            catch (BR.Ord.Client.ApiException apiEx)
            {
                string msg = BRExceptionCleaner.GetErrorMessageFromBioRailsError(apiEx.Message);
                MessageBox.Show( msg, "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void DgvOrder_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                if (dgvOrder.Rows[0].Cells[0].Value != null)
                {
                    string sName = dgvOrder.Rows[0].Cells[0].Value.ToString();
                    foreach (DataGridViewRow dgvr in dgvOrder.Rows)
                    {
                        if (dgvOrder.Rows[dgvr.Index] != null)
                        {
                            dgvOrder[0, dgvr.Index].Value = sName;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred. " + ex.Message, "Error");
            }
        }

        private void cmbSType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this method will get a list of valid sample names based on the sample type and a letter typed into the samples combo
            string s = cmbSamples.Text;
            bool inlist = false;
            try
            {
                foreach (string si in cmbSamples.Items)
                {
                    if (si == s) { inlist = true; }
                }
                if (!inlist)
                {
                    SampleType stype = _invOps.GetSampleType(cmbSType.Text);
                    BioRails.Core.Model.NamedArray nmdcore = _catOps.GetDictVals(stype.DataElementPath, "", 100, 0);
                    CoreWSCombos.PopulateCombo(cmbSamples, nmdcore);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}



