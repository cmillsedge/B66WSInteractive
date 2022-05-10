using System;
using System.Data;
using System.Windows.Forms;
using BR.Inv.Model;
using BR.Inv.Api;

namespace BR6WSInteractive
{
    static class PlateFromDataSet 
    {   //This class is designed to convert a dataset (based on a file) into a plate container object
        public static Container GetPlateFromDataSet(DataSet data)
        {
            int ncount = 1;
            int acount = 0;
            int nrows = data.Tables["Table1"].Rows.Count;
            //create a plate object
            Container plate = new Container();
            //create an array of samples
            ContainerSampleArray platesamples = new ContainerSampleArray();
            
            try
            {
                //go through each row in the dataset
                foreach (DataRow dr in data.Tables["Table1"].Rows)
                {
                    acount = ncount - 1;
                    //initialise plate sample
                    ContainerSample platesample = new ContainerSample();
                    if (ncount == 1)
                    {
                        //on the first loop set all the plate properties - note this is currently only designed to deal with a single plate in the file
                        plate.ContainerTypeName = dr[1].ToString();
                        plate.ContainerLayoutName = dr[2].ToString();
                        plate.Name = dr[3].ToString();
                        plate.Description = dr[4].ToString();
                        plate.SampleTypeName = dr[5].ToString();
                        plate.Comments = dr[6].ToString();
                        plate.LocationPath = dr[7].ToString();
                        plate.LocationRow = CleanNullInt(dr[8].ToString());
                        plate.LocationColumn = CleanNullInt(dr[9].ToString());
                        plate.TransportLabel = dr[10].ToString();
                        if (dr[11].ToString() != "") {  plate.CollectionName = dr[11].ToString(); }
                        if (dr[12].ToString() != "") {  plate.OrderSystemName = dr[12].ToString(); }
                        if (dr[13].ToString() != "") {  plate.ProtectionTypeName = dr[13].ToString(); }
                        if (dr[14].ToString() != "") {  plate.ProtectorUserName = dr[14].ToString(); }
                        if (dr[15].ToString() != String.Empty)
                        { plate.ExpiresAt = CleanNullDate(dr[15].ToString()); }
                        if (dr[16].ToString() != String.Empty)
                        { plate.QualifiedUntilAt = CleanNullDate(dr[16].ToString()); }
                        plate.ThawCycleNo = CleanNullInt(dr[17].ToString());
                        plate.MaxThawCycleNo = CleanNullInt(dr[18].ToString());
                        plate.TareWeightValue = CleanNullDob(dr[19].ToString());
                        plate.TareWeightUnit = CleanNullStr(dr[20].ToString());
                        //plate.tare_weight_unit = "mg";
                    }
                    //for every row we need to set the plate sample properties
                    platesample.SlotRow = CleanNullInt(dr[21].ToString());
                    platesample.SlotColumn = CleanNullInt(dr[22].ToString());
                    platesample.QuantityValue = CleanNullDob(dr[23].ToString());
                    platesample.QuantityUnit = dr[24].ToString();
                    platesample.ConcentrationValue = CleanNullDob(dr[25].ToString());
                    platesample.ConcentrationUnit = dr[26].ToString();
                    //don't set solvent if it is not needed or you will get an error
                    if (dr[27].ToString() != "")
                    { platesample.SolventName = dr[27].ToString(); }
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
                        platesample.SolventConc = dval; 
                    }
                    platesample.Name = dr[29].ToString();

                    platesamples.Add(platesample);
                    ncount = ncount + 1;
                }
                plate.Samples = platesamples;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred. " + ex.Message, "Error");
            }

            

            return plate;
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
