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
            _session = wsSession;
            _url = url;
            _catalogOps = new BRCatalogWrapper(_session, _url);
            PopulateTreeWithConcepts();


        }
        public void PopulateTreeWithConcepts()
        {
            NamedArray dataConcepts = _catalogOps.GetAllConcepts();
            List<string> paths = new List<string>();
            foreach (Named dataConcept in dataConcepts)
            {
                if (dataConcept.Path.Length > 0)
                { paths.Add(dataConcept.Path.TrimStart('/')); }
            }
            //PathToTreeConverter.PopulateTreeView(trvCatalog, paths, '/');
            TreeNode node = PathToTreeConverter.MakeTreeFromPaths(paths, "BioRails", '/');
            trvCatalog.Nodes.Add(node);
        }

        public void PopulateTreeWithLookups()
        {
            NamedArray dataConcepts = _catalogOps.GetAllConcepts();
            List<string> paths = new List<string>();
            foreach (Named dataConcept in dataConcepts)
            {
                if (dataConcept.Path.Length > 0)
                { paths.Add(dataConcept.Path.TrimStart('/')); }
            }
            //PathToTreeConverter.PopulateTreeView(trvCatalog, paths, '/');
            TreeNode node = PathToTreeConverter.MakeTreeFromPaths(paths, "BioRails", '/');
            trvCatalog.Nodes.Add(node);
        }
    }
}
