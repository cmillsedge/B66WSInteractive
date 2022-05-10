using System;
using System.Collections.Generic;
//using System.ComponentModel;
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
    public partial class frmIndTube : Form
    {
        //private member variables for encapsulation
        //private member variables for encapsulation
        Session _session;
        string _url;
        BRInvWrapper _invOps;
        BRCatalogWrapper _catOps;
        Font _bigFont;
        Font _normFont;
        public frmIndTube(Session wsSession, string url)
        {
            //set private variables
            //set member variable values
            _session = wsSession;
            _url = url;
            _bigFont = new Font("Times New Roman", 12.0f);
            _normFont = new Font("Times New Roman", 10.0f);
            _invOps = new BRInvWrapper(_session, _url);
            _catOps = new BRCatalogWrapper(_session, _url);
            InitializeComponent();
            ConfigureForm();
        }

        private void ConfigureForm()
        {
            try
            {
                //This is a set of calls to the web services to get values for lookups on the form and set them
                //Create inventory name array and call get container types to populate it
                ContainerTypeArray ctArray = _invOps.GetAllContainerTypes();
                //populate combo with vals
                InvWSCombos.PopulateCombo(cmbTypeLoad, ctArray);
                //get sample types 
                SampleTypeArray stArray = _invOps.GetAllSampleTypes();
                InvWSCombos.PopulateCombo(cmbSType, stArray);
                cmbSType.Text = "batch";
                //get container layouts
                ContainerLayoutArray clArray = _invOps.GetAllContainerLayouts();
                InvWSCombos.PopulateCombo(cmbLayoutLoad, clArray);
                //Create core name array and call get dict vals to get the list of protection types then populate combo
                BioRails.Core.Model.NamedArray protections = _catOps.GetDictVals("/Root/Inventory/Container/ProtectionType/Protection", "", 100, 0);
                CoreWSCombos.PopulateCombo(cmbProtections, protections);
                //get users for protectors combo
                BioRails.Core.Model.NamedArray users = _catOps.GetDictVals("/Root/Catalogue/Users/active", "", 100, 0);
                CoreWSCombos.PopulateCombo(cmbProtector, users);
                //Get order systems
                BioRails.Core.Model.NamedArray osystems = _catOps.GetDictVals("/Root/Inventory/OrderSystem/All", "", 100, 0);
                CoreWSCombos.PopulateCombo(cmbSystem, osystems);
                //Get a the selected sample type as a sample type object and use it to get the path to the dictionary for the sample type
                SampleType stype = _invOps.GetSampleType(cmbSType.Text);
                //Get list of valid sample names for that sample type
                BioRails.Core.Model.NamedArray sNames = _catOps.GetDictVals(stype.DataElementPath, "", 100, 0);
                CoreWSCombos.PopulateCombo(cmbContents, sNames);
                //Get order system ? Think I did this above - leaving for now
                //nmdcore = CoreWSCombos.GetDictVals(_session, _coreWS, "/Root/Inventory/OrderSystem", "All", "b");
                //CoreWSCombos.PopulateCombo(cmbSystem, nmdcore);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred. " + ex.Message, "Error");
            }
        }

        private void GetTube()
        {
            Container myContainer = new Container();
            try
            {
                //Get a container based on container name in form
                myContainer = _invOps.GetContainer(txtSource.Text);
                //Populate form with all properties of container
                SerializeTube (myContainer);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred. " + ex.Message, "Error");
            }
        }

        private void SerializeTube(Container myContainer)
        { //DateTime dt = new DateTime(1753, 01, 01);
            try
            {
                //set form controls equal to container properties.
                //mostly straightforward -- see comments where it is not obvious
                lblId.Text = myContainer.Id;
                txtName.Text = myContainer.Name;
                txtDescrip.Text = myContainer.Description;
                cmbTypeLoad.Text = myContainer.ContainerTypeName;
                cmbLayoutLoad.Text = myContainer.ContainerLayoutName;
                cmbSType.Text = myContainer.SampleTypeName;
                if (myContainer.ProtectionTypeName != null) { cmbProtections.Text = myContainer.ProtectionTypeName; }
                if (myContainer.ProtectorUserName != null) { cmbProtector.Text = myContainer.ProtectorUserName; }
                if (myContainer.CollectionName != null) { txtCollection.Text = myContainer.CollectionName; }
                if (myContainer.OrderSystemName != null) { cmbSystem.Text = myContainer.OrderSystemName; }
                txtTransport.Text = myContainer.TransportLabel;
                txtLocation.Text = myContainer.LocationPath;
                numRow.Value = (int)myContainer.LocationRow;
                numCol.Value = (int)myContainer.LocationColumn;
                if (myContainer.TareWeightValue != null) { numTare.Value = (decimal)myContainer.TareWeightValue; }
                cmbTareUnit.Text = myContainer.TareWeightUnit;
                txtCThaw.Text = myContainer.ThawCycleNo.ToString();
                txtMThaw.Text = myContainer.MaxThawCycleNo.ToString();
                if (myContainer.QualifiedUntilAt != null) { dtQualDate.Value = (DateTime)myContainer.QualifiedUntilAt; }
                if (myContainer.ExpiresAt != null) { dtQualDate.Value = (DateTime)myContainer.ExpiresAt; }
                numQty.Value = (decimal)myContainer.Samples[0].QuantityValue;
                cmbQtyUnit.Text = myContainer.Samples[0].QuantityUnit;
                if (myContainer.Samples[0].ConcentrationValue != null) { numConc.Value = (decimal)myContainer.Samples[0].ConcentrationValue; }
                if (myContainer.Samples[0].ConcentrationUnit != null) { cmbConcUnit.Text = myContainer.Samples[0].ConcentrationUnit; }
                if (myContainer.Samples[0].SolventName != null) { cmbSolvent.Text = myContainer.Samples[0].SolventName; }
                if (myContainer.Samples[0].SolventConc != null) { txtSPercent.Text = myContainer.Samples[0].SolventConc.ToString(); }
                cmbContents.Text = myContainer.Samples[0].Name;


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred. " + ex.Message, "Error");
            }
        }

        private Container DeSerializeTube()
        {
            //DateTime dt = new DateTime(1753, 01, 01);
            Container myContainer = new Container();
            ContainerSample[] samples = new ContainerSample[1];
            ContainerSample sample = new ContainerSample();
            try
            {
                //set container properties equal to form control values
                //mostly straightforward -- see comments where it is not obvious
                myContainer.Name = txtName.Text;
                myContainer.Description = txtDescrip.Text;
                myContainer.ContainerTypeName = cmbTypeLoad.Text;
                myContainer.ContainerLayoutName = cmbLayoutLoad.Text;
                myContainer.SampleTypeName = cmbSType.Text;
                if (cmbProtections.Text != "") { myContainer.ProtectionTypeName = cmbProtections.Text; }
                if (cmbProtector.Text != "") { myContainer.ProtectorUserName = cmbProtector.Text; }
                if (txtCollection.Text != "") { myContainer.CollectionName = txtCollection.Text; }
                if (cmbSystem.Text != "") { myContainer.OrderSystemName = cmbSystem.Text; }
                myContainer.TransportLabel = txtTransport.Text;
                myContainer.LocationPath = txtLocation.Text;
                myContainer.TareWeightUnit = cmbTareUnit.Text;
                myContainer.TareWeightValue = (double)numTare.Value;
                if (txtCThaw.Text != "")
                {
                    int ival;
                    if (Int32.TryParse(txtCThaw.Text, out ival))
                    {
                        ival = Int32.Parse(txtCThaw.Text);
                        myContainer.ThawCycleNo = ival;
                    }  
                }
                if (txtMThaw.Text != "")
                {
                    int ival;
                    if (Int32.TryParse(txtMThaw.Text, out ival))
                    {
                        ival = Int32.Parse(txtMThaw.Text);
                        myContainer.MaxThawCycleNo = ival;
                    } 
                }
                if (dtQualDate.Checked) { myContainer.QualifiedUntilAt = dtQualDate.Value; }
                if (dtExpireDate.Checked) { myContainer.ExpiresAt = dtExpireDate.Value; }
                myContainer.LocationRow = (int)numRow.Value;
                myContainer.LocationColumn = (int)numCol.Value;
                sample.QuantityUnit = cmbQtyUnit.Text;
                if (numConc.Value != 0 ) { sample.ConcentrationValue = (double)numConc.Value; }
                if (numConc.Value != 0 ) { sample.ConcentrationUnit = cmbConcUnit.Text; }
                //Do not set the property for solvent at all when you do not want to set it otherwise you might get an error about missing solvent
                if (cmbSolvent.Text != "") { sample.SolventName = cmbSolvent.Text; }
                if (txtSPercent.Text != "") 
                {
                    Double dval;
                    if (Double.TryParse(txtSPercent.Text, out dval))
                    {
                        dval = Double.Parse(txtSPercent.Text);
                        sample.SolventConc = dval;
                    } 
                }
                sample.Name = cmbContents.Text;
                sample.QuantityValue = (double)numQty.Value ;
                sample.SlotRow = 1;
                sample.SlotColumn = 1;
                samples[0] = sample;
                ContainerSampleArray csArray = new ContainerSampleArray();
                csArray.Add(sample);
                myContainer.Samples = csArray;
                return myContainer;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred. " + ex.Message, "Error");
                return myContainer;
            }
        }

        private void BtnGetTest_Click(object sender, EventArgs e)
        {
            GetTube();
        }

        

        private void CmbProtector_KeyUp(object sender, KeyEventArgs e)
        {
            if (cmbProtector.Text != "")
            {
                //active refresh of combo contents based on letters typed into combo 
                BioRails.Core.Model.NamedArray users = _catOps.GetDictVals("/Root/Catalogue/Users/active", cmbProtector.Text, 100, 0);
                CoreWSCombos.PopulateCombo(cmbProtector, users);
            }
        }

        private void CmbProtections_KeyUp(object sender, KeyEventArgs e)
        {
            if (cmbProtections.Text != "")
            {
                //active refresh of combo contents based on letters typed into combo 
                BioRails.Core.Model.NamedArray protections = _catOps.GetDictVals("/Root/Inventory/Container/ProtectionType/Protection", cmbProtections.Text, 100, 0);
                CoreWSCombos.PopulateCombo(cmbProtections, protections);
            }
        }

        private void CmbSystem_KeyUp(object sender, KeyEventArgs e)
        {
            if (cmbSystem.Text != "")
            {
                //active refresh of combo contents based on letters typed into combo 
                BioRails.Core.Model.NamedArray osystems = _catOps.GetDictVals("/Root/Inventory/OrderSystem/All", cmbSystem.Text, 100, 0);
                CoreWSCombos.PopulateCombo(cmbSystem, osystems);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Container myContainer = DeSerializeTube();
            
            try
            { 
                if (txtSource.Text == txtName.Text)
                {//updating
                    //call container update 
                    myContainer.Id = lblId.Text;
                    Container myNewContainer = _invOps.UpdateContainer(myContainer.Name, myContainer);
                    RichTextBoxExtensions.AppendText(rtbWSOutput, "Container Update Succesful", Color.Green, _normFont);
                }
                else
                {//creating
                    //call container create 
                    Container myNewContainer = _invOps.CreateContainer(myContainer);
                    //call static method to process outcome and update richtextbox
                    RichTextBoxExtensions.AppendText(rtbWSOutput, "Container Create Succesful", Color.Green, _normFont);
                }
            }
            catch (BR.Inv.Client.ApiException apiEx)
            {
                string msg = BRExceptionCleaner.GetErrorMessageFromBioRailsError(apiEx.Message);
                RichTextBoxExtensions.AppendText(rtbWSOutput, "Create or Update Failed - " + msg, Color.Red, _normFont);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred. " + ex.Message, "Error");
            }
        }

        private void cmdBulkCreate_Click(object sender, EventArgs e)
        {
            Container myContainer = DeSerializeTube();
            if (txtSource.Text == txtName.Text)
            {//updating
                myContainer.Id = lblId.Text;
            }
            ContainerBulk cBulk = new ContainerBulk();  
            ContainerArray cArray = new ContainerArray();   
            cArray.Add(myContainer);
            cBulk.Containers = cArray;
            BR.Inv.Model.JobReport jb = _invOps.CreateContainersBulk(cBulk);    
            InvWSOutcome.PostWSJobOutCome(jb.Id, "Bulk Container Creation or Update",  rtbWSOutput, _session, _url);

        }

        private void cmbSType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSType.Text != "")
            {
                SampleType stype = _invOps.GetSampleType(cmbSType.Text);
                //Get list of valid sample names for that sample type
                BioRails.Core.Model.NamedArray sNames = _catOps.GetDictVals(stype.DataElementPath, "", 100, 0);
                CoreWSCombos.PopulateCombo(cmbContents, sNames);
            }
        }

        private void cmbContents_KeyUp(object sender, KeyEventArgs e)
        {
            SampleType stype = _invOps.GetSampleType(cmbSType.Text);
            //Get list of valid sample names for that sample type
            BioRails.Core.Model.NamedArray sNames = _catOps.GetDictVals(stype.DataElementPath, cmbContents.Text, 100, 0);
            CoreWSCombos.PopulateCombo(cmbContents, sNames);
        }

        private void dtQualDate_ValueChanged(object sender, EventArgs e)
        {
            dtQualDate.Checked = true;
        }

        private void dtExpireDate_ValueChanged(object sender, EventArgs e)
        {
            dtExpireDate.Checked = true;
        }
    }
}
