using System;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using BR.Inv.Model;
using BR.Inv.Api;


namespace BR6WSInteractive
{
    public static class MaterialDataGridConverter
    {
        //this class is designed to convert a datagrid into an array of order items or vice versa
        public static void ConvertMaterialPropsToDataGrid(BRInvWrapper invWS, Dictionary<string, StringArray> matProps, string materialType, DataGridView dgvMat)
        {
            //this method is designed to populate a datagrid based on the properties of an existing BioRails materials
            try
            {
                int nloop = 0;
                if (matProps.Count > 0)
                {
                    dgvMat.Rows.Add(matProps.Count);
                    //for each property on the material set datagrid values
                    foreach (KeyValuePair<string, StringArray> mp in matProps)
                    {
                        //populate rows
                        dgvMat[0, nloop].Value = mp.Key.ToString();
                        foreach (string v in mp.Value)
                        {
                            //need to loop through values
                            dgvMat[1, nloop].Value = v;
                        }
                        nloop += 1;
                    }

                }
                else
                {
                    //need to get props from sample type
                    SampleType st = invWS.GetSampleType(materialType);
                    dgvMat.Rows.Add(st.Parameters.Count);
                    foreach (CustomParameter mp in st.Parameters)
                    {
                        //populate rows
                        dgvMat[0, nloop].Value = mp.Name;
                        nloop += 1;
                    }

                }
                dgvMat.AllowUserToAddRows = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred. " + ex.Message, "Error");
            }
        }
        public static Dictionary<string, StringArray> ConvertDataGridToProperties(DataGridView dgvMat)
        {
            //this method is designed to create an array of name values based on the contents of a datagrid
            NameValueCollection namevals = CharacterizeGrid(dgvMat);
            int nUnique = UniqueDGVNames(dgvMat);
            Dictionary<string, StringArray> nvs = new Dictionary<string, StringArray>();
            try
            {
                //for each item in the name value collection loop through and set names and values appropriately
                //create an array of namevalues based on the number of columns in the datagrid minus the conserved columns
                for (int i = 0; i < namevals.Count; i++)
                {
                    
                    string key = namevals.GetKey(i);
                    string value = namevals.Get(i);
                    StringArray vallist = new StringArray();
                    if (value != null)
                    {
                        string[] values = value.Split(',');
                        foreach (string s in values)
                        {
                            vallist.Add(s);
                        }

                    }
                    nvs.Add(key, vallist);

                }

                return nvs;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred. " + ex.Message, "Error");
                return nvs;
            }
        }
        public static int UniqueDGVNames(DataGridView dgvMat)
        {

            int v = 0;
            try
            {

                List<string> myStrings = new List<string>();
                foreach (DataGridViewRow dgr in dgvMat.Rows)
                {
                    if (dgr.Cells[0].Value != null)
                    {
                        if (!myStrings.Contains(dgr.Cells[0].Value.ToString()))
                        {
                            myStrings.Add(dgr.Cells[0].Value.ToString());
                        }
                    }
                }
                v = myStrings.Count;
                return v;

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred. " + ex.Message, "Error");
                return v;
            }
        }
        public static NameValueCollection CharacterizeGrid(DataGridView dgvMat)
        {
            //This method gets the unique names and sets their values in a name value collectoin
            NameValueCollection namevals = new NameValueCollection();
            try
            {
                for (int n = 0; n < dgvMat.Rows.Count; n++)
                {
                    if (dgvMat[0, n].Value != null)
                    { namevals.Add(dgvMat[0, n].Value.ToString(), dgvMat[1, n].Value == null ? null: dgvMat[1, n].Value.ToString()); }
                    
                }
                return namevals;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred. " + ex.Message, "Error");
                return namevals;
            }
        }

        public static void ConvertSampleParamsToDataGrid(CustomParameterArray nvs, DataGridView dgvMat)
        {
            //this method is designed to populate a datagrid based on the properties of an existing BioRails materials
            try
            {
                int nloop = 0;
                dgvMat.Rows.Add(nvs.Count);
                //for each property on the material set datagrid values
                //initialize array
                foreach (CustomParameter nv in nvs)
                {
                    //populate rows
                    dgvMat[0, nloop].Value = nv.Name;
                    nloop += 1;
                }
                dgvMat.AllowUserToAddRows = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred. " + ex.Message, "Error");
            }
        }

