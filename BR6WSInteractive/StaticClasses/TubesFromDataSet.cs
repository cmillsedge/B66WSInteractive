using System;
using System.Data;
using System.Windows.Forms;
using BR.Inv.Model;
using BR.Inv.Api;

namespace BR6WSInteractive
{
    static class TubesFromDataSet
    {   //This class is designed to convert a dataset (based on a file) into a tube container object
        public static ContainerArray GetTubesFromDataSet(DataSet data)
        {
            int ncount = 1;
            int acount = 0;
            int nrows = data.Tables["Table1"].Rows.Count;
            //create a tube object
            ContainerArray cArray = new ContainerArray();

            //create an array of samples

            try
            {

                //go through each row in the dataset
                foreach (DataRow dr in data.Tables["Table1"].Rows)
                {
                    acount = ncount - 1;
                    //initialise tube sample
                    Container cont = new Container();
                    ContainerSampleArray samples = new ContainerSampleArray();  
                    cont.Samples = samples;
                    ContainerSample tubesample = new ContainerSample(); 

                    if (dr[0].ToString() != String.Empty)
                    { cont.Id = dr[0].ToString(); }
                    if (dr[1].ToString() != String.Empty)
                    { cont.ContainerTypeName = dr[1].ToString(); }
                    if (dr[2].ToString() != String.Empty)
                    { cont.ContainerLayoutName = dr[2].ToString(); }
                    if (dr[3].ToString() != String.Empty)
                    { cont.Name = dr[3].ToString(); }
                    if (dr[4].ToString() != String.Empty)
                    { cont.Description = dr[4].ToString(); }
                    if (dr[5].ToString() != String.Empty)
                    { cont.SampleTypeName = dr[5].ToString(); }
                    if (dr[6].ToString() != String.Empty)
                    { cont.Comments = dr[6].ToString(); }
                    if (dr[7].ToString() != String.Empty)
                    { cont.LocationPath = dr[7].ToString(); }
                    if (dr[8].ToString() != String.Empty)
                    { cont.LocationRow = CleanNullInt(dr[8].ToString()); }
                    if (dr[9].ToString() != String.Empty)
                    { cont.LocationColumn = CleanNullInt(dr[9].ToString()); }
                    if (dr[10].ToString() != String.Empty)
                    { cont.TransportLabel = dr[10].ToString(); }
                    if (dr[11].ToString() != String.Empty)
                    { cont.CollectionName = dr[11].ToString(); }
                    if (dr[12].ToString() != String.Empty)
                    { cont.OrderSystemName = dr[12].ToString(); }
                    if (dr[13].ToString() != String.Empty)
                    { cont.ProtectionTypeName = dr[13].ToString(); }
                    if (dr[14].ToString() != String.Empty)
                    { cont.ProtectorUserName = dr[14].ToString(); }
                    if (dr[15].ToString() != String.Empty)
                    { cont.ExpiresAt = CleanNullDate(dr[15].ToString()); }
                    if (dr[16].ToString() != String.Empty)
                    { cont.QualifiedUntilAt = CleanNullDate(dr[16].ToString()); }
                    if (dr[17].ToString() != String.Empty)
                    { cont.ThawCycleNo = CleanNullInt(dr[17].ToString()); }
                    if (dr[18].ToString() != String.Empty)
                    { cont.MaxThawCycleNo = CleanNullInt(dr[18].ToString()); }
                    if (dr[19].ToString() != String.Empty)
                    { cont.TareWeightValue = CleanNullDob(dr[19].ToString()); }
                    if (dr[20].ToString() != String.Empty)
                    { cont.TareWeightUnit = CleanNullStr(dr[20].ToString()); }
                    //cont.tare_weight_unit = "mg";

                    //for every row we need to set the tube sample properties
                    if (dr[21].ToString() != String.Empty)
                    { tubesample.SlotRow = CleanNullInt(dr[21].ToString()); }
                    if (dr[22].ToString() != String.Empty)
                    { tubesample.SlotColumn = CleanNullInt(dr[22].ToString()); }
                    if (dr[23].ToString() != String.Empty)
                    { tubesample.QuantityValue = CleanNullDob(dr[23].ToString()); }
                    if (dr[24].ToString() != String.Empty)
                    { tubesample.QuantityUnit = dr[24].ToString(); }
                    if (dr[25].ToString() != String.Empty)
                    { tubesample.ConcentrationValue = CleanNullDob(dr[25].ToString()); }
                    if (dr[26].ToString() != String.Empty)
                    { tubesample.ConcentrationUnit = dr[26].ToString(); }
                    //don't set solvent if it is not needed or you will get an error
                    if (dr[27].ToString() != "")
                    { tubesample.SolventName = dr[27].ToString(); }
                    if (dr[28].ToString() != "")
                    {
                        Double dval;
                        if (Double.TryParse(dr[28].ToString(), out dval))
                        {
                            dval = Double.Parse(dr[28].ToString());
                        }
                        else
                        {
                            dval = 0.0;
                        }
                        tubesample.SolventConc = dval; 
                    }
                    tubesample.Name = dr[29].ToString();

                    cont.Samples.Add(tubesample);
                    cArray.Add(cont);
                    ncount += 1;

                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred. " + ex.Message, "Error");
            }



            return cArray;
        }

        //Due to SOAP and WASHOUT behaviour nulls are not well supported so we need to convert them to a known "null" representing values.
        //Examples include 1753 for dates and 0 for doubles
        //All the methods below are designed to do exactly that for different data type
        private static DateTime CleanNullDate(string sdate)
        {
            DateTime dtime;
            if (DateTime.TryParse(sdate, out dtime))
            {
                dtime = DateTime.Parse(sdate);
            }
            else
            {
                dtime = new DateTime(1753, 01, 01);
            }

            return dtime;
        }

        private static int CleanNullInt(string sint)
        {
            int ival;
            if (Int32.TryParse(sint, out ival))
            {
                ival = Int32.Parse(sint);
            }
            else
            {
                ival = int.MinValue;
            }
            return ival;
        }

        private static Double CleanNullDob(string sdob)
        {
            Double dval;
            if (Double.TryParse(sdob, out dval))
            {
                dval = Double.Parse(sdob);
            }
            else
            {
                dval = 0.0;
            }
            return dval;
        }

        private static string CleanNullStr(string str)
        {
            string sret;
            try
            {
                if (str is null)
                { sret = String.Empty; }
                else
                {
                    sret = str;
                }
            }
            catch (Exception ex)
            {
                sret = String.Empty;
            }
            return sret;
        }

    }
}
