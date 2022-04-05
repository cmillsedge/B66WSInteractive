using System;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Drawing;
using BR.Ord.Model;
using BR.Ord.Api;


namespace BR6WSInteractive
{
    public static class OrderDataGridConverter
    {
        //this class is designed to convert a datagrid into an array of order items or vice versa
        //this constant represents the conserved columns in the grid e.g. those not based on order type parameters
        private const int staticcols = 7;
        //simple method to clean out the datagrid of unused rows and prevent null errors
        private static void ClearUnusedRows(DataGridView dgv)
        {

            try
            {
                foreach (DataGridViewRow dgvr in dgv.Rows)
                {
                    if (dgvr.Cells[1].Value == null )
                    { dgv.Rows.RemoveAt(dgvr.Index); }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred. " + ex.Message, "Error");
            }
        }

        //public static Order ConvertDataGridToCreateOrderItems(Order ord, DataGridView dgvOrder, string sType, string cType, string cLayout)
        //{
        //    //this method is for use when CREATING an order and therefore no order_item ids will be set
        //    try
        //    {
        //        //clean out unused rows on the grid
        //        ClearUnusedRows(dgvOrder);
        //        int numParams = dgvOrder.ColumnCount - 5;
        //        int numCols = 4;
        //        //Create an array of order items equal in length to the rows in the datagrid
        //        OrderItemArray oitems = new OrderItemArray();
        //        //loop through the data grid
        //        for (int i = 0; i < dgvOrder.Rows.Count; i++)
        //        {
        //            OrderItem item = new OrderItem();
        //            //create a name value array for the order item properties e.g. order type parameters
        //            BROrderReference.NameValue[] nmv = new BROrderReference.NameValue[numParams];
        //            for (int n = 0; n < nmv.Length; n++) { nmv[n] = new BROrderReference.NameValue(); }
        //            //create the order items and name values for use later

        //            //set the order item properties positionally based on columns in datagrid
        //            //this is probably not optimal use of datagrid but it was a rough and ready way to exemplify
        //            //setting order item properties
        //            BROrderReference.OrderItem oitem = new BROrderReference.OrderItem();
        //            oitem.data_name = dgvOrder[1, i].Value.ToString();
        //            oitem.container_layout_name = cLayout;
        //            oitem.container_type_name = cType;
        //            if (dgvOrder[3, i].Value != null)
        //            { oitem.comments = dgvOrder[3, i].Value.ToString(); }
        //            oitem.reserved_container_name = dgvOrder[2, i].Value.ToString();
        //            for (int p = 0; p < numParams; p++)
        //            {
        //                nmv[p].name = dgvOrder.Columns[p + numCols].Name;
        //                nmv[p].value = dgvOrder[p + numCols, i].Value.ToString();
        //            }
        //            oitem.properties = nmv;
        //            oitems[i] = oitem;

        //        }
        //        ord.order_items = oitems;
        //        //return the order items
        //        return ord;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("An error occurred. " + ex.Message, "Error");
        //        return ord;
        //    }

        //}

        public static void ConvertOTypeToDataGrid(OrderType oType, DataGridView dgvOrder, string sampleType, string containerType, string containerLayout)
        {
            //this method is designed to populate a datagrid based on the properties of an existing BioRails order type
            //try
            //{
            //    int nloop = 0;
            //    //add the conserved columns e.g. properties all orders and order items have
            //    dgvOrder.Columns.Add("orderName", "Order Name");
            //    dgvOrder.Columns.Add("orderItemName", "Item Name");
            //    dgvOrder.Columns.Add("orderItemSContainer", "Source Container");
            //    dgvOrder.Columns.Add("orderItemComment", "Comment");
            //    dgvOrder[0, nloop].Value = "Order-" + System.DateTime.Now.ToLongDateString() + System.DateTime.Now.ToLongTimeString();
            //    dgvOrder[1, nloop].Value = oType.Name;

            //    //for each parameters in the order type set datagrid cols
            //    foreach (BROrderReference.OrderParameter op in oType.parameters)
            //    {
            //        //conserved properties in all orders and order items
            //        dgvOrder.Columns.Add(op.name, op.name);
            //    }
            //    dgvOrder.Columns.Add("orderItemAvailable", "Availability");
            //    //stop independent column sorting breaking the order details
            //    foreach (DataGridViewColumn column in dgvOrder.Columns)
            //    {

            //        column.SortMode = DataGridViewColumnSortMode.NotSortable;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("An error occurred. " + ex.Message, "Error");
            //}
        }

        public static void ConvertOrderToDataGrid(Order ord, DataGridView dgvOrder)
        {
            //this method is designed to populate a datagrid based on the properties of an existing BioRails order
            //try
            //{
            //    int nloop = 0;
            //    //add the conserved columns e.g. properties all orders and order items have
            //    dgvOrder.Columns.Add("orderName", "Order Name");
            //    dgvOrder.Columns.Add("orderType", "Order Type");
            //    dgvOrder.Columns.Add("orderItemId", "Item Id");
            //    dgvOrder.Columns.Add("orderItemName", "Item Name");
            //    dgvOrder.Columns.Add("orderItemStatus", "Status");
            //    dgvOrder.Columns.Add("orderItemDContainer", "Delivered Container");
            //    dgvOrder.Columns.Add("orderItemComment", "ExtComment");
            //    dgvOrder.Rows.Add(ord.order_items.Length);
            //    //highlight updateable fields
            //    dgvOrder.Columns["orderItemStatus"].DefaultCellStyle.BackColor = Color.PowderBlue;
            //    dgvOrder.Columns["orderItemDContainer"].DefaultCellStyle.BackColor = Color.PowderBlue;
            //    dgvOrder.Columns["orderItemComment"].DefaultCellStyle.BackColor = Color.PowderBlue;
            //    //for each item in the order set datagrid values
            //    foreach (OrderItem oi in ord.OrderItems)
            //    {
            //        //conserved properties in all orders and order items
            //        dgvOrder[0, nloop].Value = ord.name;
            //        dgvOrder[1, nloop].Value = ord.order_type_name;
            //        dgvOrder[2, nloop].Value = oi.id;
            //        dgvOrder[3, nloop].Value = oi.data_name;
            //        dgvOrder[4, nloop].Value = oi.state_name;
            //        dgvOrder[5, nloop].Value = oi.delivered_container_name;
            //        dgvOrder[6, nloop].Value = oi.external_comments;
            //        int col = staticcols;
            //        //order_item properties - this will be based on order type parameters
            //        foreach (BROrderReference.NameValue nv in oi.properties)
            //        {
            //            //first loop add columns for all the order item properties
            //            if (nloop == 0)
            //            {dgvOrder.Columns.Add(nv.name, nv.name);}
            //            dgvOrder[col, nloop].Value = nv.value;
            //            col += 1;
            //        }
            //        nloop += 1;
            //    }
            //    foreach (DataGridViewColumn column in dgvOrder.Columns)
            //    {

            //        column.SortMode = DataGridViewColumnSortMode.NotSortable;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("An error occurred. " + ex.Message, "Error");
            //}
        }

        public static OrderItemArray ConvertDataGridToUpdateOrderItems(DataGridView dgvOrder)
        {
            //This method converts a datagrid into an array of order items and is designed for use with order_UPDATE hence ids are set
            //instantiate collection of order items sized based on datagrid
            OrderItemArray oitems = new OrderItemArray();
            try
            {
                //loop through the rows in the data grid
                for (int i = 0; i < dgvOrder.Rows.Count; i++)
                {
                    //do the columns which never change and are part of order items array
                    //set the item:id, name and state_name based on contents of data grid which user may have edited
                    OrderItem oitem = new OrderItem();
                    oitem.Id = dgvOrder[2, i].Value.ToString();
                    oitem.DataName = dgvOrder[3, i].Value.ToString();
                    oitem.StateName = dgvOrder[4, i].Value.ToString();
                    //ensure nullable columns are not null before trying to set values or we get an error
                    if (dgvOrder[5, i].Value != null) { oitem.DeliveredContainerName = dgvOrder[5, i].Value.ToString(); }
                    if (dgvOrder[6, i].Value != null) { oitem.ExternalComments = dgvOrder[6, i].Value.ToString(); }
                    Dictionary<string, StringArray> cpArray = new Dictionary<string, StringArray>();
                    //loop through non-conserved columns and populate name values which will be set as order_item.properties
                    for (int n = staticcols; n < dgvOrder.Columns.Count; n++)
                    {
                        string name;
                        string value;
                        StringArray vallist = new StringArray();
                        name = dgvOrder.Columns[n].Name;
                        if (dgvOrder[n, i].Value != null) 
                        { 
                            value = dgvOrder[n, i].Value.ToString();
                            vallist.Add(value);
                        }
                        
                        cpArray.Add(name, vallist);

                    }
                    oitem.CustomProperties = cpArray;
                    oitems.Add(oitem);
                }
                return oitems;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred. " + ex.Message, "Error");
                return oitems;
            }
        }

    }
}