        public static void ConvertRecipeIngredientsToDataGrid(MaterialRecipeIngredientArray ingreds, DataGridView dgvIng)
        {
            //this method is designed to populate a datagrid based on the properties of an existing BioRails materials
            try
            {
                int nloop = 0;
                dgvIng.Rows.Add(ingreds.Count);
                //for each property on the material set datagrid values
                //initialize array
                foreach (MaterialRecipeIngredient ingred in ingreds)
                {
                    //populate rows
                    dgvIng[0, nloop].Value = ingred.Name;
                    dgvIng[1, nloop].Value = ingred.RoleName;
                    dgvIng[2, nloop].Value = ingred.SampleTypeName;
                    dgvIng[3, nloop].Value = ingred.TheoryPercentage;
                    nloop += 1;
                }
                dgvIng.AllowUserToAddRows = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred. " + ex.Message, "Error");
            }
        }

        public static void ConvertMaterialComponentsToDataGrid(MaterialComponentArray ingreds, DataGridView dgvIng)
        {
            //this method is designed to populate a datagrid based on the properties of an existing BioRails materials
            try
            {
                int nloop = 0;
                dgvIng.Rows.Add(ingreds.Count);
                //for each property on the material set datagrid values
                //initialize array
                foreach (MaterialComponent ingred in ingreds)
                {
                    //populate rows
                    dgvIng[0, nloop].Value = ingred.Name;
                    dgvIng[1, nloop].Value = ingred.RoleName;
                    dgvIng[2, nloop].Value = ingred.SampleTypeName;
                    dgvIng[3, nloop].Value = ingred.TheoryPercentage;
                    dgvIng[4, nloop].Value = ingred.DataName;
                    dgvIng[5, nloop].Value = ingred.DataValue.ToString() + " " + ingred.DataUnit;
                    nloop += 1;
                }
                dgvIng.AllowUserToAddRows = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred. " + ex.Message, "Error");
            }
        }

        public static MaterialComponentArray ConvertDataGridToMaterialComponents(DataGridView dgvIng)
        {
            MaterialComponentArray comps = new MaterialComponentArray();    
            try
            {

                //for each property on the material set datagrid values
                //initialize array
                for (int n = 0; n < dgvIng.Rows.Count; n++)
                {
                    string sQty = "";
                    double dPerc = 0;
                    double dQty = 0;
                    MaterialComponent comp = new MaterialComponent();
                    if (dgvIng[0, n].Value != null) { comp.Name = dgvIng[0, n].Value.ToString(); }
                    if (dgvIng[1, n].Value != null) { comp.RoleName = dgvIng[1, n].Value.ToString(); }
                    if (dgvIng[2, n].Value != null) { comp.SampleTypeName = dgvIng[2, n].Value.ToString(); }
                    if (dgvIng[3, n].Value != null)
                    {
                        if (Double.TryParse(dgvIng[3, n].Value.ToString(), out dPerc))
                        {
                            comp.TheoryPercentage = dPerc;
                        }
                        else
                        {
                            comp.TheoryPercentage = 0;
                        }
                    }
                    if (dgvIng[4, n].Value != null) { comp.DataName = dgvIng[4, n].Value.ToString(); }
                    if (dgvIng[5, n].Value != null)
                    {
                        sQty = dgvIng[5, n].Value.ToString();
                        String[] strlist = sQty.Split(' ');
                        comp.DataUnit = strlist[1];
                        if (Double.TryParse(strlist[0], out dQty))
                        { comp.DataValue = dQty; }
                        else
                        { comp.DataValue = 0; }


                    }
                    comps.Add(comp);
                }
                return comps;

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred. " + ex.Message, "Error");
                return comps;
            }
        }

        public static MaterialRecipeIngredientArray ConvertDataGridToRecipeIngredients(DataGridView dgvIng)
        {
            MaterialRecipeIngredientArray comps = new MaterialRecipeIngredientArray();
            try
            {

                //for each property on the material set datagrid values
                //initialize array
                for (int n = 0; n < dgvIng.Rows.Count; n++)
                {
                    double dPerc = 0;
                    MaterialRecipeIngredient comp = new MaterialRecipeIngredient();
                    if (dgvIng[0, n].Value != null) { comp.Name = dgvIng[0, n].Value.ToString(); }
                    if (dgvIng[1, n].Value != null) { comp.RoleName = dgvIng[1, n].Value.ToString(); }
                    if (dgvIng[2, n].Value != null) { comp.SampleTypeName = dgvIng[2, n].Value.ToString(); }
                    if (dgvIng[3, n].Value != null)
                    {
                        if (Double.TryParse(dgvIng[3, n].Value.ToString(), out dPerc))
                        {
                            comp.TheoryPercentage= dPerc;
                        }
                        else
                        {
                            comp.TheoryPercentage = 0;
                        }
                    }

                    comps.Add(comp);
                }
                return comps;

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred. " + ex.Message, "Error");
                return comps;
            }
        }



    }
}
