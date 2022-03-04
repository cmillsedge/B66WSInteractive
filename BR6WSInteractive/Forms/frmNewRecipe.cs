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
    public partial class frmNewRecipe : Form
    {
        //private member variables for encapsulation
        Session _session;
        string _url;
        BRInvWrapper _invOps;
        BRCatalogWrapper _CatWS;
        Font _bigFont;
        Font _normFont;
        public frmNewRecipe(string materialType, Session session, string url)
        {
            //set member variable values
            _session = session;
            _url = url;
            _bigFont = new Font("Times New Roman", 12.0f);
            _normFont = new Font("Times New Roman", 10.0f);
            _invOps = new BRInvWrapper(_session, _url);
            _CatWS = new BRCatalogWrapper(_session, _url);
            InitializeComponent();
            LoadMaterialType(materialType);
            ConfigureForm();
        }

        private void ConfigureForm()
        {
            try
            {
                //Create inventory name array and populate with container types
                SampleTypeArray nmd = _invOps.GetAllSampleTypes();
                //populate container type combos
                InvWSCombos.PopulateCombo(cmbSType, nmd);
                cmbSType.Text = "batch";
                BioRails.Core.Model.NamedArray nmdcore = _CatWS.GetDictVals("/Root/Inventory/Material/Recipe/Component Roles/Component Roles", "", 100, 0);
                CoreWSCombos.PopulateCombo(cmbRole, nmdcore);
                dgvIngredients.AllowUserToAddRows = true;
                dgvMat.AllowUserToAddRows = true;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void LoadMaterialType(string materialType)
        {
            txtName.Text = "";
            txtDescrip.Text = "";
            txtMType.Text = materialType;
            SampleType st = _invOps.GetSampleType(materialType);
            //set recipe properties in grid
            MaterialDataGridConverter.ConvertSampleParamsToDataGrid(st.Parameters, dgvMat);

        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                dgvMat.AllowUserToAddRows = false;
                dgvIngredients.AllowUserToAddRows = false;

                MaterialRecipe mat = new MaterialRecipe();
                mat.Name = txtName.Text;
                mat.MaterialTypeName = txtMType.Text;
                //commented out due to bug of missing property in object model
                //mat.recipe = txtRecipe.Text;
                mat.Description = txtDescrip.Text;
                //properties
                MaterialPropertyArray nvs = MaterialDataGridConverter.ConvertDataGridToProperties(dgvMat);
                mat.Properties = nvs;
                //components
                MaterialRecipeIngredientArray comps = MaterialDataGridConverter.ConvertDataGridToRecipeIngredients(dgvIngredients);
                mat.Ingredients = comps;
                MaterialRecipe rec = _invOps.RecipeCreate(mat);
                //Update form based on status
                dgvMat.AllowUserToAddRows = true;
                dgvIngredients.AllowUserToAddRows = true;
            }
            catch (BR.Inv.Client.ApiException apiEx)
            {
                if (apiEx.ErrorCode == 422)
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


        private void dgvIngredients_CurrentCellChanged(object sender, EventArgs e)
        {
            int nrow = dgvIngredients.CurrentRow.Index + 1;
            numRow.Value = nrow;
        }

        private void btnFetchRow_Click(object sender, EventArgs e)
        {
            try
            {
                decimal dindex = numRow.Value;
                int index = Int32.Parse(dindex.ToString());
                index -= 1;
                txtCommonName.Text = dgvIngredients[0, index].Value.ToString();
                cmbRole.Text = dgvIngredients[1, index].Value.ToString();
                txtPercentage.Text = dgvIngredients[3, index].Value.ToString();
                if (dgvIngredients[2, index].Value != null) { cmbSType.Text = dgvIngredients[2, index].Value.ToString(); } else { cmbSType.Text = ""; }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnUpdRow_Click(object sender, EventArgs e)
        {
            try
            {
                decimal dindex = numRow.Value;
                int index = Int32.Parse(dindex.ToString());
                index -= 1;
                dgvIngredients[0, index].Value = txtCommonName.Text;
                dgvIngredients[1, index].Value = cmbRole.Text;
                dgvIngredients[3, index].Value = txtPercentage.Text;
                dgvIngredients[2, index].Value = cmbSType.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

    }
}
