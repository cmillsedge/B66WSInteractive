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
    public partial class frmParameterAdd : Form
    {
        Session _session;
        string _url;
        string _path;
        ParameterTypeAlias _alias;
        public frmParameterAdd(Session wsSession, string url, string path, ParameterTypeAlias alias)
        {
            InitializeComponent();
            try
            {
                _session = wsSession;
                _url = url;
                _alias = alias;
                _path = path;
                BRCatalogWrapper catalogOps = new BRCatalogWrapper(_session, _url);
                txtName.Text = alias.Name;
                txtDescription.Text = alias.Description;
                cmbRole.Text = alias.ParameterRoleName;
                GetRoles(catalogOps);
                if (alias.DataElementPath != null)
                { 
                    cmbLookup.Text = alias.DataElementPath;
                    GetLookups(catalogOps);
                }
                else
                { cmbLookup.Enabled = false; }
                if (alias.DisplayUnit != null)
                { txtUnit.Text = alias.DisplayUnit; }
                else
                { txtUnit.Enabled = false; }
                    
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error encountered");
            }
        }

        private void GetLookups(BRCatalogWrapper catalogOps)
        {
            NamedArray dataElements = catalogOps.GetLookups();
            foreach (Named dataElement in dataElements)
            {
                cmbLookup.Items.Add(dataElement.Path);
            }
        }

        private void GetRoles(BRCatalogWrapper catalogOps)
        {
            ParameterRoleArray parameterRoles = catalogOps.GetRoles();
            foreach (ParameterRole parameterRole in parameterRoles)
            {
                cmbRole.Items.Add(parameterRole.Name);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                BROutParamWrapper paramOps = new BROutParamWrapper(_session, _url);
                OutlineParameter op = new OutlineParameter(Name: txtName.Text,
                                                           Description: txtDescription.Text,
                                                           DataTypeName: _alias.DataTypeName,
                                                           ParameterTypeName: _alias.ParameterTypeName,
                                                           DataFormatName: _alias.DataFormatName,
                                                           DisplayUnit: txtUnit.Text,
                                                           ParameterRoleName: cmbRole.Text,
                                                           DataElementPath: cmbLookup.Text
                                                          );

                string error = paramOps.CreateOutlineParameter(_path, op);
                if (error != "")
                { MessageBox.Show(error, "An error occurred during creation"); }
                else
                { this.Close(); }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "An error occurred during creation");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
