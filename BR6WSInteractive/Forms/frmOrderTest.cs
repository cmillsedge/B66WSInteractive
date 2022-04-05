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
    public partial class frmOrderTest : Form
    {
        //Simple form which allows user to choose whether they are creating or updating orders. No real WS code in here.
        Session _session;
        string _url;
        Font _bigFont;
        Font _normFont;
        public frmOrderTest(Session wsSession, string url)
        {
            InitializeComponent();
            _session = wsSession;
            _url = url;
            _bigFont = new Font("Times New Roman", 12.0f);
            _normFont = new Font("Times New Roman", 10.0f);

        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                using (frmOrdCreate frmOrd = new frmOrdCreate(_session, _url))
                {
                    frmOrd.Location = this.Location;
                    frmOrd.ShowDialog();
                    this.Hide();
                }
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (frmOrdUpdate frmUpd = new frmOrdUpdate( _session, _url))
                {
                    frmUpd.Location = this.Location;
                    frmUpd.ShowDialog();
                    this.Hide();
                }
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnShipments_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    using (frmShipments frmShip = new frmShipments(_coreWS, _InvWS, _OrdWS, _session))
            //    {
            //        frmShip.Location = this.Location;
            //        frmShip.ShowDialog();
            //        this.Hide();
            //    }
            //    this.Show();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error");
            //}
        }
    }
}
