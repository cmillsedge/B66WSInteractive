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
    public partial class frmMaterialsMain : Form
    {
        Session _session;
        string _url;
        BRInvWrapper _invOps;
        Font _bigFont;
        Font _normFont;
        public frmMaterialsMain(Session wsSession, string url)
        {
            InitializeComponent();
            try
            {
                _session = wsSession;
                _url = url;
                _bigFont = new Font("Times New Roman", 12.0f);
                _normFont = new Font("Times New Roman", 10.0f);
                _invOps = new BRInvWrapper(_session, _url); 
                LoadSampleTypes();
                LoadContainerTypes();
                LoadContainerLayouts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error encountered");
            } 
        }

        public void LoadSampleTypes()
        {
            try
            {
                SampleTypeArray myTypes = _invOps.GetAllSampleTypes();
                foreach (SampleType type in myTypes)
                {
                    cmbMTypes.Items.Add(type.Name);
                    cmbSampTypes.Items.Add(type.Name);
                    cmbRecMType.Items.Add(type.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error encountered");
            }
        }

        public void LoadContainerTypes()
        {
            try
            {
                ContainerTypeArray myTypes = _invOps.GetAllContainerTypes();
                foreach (ContainerType type in myTypes)
                {
                    cmbTypeLoad.Items.Add(type.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error encountered");
            }
        }

        public void LoadContainerLayouts()
        {
            try
            {
                ContainerLayoutArray myTypes = _invOps.GetAllContainerLayouts();
                foreach (ContainerLayout type in myTypes)
                {
                    cmbLayoutLoad.Items.Add(type.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error encountered");
            }
        }

        private void btnMatClone_Click(object sender, EventArgs e)
        {
            if(txtMatDest.Text != "")
                {
                RichTextBoxExtensions.AppendText(rtbWSOutput, "Clone Material", Color.Black, _bigFont);
                //Create a material object based on an existing material e.g. blood sample 001
                Material myMaterial = _invOps.GetMaterial(txtMatSource.Text);
                myMaterial.Name = txtMatDest.Text;
                //set material id to null to make sure this is seen as a create
                myMaterial.Id = null;
                MaterialArray materials = new MaterialArray { myMaterial };
                MaterialBulk bulkMaterials = new MaterialBulk() { Materials = materials };
                BR.Inv.Model.JobReport jb = _invOps.MaterialUploadJob( bulkMaterials);
                //Try and create the new material - should be identical except for name
                //Update form based on status
                InvWSOutcome.PostWSJobOutCome(jb.Id, "Clone Material", rtbWSOutput, _session, _url);
                dgvMat.AllowUserToAddRows = true;
            }
                else
            {
                MessageBox.Show("You must provide a name", "Error");
            }
        }

        private void btnMatEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Material myMaterial = _invOps.GetMaterial(txtMatSource.Text);
                using (frmMatEdit frmMEdit = new frmMatEdit(myMaterial, _session, _url))
                {
                    frmMEdit.Location = this.Location;
                    this.Hide();
                    frmMEdit.ShowDialog();

                }
                //frmSel closed re-display logon
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbMTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbRecipes.Items.Clear();
            cmbRecipes.Text = "";
            //find recipes
            MaterialRecipeArray recs = _invOps.MaterialRecipeList(cmbMTypes.Text);
            if (recs != null)
            {
                //populate combo
                foreach (MaterialRecipe rec in recs) { cmbRecipes.Items.Add(rec.Name); }
                txtRecipe.Text = cmbRecipes.Text;
            }
        }

        private void cmbRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRecipe.Text = cmbRecipes.Text;
        }

        private void btnFormulationCreate_Click(object sender, EventArgs e)
        {
            try
            {
                MaterialRecipe rec = _invOps.GetRecipe(txtRecipe.Text);
                using (frmFormFromRec frmFromRec = new frmFormFromRec(rec, _session, _url))
                {
                    frmFromRec.Location = this.Location;
                    this.Hide();
                    frmFromRec.ShowDialog();

                }
                //frmSel closed re-display logon
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRecipeCreate_Click(object sender, EventArgs e)
        {
            try
            {
                //launch form for testing creating recipes
                using (frmNewRecipe frmRecipe = new frmNewRecipe(cmbRecMType.Text, _session, _url))
                {
                    frmRecipe.Location = this.Location;
                    this.Hide();
                    frmRecipe.ShowDialog();
                }
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
