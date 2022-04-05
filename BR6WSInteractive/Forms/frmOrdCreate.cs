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
                OrderType ot = _ordOps.GetOrderType(cmbOType.Text);
                //populate the data grid with the order type columns
                OrderDataGridConverter.ConvertOTypeToDataGrid(ot, dgvOrder, cmbSType.Text, cmbTypes.Text, cmbLayout.Text);
                dgvOrder.AllowUserToAddRows = true;
                ////Instantiate core name array and get users then populate combo
                //BRCoreReference.Named[] nmdcore = CoreWSCombos.GetDictVals(_session, _coreWS, "/Root/Catalogue/Users", "active", "s");
                //CoreWSCombos.PopulateCombo(cmbRecipient, nmdcore);
                ////Get solvents and populate combo
                //nmdcore = CoreWSCombos.GetDictVals(_session, _coreWS, "/Root/Inventory", "Solvents", "E");
                //CoreWSCombos.PopulateCombo(cmbSolvent, nmdcore);
                ////Get locations starting with B and populate combo - you may want to add or change the initial filter to work with your database
                //nmdcore = CoreWSCombos.GetDictVals(_session, _coreWS, "/Root/Inventory/Location", "Terminal", "B");
                //CoreWSCombos.PopulateCombo(cmbLocation , nmdcore);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred. " + ex.Message, "Error");
            }
        }

        private void cmbSamples_TextChanged(object sender, EventArgs e)
        {
            //this method will get a list of valid sample names based on the sample type and a letter typed into the samples combo
            //string s = cmbSamples.Text;
            //bool inlist = false;
            //try
            //{ 
            //    foreach (string si in cmbSamples.Items)
            //    {
            //        if(si == s) { inlist = true; }
            //    }
            //    if (!inlist)
            //    {
            //        BRInvReference.SampleType stype = InvWSCombos.GetSType(_session, _invWS, cmbSType.Text);
            //        BRCoreReference.Named[] nmdcore = CoreWSCombos.GetDictVals(_session, _coreWS, CoreWSCombos.GetPathWOutName(stype.data_element_path), CoreWSCombos.GetNameFromPath(stype.data_element_path), cmbSamples.Text);
            //        CoreWSCombos.PopulateCombo(cmbSamples, nmdcore);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error");
            //}


        }

        private void BtnAddSample_Click(object sender, EventArgs e)
        {
            ////add samples to list box
            //if (dgvOrder.CurrentCell == null)
            //{ dgvOrder[1, 0].Value = cmbSamples.Text; }
            //else
            //{ dgvOrder[1, dgvOrder.CurrentCell.RowIndex].Value = cmbSamples.Text; }

        }

        //private Order BuildOrder()
        //{
        //    //create an order object
        //    BROrderReference.Order ord = new BROrderReference.Order();
        //    try
        //    {
        //        //set order properties based on form controls 
        //        dgvOrder.AllowUserToAddRows = false;
        //        ord.name = dgvOrder[0, 0].Value.ToString();
        //        ord.order_type_name = cmbOType.Text;
        //        ord.description = cmbOType.Text;
        //        //pass the order into a static method to set all the order item properties and return a completed order object
        //        ord = OrderDataGridConverter.ConvertDataGridToCreateOrderItems(ord, dgvOrder, cmbSType.Text, cmbTypes.Text, cmbLayout.Text);
        //        dgvOrder.AllowUserToAddRows = true;
        //        return ord;

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("An error occurred. " + ex.Message, "Error");
        //        return ord;
        //    }
        //}

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    //build the order based on the form contents
            //    BROrderReference.Order ord = BuildOrder();
            //    //place the order 
            //    BROrderReference.OrderStatus os = MakeOrder(ord);
            //    //update the form with the order create outcome
            //    OrdWSOutcome.ProcessOrderStatus(os, rtbWSOutput, dgvOrder);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error");
            //}
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    //build the order based on the form contents
            //    BROrderReference.Order ord = BuildOrder();
            //     //check the order without placing it e.g. is it a valid order
            //    BROrderReference.OrderStatus os = CheckOrder(ord);
            //     //if the order is valid then enable the order create button
            //    if (os.ok == true) { btnOrder.Enabled = true; }
            //    //update form with order check outcome
            //    OrdWSOutcome.ProcessOrderStatus(os, rtbWSOutput, dgvOrder);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error");
            //}

        }

        //private Order CheckOrder(Order ord)
        //{

        //    //simple call to order_check method passing order object
        //    BROrderReference.OrderStatus os = _ordWS.WSClient.order_check(_session.session_id, ord);
        //    return os;
        //}

        //private Order MakeOrder(Order ord)
        //{
        //    //simple call to order_create method passing order object
        //    BROrderReference.OrderStatus os = _ordWS.WSClient.order_create(_session.session_id, ord);
        //    return os;
        //}

        private void CmbOType_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    //instantiate order object and populate with existing order using order_get
            //    dgvOrder.Columns.Clear();
            //    dgvOrder.AllowUserToAddRows = true;
            //    BROrderReference.OrderType ot = _ordWS.WSClient.order_type_get(_session.session_id, cmbOType.Text);
            //    //populate the data grid with the order type columns
            //    OrderDataGridConverter.ConvertOTypeToDataGrid(ot, dgvOrder, cmbSType.Text, cmbTypes.Text, cmbLayout.Text);

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error");
            //}
        }

        private void DgvOrder_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //try
            //{
            //    if (dgvOrder.Rows[0].Cells[0].Value != null)
            //    {
            //        string sName = dgvOrder.Rows[0].Cells[0].Value.ToString();
            //        foreach (DataGridViewRow dgvr in dgvOrder.Rows)
            //        {
            //            if (dgvOrder.Rows[dgvr.Index] != null)
            //            {
            //                dgvOrder[0, dgvr.Index].Value = sName;
            //            }
            //        }
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("An error occurred. " + ex.Message, "Error");
            //}
        }

        //private void cmbSType_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    //this method will get a list of valid sample names based on the sample type and a letter typed into the samples combo
        //    //string s = cmbSamples.Text;
        //    //bool inlist = false;
        //    //try
        //    //{
        //    //    foreach (string si in cmbSamples.Items)
        //    //    {
        //    //        if (si == s) { inlist = true; }
        //    //    }
        //    //    if (!inlist)
        //    //    {
        //    //        BRInvReference.SampleType stype = InvWSCombos.GetSType(_session, _invWS, cmbSType.Text);
        //    //        BRCoreReference.Named[] nmdcore = CoreWSCombos.GetDictVals(_session, _coreWS, CoreWSCombos.GetPathWOutName(stype.data_element_path), CoreWSCombos.GetNameFromPath(stype.data_element_path), "%");
        //    //        CoreWSCombos.PopulateCombo(cmbSamples, nmdcore);
        //    //    }
        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    MessageBox.Show(ex.Message, "Error");
        //    //}
        //}
    }
}



