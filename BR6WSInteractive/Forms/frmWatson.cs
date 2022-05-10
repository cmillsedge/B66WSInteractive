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

namespace BR6WSInteractive
{
    public partial class frmWatson : Form
    {
        //private variables
        Session _session;
        string _url;
        BRInvWrapper _invOps;
        BRCatalogWrapper _catOps;
        Font _bigFont;
        Font _normFont;
        public frmWatson(Session wsSession, string url)
        {
            //set private variables
            _session = wsSession;
            _url = url;
            _bigFont = new Font("Times New Roman", 12.0f);
            _normFont = new Font("Times New Roman", 10.0f);
            _invOps = new BRInvWrapper(_session, _url);
            _catOps = new BRCatalogWrapper(_session, _url);
            InitializeComponent();
        }

        private void BtnWatson1_Click(object sender, EventArgs e)
        {
            try
            {
                //Call external material import, passing name of view and material name. If material is in table all matching custom properties will be imported into BioRails
                _invOps.ImportExternalMaterial( "MOCK_EXTERNAL_MATERIALS", txtName.Text);
                RichTextBoxExtensions.AppendText(rtbWSOutput, "Material Import Success", Color.Red, _normFont);
            }
            catch (BR.Inv.Client.ApiException apiEx)
            {
                string msg = BRExceptionCleaner.GetErrorMessageFromBioRailsError(apiEx.Message);
                RichTextBoxExtensions.AppendText(rtbWSOutput, "Material Import Failed - " + msg, Color.Red, _normFont);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
}

        private void BtnPaste_Click(object sender, EventArgs e)
        {
            try
            {
                //paste material names into listbox
                string s = Clipboard.GetText();
                string[] lines = s.Split('\n');
                foreach (string In in lines)
                {
                    lstWatson.Items.Add(In.Trim());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void BtnWatsonMany_Click(object sender, EventArgs e)
        {
            try
            {
                int n = 0;
                BR.Inv.Model.StringArray names = new BR.Inv.Model.StringArray();
                //string[] names = new string[lstWatson.Items.Count];
                foreach (string s in lstWatson.Items)
                {
                    names.Add(s);
                    n += 1;
                }
                //instantiate a job id and set it equal to the job created when trying to create multiple materials with a list of names
                Material myMaterial = _invOps.ImportExternalMaterialJob( "MOCK_EXTERNAL_MATERIALS", "NAME", names);
                _invOps.ImportExternalMaterialJob("MOCK_EXTERNAL_MATERIALS", "NAME", names);
                //check the job outcome and update the form
                RichTextBoxExtensions.AppendText(rtbWSOutput, "Material Import Success", Color.Red, _normFont);
            }
            catch (BR.Inv.Client.ApiException apiEx)
            {
                string msg = BRExceptionCleaner.GetErrorMessageFromBioRailsError(apiEx.Message);
                RichTextBoxExtensions.AppendText(rtbWSOutput, "Material Import Failed - " + msg, Color.Red, _normFont);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
