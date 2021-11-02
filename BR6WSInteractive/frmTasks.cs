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
    public partial class frmTasks : Form
    {
        Session _session;
        string _url;
        public frmTasks(Session wsSession, string url)
        {
            InitializeComponent();
            _session = wsSession;
            _url = url;
            GetTaskColumns();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                lstTasks.Items.Clear();
                BRTaskWrapper taskOps = new BRTaskWrapper(_session, _url);
                FolderArray tasks = taskOps.SearchForTasks(txtFilterVal.Text, cmbColumns.Text, cmbOperator.Text);
                foreach (Folder fl in tasks)
                {
                    lstTasks.Items.Add(fl.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void GetTaskColumns()
        {
            try
            {
                TasksApi tasksApi = new TasksApi(_url);
                FilterKeyArray array = tasksApi.TaskColumns(_session.SessionId);
                foreach (FilterKey fk in array)
                {
                    if(!fk.Name.Contains("."))
                    { cmbColumns.Items.Add("tasks." + fk.Name); }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
