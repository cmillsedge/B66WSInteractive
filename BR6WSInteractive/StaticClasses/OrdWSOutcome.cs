using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using BR.Ord.Model;
using BR.Ord.Api;

namespace BR6WSInteractive
{
    public static class OrdWSOutcome
    {
        //This class is designed to update form objects based on the outcome of calls to the ordering webservice
        const string unavailable = "Insufficient Stock";
        public static void ProcessOrderStatus(OrderCheck os, RichTextBox box, DataGridView dgv)
        {
            //method to deal with the outcome of a call to order_create method
            Font normFont = new Font("Times New Roman", 10.0f);
            try
            {
                //check the status if it is ok then let the user know all is well
                //now check the order items error array - note the order object is returned inside the order status object.
                if (os.Messages != null)
                {
                    foreach (String s in os.Messages)
                    {
                        if (s.Contains("Insufficient"))
                        {
                            OItemMessage oItemMessage = new OItemMessage(s);
                            UpdateGridAvailable(oItemMessage, dgv);
                        }
                    }
                }
                else
                {
                    //available 
                    //UpdateGridAvailable(oi.data_name, "Available", dgv);
                    Console.WriteLine("nothing");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private static void UpdateGridAvailable(OItemMessage oItemMessage, DataGridView dgv)
        { 
            try
            {
                int nlastcol = dgv.ColumnCount - 1;
                dgv[nlastcol, oItemMessage.Index].Value = oItemMessage.Available;
                dgv[nlastcol, oItemMessage.Index].Style.BackColor = oItemMessage.Colour;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }


       
    }
}

