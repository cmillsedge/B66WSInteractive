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

namespace BR6WSInteractive
{
    public partial class frmTaskImport : Form
    {

        Session _session;
        string _url;
        BROutlineWrapper _outlineOps;
        BRProcessWrapper _procOps;
        //TreeNode _originalnodes;
        public frmTaskImport(Session wsSession, string url)
        {
            InitializeComponent();
            lstvParams.View = View.Details;
            lstvFile.View = View.Details;
            try
            {
                _session = wsSession;
                _url = url;
                _outlineOps = new BROutlineWrapper(_session, _url);
                _procOps = new BRProcessWrapper(_session, _url);
                PopulateTreeWithOutlines();
                PopulateTreeWithProcesses();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error encountered");
            }
        }


        public void PopulateFixedItems()
        {
            try
            {
                var item = new ListViewItem(new[] { "Task Name" });
                lstvParams.Items.Add(item);
                item = new ListViewItem(new[] { "Task Description" });
                lstvParams.Items.Add(item);
                item = new ListViewItem(new[] { "Task Started At" });
                lstvParams.Items.Add(item);
                item = new ListViewItem(new[] { "Task Expected At" });
                lstvParams.Items.Add(item);
                item = new ListViewItem(new[] { "Task State" });
                lstvParams.Items.Add(item);
                item = new ListViewItem(new[] { "Task User" });
                lstvParams.Items.Add(item);
                item = new ListViewItem(new[] { "Task Team" });
                lstvParams.Items.Add(item);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error encountered");
            }
        }
        public void PopulateTreeWithOutlines()
        {
            try
            {
                FolderArray outlines = _outlineOps.GetAllOutlines();                
                List<string> paths = new List<string>();
                foreach (Folder outline in outlines)
                {
                    if (outline.Path.Length > 0)
                    { 
                        paths.Add(outline.Path.TrimStart('/'));
                    }
                }
                TreeNode node = NodeOperations.MakeTreeFromPaths(paths, 0, "Outlines", '/');
                trvOutlines.Nodes.Add(node);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error encountered");
            }
        }

        public void PopulateTreeWithProcesses()
        {
            try
            {
                List<string> paths = new List<string>();
                foreach (TreeNode tnode in trvOutlines.Nodes[0].Nodes)
                {
                    FolderArray processes = _procOps.GetProcessesForOutline(tnode.Text);
                    foreach (Folder process in processes)
                    {
                        if (process.ReferencePath.Length > 0)
                        {
                            string path = process.ReferencePath.Substring(0, process.ReferencePath.LastIndexOf('/'));
                            AddNodeByPath.AddProcNode(trvOutlines, path, process);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error encountered");
            }
        }

        private void btnDispParams_Click(object sender, EventArgs e)
        {
            Folder folder = (Folder)trvOutlines.SelectedNode.Tag;
            string path = folder.ReferencePath;
            Process process = _procOps.GetProcessByPath(path);
            string sContext = process.Parameters[0].ContextLabel;
            int nLevel = 1;
            lstvParams.Items.Clear();
            PopulateFixedItems();
            foreach (ProcessParameter p in process.Parameters)
            {
                if (sContext != p.ContextLabel)
                { nLevel += 1; }
                var item = new ListViewItem(new[] { p.Name + "(" + nLevel + ")" });
                lstvParams.Items.Add(item);
                sContext = p.ContextLabel;
            }
            CompareLists();
            
        }
        private string SelectExcelFile(string initialDirectory)
        {
            //simple method to open a file browse dialog restricted to Excel files for use with the import plate method 
            //See supporting files folder in this project for the only supported file format. 
            OpenFileDialog dialog = new OpenFileDialog();

            try
            {
                //dialog.Filter = "Comma Seperated Files (*.csv)|*.csv|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                dialog.Filter = "New Excel(*.xlsx)|*.xlsx";
                dialog.InitialDirectory = initialDirectory;
                dialog.Title = "Select an Excel File ..";
                dialog.FileName = "";

                if (dialog.ShowDialog() == DialogResult.OK)
                {

                    //sStartPath = System.IO.Path.GetDirectoryName(dialog.FileName);
                    return (dialog.FileName);
                }
                else
                {
                    return (string.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return (string.Empty);
            }

        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            try
            {
                //get a file starting in C:\
                string myfile = SelectExcelFile("C:\\");
                //use static method to convert the Excel sheet to a dataset
                DataSet ds = ExcelToDataSet.Parse(myfile);
                lstvFile.Items.Clear();
                foreach(DataColumn dc in ds.Tables[0].Columns)
                {
                    var item = new ListViewItem(new[] { dc.ColumnName });
                    lstvFile.Items.Add(item);
                }
                CompareLists();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void CompareLists()
        {
            try
            {
                if (lstvFile.Items.Count > 0 && lstvParams.Items.Count > 0)
                {
                    for (int p = 0; p < lstvParams.Items.Count; p++)
                    {
                        for (int f = 0; f < lstvFile.Items.Count; f++)
                        {
                            if (lstvParams.Items[p].Text.ToString().ToLower().Contains(lstvFile.Items[f].Text.ToString().ToLower()) || 
                                lstvFile.Items[f].Text.ToString().ToLower().Contains(lstvParams.Items[p].Text.ToString().ToLower()))
                            {
                                lstvParams.Items[p].BackColor = Color.LightGreen;
                                lstvFile.Items[f].BackColor = Color.LightGreen;
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

    }
}
