using System;
using System.Windows.Forms;
using System.Drawing;
using BR.Inv.Model;


namespace BR6WSInteractive
{

    public static class InvWSCombos
    {
        //class to get list of values and populate combo
        public static void PopulateCombo(ComboBox cmb, SampleTypeArray namevalues)
        {
            //populate a combo based on an inventory named array
            cmb.Items.Clear();
            foreach (SampleType cl in namevalues)
            {
                cmb.Items.Add(cl.Name);
            }
        }

        public static void PopulateCombo(ComboBox cmb, ContainerTypeArray namevalues)
        {
            //populate a combo based on an inventory named array
            cmb.Items.Clear();
            foreach (ContainerType cl in namevalues)
            {
                cmb.Items.Add(cl.Name);
            }
        }

        public static void PopulateCombo(ComboBox cmb, ContainerLayoutArray namevalues)
        {
            //populate a combo based on an inventory named array
            cmb.Items.Clear();
            foreach (ContainerLayout cl in namevalues)
            {
                cmb.Items.Add(cl.Name);
            }
        }

        public static void PopulateCombo(ComboBox cmb, String[] namevalues)
        {
            //populate a combo based on an inventory named array
            cmb.Items.Clear();
            foreach (string s in namevalues)
            {
                cmb.Items.Add(s);
            }
            cmb.Text = cmb.Items[0].ToString();
        }
    }
}
