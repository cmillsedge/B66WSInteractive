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
    public partial class frmMatEdit : Form
    {
        //private member variables for encapsulation
        BRInvWrapper _InvWS;
        Session _session;
        string _url;
        Font _bigFont;
        Font _normFont;
        public frmMatEdit(Material mat, Session wsSession, string url)
        {
            //set member variable values
            _session = wsSession;
            _url = url;
            _InvWS = new BRInvWrapper(_session, _url);
            _bigFont = new Font("Times New Roman", 12.0f);
            _normFont = new Font("Times New Roman", 10.0f);
            InitializeComponent();
            LoadMaterial(mat);
        }

        private void LoadMaterial(Material mat)
        {
            //populate fields with material properties
            lblIdVal.Text = mat.Id;
            txtName.Text = mat.Name;
            txtDescrip.Text = mat.Description;
            txtSampleType.Text = mat.SampleTypeName;
            //populate custom properties datagrid
            MaterialDataGridConverter.ConvertMaterialPropsToDataGrid(_InvWS, mat.CustomProperties, mat.SampleTypeName, dgvMat);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                dgvMat.AllowUserToAddRows = false;
                //create empty objects for population
                MaterialComponentArray comps = new MaterialComponentArray();
                Material mat = new Material();
                //set scalar properties
                mat.Id = lblIdVal.Text;
                mat.Name = txtName.Text;
                mat.Description = txtDescrip.Text;
                mat.SampleTypeName = txtSampleType.Text;
                //set array properties
                Dictionary<string, BR.Inv.Model.StringArray> nvs = MaterialDataGridConverter.ConvertDataGridToProperties(dgvMat);
                mat.CustomProperties = nvs;
                mat.MaterialComponents = comps;
                Material matEdit = _InvWS.MaterialUpdate(mat);
                RichTextBoxExtensions.AppendText(rtbWSOutput, "Material Edit - Successful", Color.Green, _normFont);
                dgvMat.AllowUserToAddRows = true;
            }
            catch (BR.Inv.Client.ApiException apiEx)
            {
                if (apiEx.ErrorCode == 404)
                {
                    string msg = BRExceptionCleaner.GetErrorMessageFromBioRailsError(apiEx.Message);
                    RichTextBoxExtensions.AppendText(rtbWSOutput, "Material Edit Failed - " + msg, Color.Red, _normFont); 
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error");
            }

        }
    }
}
