using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BR.Ord.Model;
using BR.Ord.Api;

namespace BR6WSInteractive
{
    class OrderListBoxConverter
    {
        public static ShipmentItemArray ConvertListBoxToNamed(ListBox lsb, string location)
        {
            ShipmentItemArray nmv = new ShipmentItemArray();
            try
            {
                //loop through the listbox
                for (int i = 0; i < lsb.Items.Count; i++)
                {
                    if (lsb.Items[i].ToString() != String.Empty)
                    {
                        ShipmentItem nm = new ShipmentItem();
                        nm.ContainerName  = lsb.Items[i].ToString();
                        nm.DeliveryLocationPath = location;
                        nmv.Add(nm);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            return nmv;
        }

        public static String ConvertListBoxToString(ListBox lsb)
        {
            string returnString = String.Empty;
            try
            {
                
                //loop through the listbox
                for (int i = 0; i < lsb.Items.Count; i++)
                {
                    if (lsb.Items[i].ToString() != String.Empty)
                    {
                        returnString += lsb.Items[i].ToString() + Environment.NewLine;
                    }
                }
                returnString = returnString.TrimEnd('\r', '\n');
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            return returnString;
        }
    }
}

