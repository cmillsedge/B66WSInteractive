using System;
using System.Windows.Forms;
using System.Drawing;
using BioRails.Core.Model;

namespace BR6WSInteractive
{

    public static class CoreWSCombos
    {
     
        public static void PopulateCombo(ComboBox cmb,NamedArray namevalues)
        {
            //take an array of names and populate a combo
            cmb.Items.Clear();
            if (namevalues != null)
            {
                foreach (Named cl in namevalues)
                {
                    cmb.Items.Add(cl.Name);
                }
            }
        }
    }
}
