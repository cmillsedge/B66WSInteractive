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
        public frmCatalog(Session wsSession, string url)
        {
            InitializeComponent();
            _session = wsSession;
            _url = url;
        }
    }
}
