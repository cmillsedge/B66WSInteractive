using System;
using System.Windows.Forms;
using System.Drawing;
using BR.Ord.Model;


namespace BR6WSInteractive
{

    public static class OrdWSCombos
    {
        public static void PopulateCombo(ComboBox cmb, OrderTypeArray namevalues)
        {
            //populate a combo based on an inventory named array
            cmb.Items.Clear();
            foreach (OrderType cl in namevalues)
            {
                cmb.Items.Add(cl);
            }
            cmb.DisplayMember = "Name";
            cmb.ValueMember = "Id";

        }

    }
}
