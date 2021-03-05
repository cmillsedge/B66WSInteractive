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
            PopulateTreeWithParams();
            PopulateTreeWithLookups();


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
            TreeNode node = PathToTreeConverter.MakeTreeFromPaths(paths, 0, "BioRails Catalog", '/');
            trvCatalog.Nodes.Add(node);
        }

        public void PopulateTreeWithParams()
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

        public void PopulateTreeWithLookups()
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
    }
}
