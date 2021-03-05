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
    public partial class frmLogOn : Form
    {
        public frmLogOn()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                string url = txtURL.Text.TrimEnd('/');
                SessionsApi s = new SessionsApi(url + "/api/v6");
                Session key = s.Login(txtUser.Text, txtPass.Text);
                Console.WriteLine(key.SessionId);
                using (frmSelect frmSelect = new frmSelect(key, url + "/api/v6"))
                {
                    frmSelect.Location = this.Location;
                    this.Hide();
                    frmSelect.ShowDialog();

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
