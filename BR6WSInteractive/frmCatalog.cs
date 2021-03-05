using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace BR6WSInteractive
{
    public partial class frmCatalog : Form
    {
        Session _session;
        string _url;
        BRCatalogWrapper _catalogOps;
        public frmCatalog(Session wsSession, string url)
        {
            InitializeComponent();
            try
            {
                _session = wsSession;
                _url = url;
                _catalogOps = new BRCatalogWrapper(_session, _url);
                PopulateTreeWithConcepts();
                PopulateTreeWithParams();
                PopulateTreeWithLookups();
                PopulateOutlines();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error encountered");
            }


        }
        public void PopulateTreeWithConcepts()
        {
            try
            {
                NamedArray dataConcepts = _catalogOps.GetAllConcepts();
                List<string> paths = new List<string>();
                foreach (Named dataConcept in dataConcepts)
                {
                    if (dataConcept.Path.Length > 0)
                    { paths.Add(dataConcept.Path.TrimStart('/')); }
                }
                TreeNode node = PathToTreeConverter.MakeTreeFromPaths(paths, 0, "BioRails Catalog", '/');
                trvCatalog.Nodes.Add(node);
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message, "Error encountered");
            }
        }

        public void PopulateTreeWithParams()
        {
            try
            { 
                ParameterTypeAliasArray parameterTypeAliases = _catalogOps.GetParamAliases();
                foreach (ParameterTypeAlias parameterTypeAlias in parameterTypeAliases)
                {
                    if (parameterTypeAlias.Path.LastIndexOf('/') != 0)
                    {
                        string path = parameterTypeAlias.Path.Substring(0, parameterTypeAlias.Path.LastIndexOf('/'));
                        AddNodeByPath.AddPTypeNode(trvCatalog, path, parameterTypeAlias);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error encountered");
            }
        }

        public void PopulateTreeWithLookups()
        {
            try
            {
                NamedArray dataElements = _catalogOps.GetLookups();
                foreach (Named dataElement in dataElements)
                {
                    if (dataElement.Path.LastIndexOf('/') != 0)
                    {
                        dataElement.Path = dataElement.Path;
                        string path = dataElement.Path.Substring(0, dataElement.Path.LastIndexOf('/'));
                        //Console.WriteLine("Search Path: " + path + " | Element Path: " + dataElement.Path + " | Element Name: " + dataElement.Name);
                        AddNodeByPath.AddLookupNode(trvCatalog, path, dataElement);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error encountered");
            }
        }

        public void PopulateOutlines()
        {

            try
            {
                BROutlineWrapper outlineOps = new BROutlineWrapper(_session, _url);
                FolderArray outlines = outlineOps.GetAllOutlines();
                foreach (Folder outline in outlines)
                {
                    cmbOutlines.Items.Add(outline.Name);
                }
                cmbOutlines.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error encountered");
            }
        }

        private void cmbOutlines_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateOutlineParams();
        }

        private void UpdateOutlineParams()
        {
            try
            {
                BROutParamWrapper paramOps = new BROutParamWrapper(_session, _url);
                OutlineParameterArray parameters = paramOps.GetAllOutlineParameters(cmbOutlines.SelectedItem.ToString());
                dgvParams.Rows.Clear();
                dgvParams.AllowUserToAddRows = true;
                foreach (OutlineParameter op in parameters)
                {
                    dgvParams.Rows.Add(op.Name, op.Description, op.ParameterRoleName, op.DataTypeName, op.DataElementPath, op.DisplayUnit);
                }
                dgvParams.Sort(dgvParams.Columns["ParameterName"], ListSortDirection.Ascending);
                dgvParams.AllowUserToAddRows = false;
                dgvParams.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error encountered");
            }
        }

        private void trvCatalog_ItemDrag(object sender, ItemDragEventArgs e)
        {
            // Initiate drag/drop
            TreeNode nod = (TreeNode)e.Item;
            DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void dgvParams_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void dgvParams_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                TreeNode node = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");
                if (node.Tag != null && node.Tag.GetType().ToString() == "IO.Swagger.Model.ParameterTypeAlias" && cmbOutlines.Text != "")
                { 
                    using (frmParameterAdd frmParam = new frmParameterAdd(_session, _url, cmbOutlines.Text, (ParameterTypeAlias)node.Tag))
                    {
                        frmParam.Location = this.Location;
                        frmParam.ShowDialog();

                    }
                    UpdateOutlineParams();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error encountered");
            }
        }
    }
}
