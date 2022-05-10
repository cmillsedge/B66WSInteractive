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
    public partial class frmShipments : Form
    {
        //private member variables for encapsulation
        Session _session;
        string _url;
        BRInvWrapper _invOps;
        BROrderWrapper _ordOps;
        BRCatalogWrapper _catOps;
        Font _bigFont;
        Font _normFont;
        public frmShipments(Session wsSession, string url)
        {
            //set member variable values
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
            //try
            //{

            //    //Get combo values
            //    BRCoreReference.Named[] nmdlay = CoreWSCombos.GetDictVals(_session, _coreWS, "/Root/Inventory/ContainerLayout", "TransportLayouts", "%");
            //    CoreWSCombos.PopulateCombo(cmbLayout, nmdlay);
            //    BRCoreReference.Named[] nmdcore = CoreWSCombos.GetDictVals(_session, _coreWS, "/Root/Inventory/OrderSystem", "All", "%");
            //    CoreWSCombos.PopulateCombo(cmbOrderSystem, nmdcore);
            //    //disable controls until it is clear what user is doing
            //    txtName.Enabled = false;
            //    cmbLayout.Enabled = false;
            //    txtLocation.Enabled = false;
            //    cmbOrderSystem.Enabled = false;
            //    btnDispatch.Enabled = false;
            //    btnReceive.Enabled = false;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error");
            //}
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            txtName.Enabled = true;
            cmbLayout.Enabled = true;
            txtLocation.Enabled = true;
            cmbOrderSystem.Enabled = true;
            lstContainers.Enabled = true;
            btnDispatch.Enabled = true;
            btnReceive.Enabled = false;

        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            txtName.Enabled = false;
            cmbLayout.Enabled = false;
            txtLocation.Enabled = true;
            cmbOrderSystem.Enabled = false;
            txtLocation.Enabled = true;
            lstContainers.Enabled = true;
            btnDispatch.Enabled = false;
            btnReceive.Enabled = true;
        }

        private void btnDispatch_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (txtName.Text == String.Empty | txtLocation.Text == String.Empty | cmbOrderSystem.Text == String.Empty | lstContainers.Items.Count == 0)
            //    { MessageBox.Show("All fields except layout are mandatory"); }
            //    else
            //    {
            //        Shipment ship = new Shipment();
            //        ship.Address = txtLocation.Text;
            //        ship.OrderTypeName = cmbOrderSystem.Text;
            //        ship.Name = txtName.Text;
            //        ship.ContainerLayoutName = cmbLayout.Text;
            //        Named[] nmd = OrderListBoxConverter.ConvertListBoxToNamed(lstContainers);
            //        ship.Items = nmd;
            //        //Status st = _ordWS.WSClient.shipment_create(_session.session_id, ship);
            //        int jobid = _ordWS.WSClient.shipment_create_job(_session.session_id, ship);

            //        OrdWSOutcome.ShipmentOutCome(jobid.ToString(), "Shipment Create", rtbWSOutput, _session, _coreWS, _ordWS);

            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error");
            //}
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            //try
            //{ 
            //    if (lstContainers.Items.Count == 0)
            //    { MessageBox.Show("Container list is mandatory"); }
            //    else
            //    {
            //        Receipt rec = new Receipt();
            //        Named[] nmd = OrderListBoxConverter.ConvertListBoxToNamed(lstContainers);
            //        rec.barcodes = nmd;
            //        //IF location is blank order items location should be used.
            //        if (txtLocation.Text != "")
            //        { rec.location_path = txtLocation.Text; }
            //        ListStatus ls = _ordWS.WSClient.shipment_receipt(_session.session_id, rec);
            //        OrdWSOutcome.ProcessReceiptOutcome(ls, "Container Receipt", rtbWSOutput, _session);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error");
            //}
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            try
            {
                lstContainers.Items.Clear();
                // Getting Text from Clip board
                string s = Clipboard.GetText();
                //Parsing criteria: New Line
                string[] lines = s.Split('\n');
                foreach (string ln in lines)
                {
                    if (ln != String.Empty)
                    {
                        lstContainers.Items.Add(ln.Trim());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
