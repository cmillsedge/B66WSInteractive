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
    public partial class frmFormFromRec : Form
    {
        //private member variables for encapsulation
        BRInvWrapper _InvWS;
        BRCatalogWrapper _CatWS;
        Session _session;
        string _url;
        Font _bigFont;
        Font _normFont;
        public frmFormFromRec(MaterialRecipe rec, Session wsSession, string url)
        {
            //set member variable values
            _session = wsSession;
            _url = url;
            _InvWS = new BRInvWrapper(_session, _url);
            _CatWS = new BRCatalogWrapper(_session, _url); 
            _bigFont = new Font("Times New Roman", 12.0f);
            _normFont = new Font("Times New Roman", 10.0f);
            InitializeComponent();
            LoadRecipe(rec);
            ConfigureForm();

        }

        private void LoadRecipe(MaterialRecipe rec)
        {
            //set form fields with recipe properties
            txtName.Text = rec.Name;
            txtDescrip.Text = rec.Description;
            txtMType.Text = rec.MaterialTypeName;
            txtRecipe.Text = rec.Name;
            //set recipe properties in grid
            MaterialDataGridConverter.ConvertMaterialPropsToDataGrid(_InvWS, rec.CustomProperties, rec.MaterialTypeName, dgvMat);
            MaterialDataGridConverter.ConvertRecipeIngredientsToDataGrid(rec.Ingredients, dgvIngredients);

        }

        private void ConfigureForm()
        {
            try
            {
                //Create inventory name array and populate with container types
                SampleTypeArray nmd = _InvWS.GetAllSampleTypes();
                //populate container type combos
                InvWSCombos.PopulateCombo(cmbSType, nmd);
                cmbSType.Text = "batch";
                BioRails.Core.Model.NamedArray nmdcore = _CatWS.GetDictVals("/Root/Inventory/Material/Recipe/Component Roles/Component Roles", "", 100,0);
                CoreWSCombos.PopulateCombo(cmbRole, nmdcore);
                dgvIngredients.AllowUserToAddRows = true;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string sQty = "";
                double dQty = 0;
                dgvMat.AllowUserToAddRows = false;
                dgvIngredients.AllowUserToAddRows = false;
                //instantiate material for formulation
                Material mat = new Material();
                //set scalar properties
                mat.Name = txtName.Text;
                mat.RecipeName = txtRecipe.Text;
                sQty = txtQuantity.Text;
                if (sQty != null && sQty != "")
                {
                    String[] strlist = sQty.Split(' ');
                    mat.QuantityUnit = strlist[1];
                    if (Double.TryParse(strlist[0], out dQty))
                    {
                        mat.QuantityValue = dQty;
                    }
                    else
                    {
                        mat.QuantityValue = 0;
                    }
                }
                mat.SampleTypeName = txtMType.Text;
                mat.Description= txtDescrip.Text;
                //properties
                Dictionary<string, BR.Inv.Model.StringArray> nvs = MaterialDataGridConverter.ConvertDataGridToProperties(dgvMat);
                mat.CustomProperties = nvs;
                //components
                MaterialComponentArray comps = MaterialDataGridConverter.ConvertDataGridToMaterialComponents(dgvIngredients);
                mat.MaterialComponents = comps;
                Material matnew = _InvWS.MaterialCreate( mat);

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


        private void cmbComponent_TextChanged(object sender, EventArgs e)
        {
            string s = cmbComponent.Text;
            bool inlist = false;
            try
            {
                //if the component is not in the drop down
                foreach (string si in cmbComponent.Items)
                {
                    if (si == s) { inlist = true; }
                }
                if (!inlist)
                { 
                    //repopulate combo
                    string filter = "%";
                    if (cmbComponent.Text != String.Empty)
                    { filter = cmbComponent.Text; }
                    SampleType stype = _InvWS.GetSampleType(cmbSType.Text);
                    BioRails.Core.Model.NamedArray nmdcore = _CatWS.GetDictVals(stype.DataElementPath, "", 100, 0);
                    CoreWSCombos.PopulateCombo(cmbComponent, nmdcore);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void dgvIngredients_CurrentCellChanged(object sender, EventArgs e)
        {
            //get current row and display in UI
            int nrow = dgvIngredients.CurrentRow.Index + 1;
            numRow.Value = nrow;       
        }

        private void btnFetchRow_Click(object sender, EventArgs e)
        {
            try
            { 
                //pull current row in the data grid down in to the controls below the grid
                decimal dindex = numRow.Value;
                int index = Int32.Parse(dindex.ToString());
                index -= 1;
                txtCommonName.Text = dgvIngredients[0, index].Value.ToString();
                cmbRole.Text = dgvIngredients[1, index].Value.ToString();
                txtPercentage.Text = dgvIngredients[3, index].Value.ToString();
                if (dgvIngredients[4, index].Value != null) { cmbComponent.Text = dgvIngredients[4, index].Value.ToString(); } else { cmbComponent.Text = ""; }
                if (dgvIngredients[2, index].Value != null) { cmbSType.Text = dgvIngredients[2, index].Value.ToString(); } else { cmbSType.Text = ""; }
                if (dgvIngredients[5, index].Value != null) { txtCompQty.Text = dgvIngredients[5, index].Value.ToString(); } else { txtCompQty.Text = ""; }
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
                //populate the current row in the data grid with the values from the controls below the grid.
                decimal dindex = numRow.Value;
                int index = Int32.Parse(dindex.ToString());
                index -= 1;
                dgvIngredients[0, index].Value = txtCommonName.Text;
                dgvIngredients[1, index].Value = cmbRole.Text;
                dgvIngredients[3, index].Value = txtPercentage.Text;
                dgvIngredients[4, index].Value = cmbComponent.Text;
                dgvIngredients[2, index].Value = cmbSType.Text;
                dgvIngredients[5, index].Value = txtCompQty.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
