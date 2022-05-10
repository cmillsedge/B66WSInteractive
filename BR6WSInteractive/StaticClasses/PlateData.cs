using System;//For strings and things
using System.Data;//to generate a DataSet
using System.Windows.Forms;

namespace BR6WSInteractive
{
    static class PlateData
    {
        public static DataSet GetPlateDataSet(DataSet pdata)
        {
            try
            {
                //this method is designed to create a REFERENCE dataset to compare to the file being imported
                //if the columns in the imported dataset don't match these then we will raise an error (elsewhere)
                DataTable ptable = pdata.Tables.Add("Plate");
                DataColumn ccol = ptable.Columns.Add("Container ID", typeof(string));
                DataColumn ccol2 = ptable.Columns.Add("ContainerType", typeof(string));
                ptable.Columns.Add("ContainerLayout", typeof(string));
                ptable.Columns.Add("Name", typeof(string));
                ptable.Columns.Add("Description", typeof(string));
                ptable.Columns.Add("SampleTypeNameField", typeof(string));
                ptable.Columns.Add("Comment", typeof(string));
                ptable.Columns.Add("Location", typeof(string));
                ptable.Columns.Add("LocationRow", typeof(string));
                ptable.Columns.Add("LocationColumn", typeof(string));
                ptable.Columns.Add("TransportLabel", typeof(string));
                ptable.Columns.Add("Collection", typeof(string));
                ptable.Columns.Add("OrderSystem", typeof(string));
                ptable.Columns.Add("ProtectionType", typeof(string));
                ptable.Columns.Add("ProtectionUser", typeof(string));
                ptable.Columns.Add("ExpirationDate", typeof(string));
                ptable.Columns.Add("QualifiedUntil", typeof(string));
                ptable.Columns.Add("CurrentFreezeThaw", typeof(string));
                ptable.Columns.Add("MaxFreezeThaw", typeof(string));
                ptable.Columns.Add("TareWeight", typeof(string));
                ptable.Columns.Add("TareWeightUnit", typeof(string));
                ptable.Columns.Add("WellRowField", typeof(string));
                ptable.Columns.Add("WellColumnField", typeof(string));
                ptable.Columns.Add("QuantityField", typeof(string));
                ptable.Columns.Add("QuantityUnitField", typeof(string));
                ptable.Columns.Add("ConcentrationField", typeof(string));
                ptable.Columns.Add("ConcentrationUnitField", typeof(string));
                ptable.Columns.Add("SolventField", typeof(string));
                ptable.Columns.Add("SolventPercentageField", typeof(string));
                ptable.Columns.Add("SampleNameField", typeof(string));
                return pdata;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return pdata; 
            }
        }

        public static bool ValidPlateDataSet(DataSet pds, DataSet ds)
        {
            bool bvalid = false;
            try
            {
                Int32 colcount = pds.Tables["Plate"].Columns.Count;
                //loop through the columns in the dataset based on the file and check they match the reference dataset.
                for (int i = 0; i < colcount; i++)
                {
                    
                    if (pds.Tables["Plate"].Columns[i].ColumnName == ds.Tables["Table1"].Columns[i].ColumnName)
                    { bvalid = true; }
                    else
                    { bvalid = false; }
                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return (false);
            }
            return bvalid;
        }


    }
}
