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
    public partial class frmSelect : Form
    {
        Session _session;
        string _url;
        public frmSelect(Session wsSession, string url)
        {
            InitializeComponent();
            _session = wsSession;
            _url = url;
        }

        private void btnCatalog_Click(object sender, EventArgs e)
        {
            try
            {
                using (frmCatalog frmCatalog = new frmCatalog(_session, _url + "/api/v6"))
                {
                    frmCatalog.Location = this.Location;
                    this.Hide();
                    frmCatalog.ShowDialog();

                }
                //frmSel closed re-display logon
                this.Show();
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
