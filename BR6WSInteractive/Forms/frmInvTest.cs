﻿using System;
using System.Collections;
//using System.ComponentModel;
using System.Data;
using System.Drawing;
using BioRails.Core.Api;
using BioRails.Core.Model;
using BR.Inv.Model;
using BR.Inv.Api;
using System.Windows.Forms;

namespace BR6WSInteractive
{
    public partial class frmInvTest : Form
    {
        //private member variables for encapsulation
        Session _session;
        string _url;
        BRInvWrapper _invOps;
        BRCatalogWrapper _catOps;
        Font _bigFont;
        Font _normFont;

        public frmInvTest(Session wsSession, string url)
        {
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
                //Create inventory name array and populate with container types
                ContainerTypeArray ctypes = _invOps.GetAllContainerTypes();
                //populate container type combos
                InvWSCombos.PopulateCombo(cmbTypes, ctypes);
                cmbTypes.Text = "tube";
                InvWSCombos.PopulateCombo(cmbTypeLoad , ctypes);
                //get names of container layouts + populate combo
                ContainerLayoutArray clayouts = _invOps.GetAllContainerLayouts();
                InvWSCombos.PopulateCombo(cmbLayoutLoad, clayouts);
                //get protection type names and populate combo
                BioRails.Core.Model.NamedArray protections = _catOps.GetDictVals("/Root/Inventory/Container/ProtectionType/Protection", "", 100, 0);
                CoreWSCombos.PopulateCombo(cmbProtections, protections);
                cmbProtections.Text = cmbProtections.Items[0].ToString();
                //get user names for protector combo
                BioRails.Core.Model.NamedArray users = _catOps.GetDictVals("/Root/Catalogue/Users/active", "", 100,0);
                CoreWSCombos.PopulateCombo(cmbProtector, users);
                cmbProtector.Text = cmbProtector.Items[0].ToString();
                //_InvWS.WSClient.container_delete()
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
}
        private void DupTube()
        {   //instantiate two container objects for duplication
            Container myContainer = new Container();
            Container myNewContainer = new Container();
            try
            {
                RichTextBoxExtensions.AppendText(rtbWSOutput, "Clone Container", Color.Black, _bigFont);
                //get a container using container_get method
                
                myContainer = _invOps.GetContainer(txtSource.Text);
                //set new container equal to original
                myNewContainer = myContainer;
                //change container name and set id to null which is needed for creation
                myNewContainer.Name = txtCloned.Text;
                myNewContainer.Id = null;
                myContainer = _invOps.CreateContainer(myNewContainer);
                RichTextBoxExtensions.AppendText(rtbWSOutput, "Container Duplicate Succesful", Color.Green, _normFont);

            }
            catch (BR.Inv.Client.ApiException apiEx)
            {
                string msg = BRExceptionCleaner.GetErrorMessageFromBioRailsError(apiEx.Message);
                RichTextBoxExtensions.AppendText(rtbWSOutput, "Container Duplicate Failed - " + msg, Color.Red, _normFont);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred. " + ex.Message, "Error");
            }
        }

        private void ContainerSolvate()
        {
            try
            {
                RichTextBoxExtensions.AppendText(rtbWSOutput, "Container Solvate", Color.Black, _bigFont);
                double vol = Decimal.ToDouble(numVol.Value);
                double conc = Decimal.ToDouble(numConc.Value);
                //solvate the container passing in the container name, new container type (liquid), desired volume and conc with unit and solvent details
                _invOps.SolvateContainer(txtSolvTube.Text, cmbTypes.Text, vol, conc, txtUnit.Text, "DMSO", 100);
                RichTextBoxExtensions.AppendText(rtbWSOutput, "Container Solvate Succesful", Color.Green, _normFont);
            }
            catch (BR.Inv.Client.ApiException apiEx)
            {
                string msg = BRExceptionCleaner.GetErrorMessageFromBioRailsError(apiEx.Message);
                RichTextBoxExtensions.AppendText(rtbWSOutput, "Container Solvate Failed - " + msg, Color.Red, _normFont);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred. " + ex.Message, "Error");
            }
        }

        private void UpdateTube()
        {
            try
            {
                RichTextBoxExtensions.AppendText(rtbWSOutput, "Update Tube Description", Color.Black, _bigFont);
                //Get a container
                Container myContainer = _invOps.GetContainer(txtUpdate.Text);
                //Change the description property or any other properties you like
                myContainer.Description = txtDescrip.Text;
                //Call container update returning a status object
                Container myNewContainer = _invOps.UpdateContainerDescription(txtUpdate.Text, myContainer);
                RichTextBoxExtensions.AppendText(rtbWSOutput, "Container Duplicate Succesful", Color.Green, _normFont);
            }
            catch (BR.Inv.Client.ApiException apiEx)
            {
                string msg = BRExceptionCleaner.GetErrorMessageFromBioRailsError(apiEx.Message);
                RichTextBoxExtensions.AppendText(rtbWSOutput, "Update Tube Description Failed - " + msg, Color.Red, _normFont);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred. " + ex.Message, "Error");
            }
        }
       

        private void BtnUpdateTube_Click(object sender, EventArgs e)
        {
            UpdateTube();
        }
        private void ContainerMove()
        {
            try
            {
                RichTextBoxExtensions.AppendText(rtbWSOutput, "Container Move", Color.Black, _bigFont);
                //using a location path, location slot positions and a container name -try and move a container
                _invOps.MoveContainer(txtTubMove.Text, txtLocation.Text, "A1");
                RichTextBoxExtensions.AppendText(rtbWSOutput, "Container Move Succesful", Color.Green, _normFont);
            }
            catch (BR.Inv.Client.ApiException apiEx)
            {
                string msg = BRExceptionCleaner.GetErrorMessageFromBioRailsError(apiEx.Message);
                RichTextBoxExtensions.AppendText(rtbWSOutput, "Container Move Failed - " + msg, Color.Red, _normFont);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred. " + ex.Message, "Error");
            }
        }
        private void ContainerBin()
        {
            try
            {
                RichTextBoxExtensions.AppendText(rtbWSOutput, "Container Bin", Color.Black, _bigFont);
                //using a container name , move that container to the bin
                _invOps.BinContainer(txtTubMove.Text);
                RichTextBoxExtensions.AppendText(rtbWSOutput, "Container Bin Succesful", Color.Green, _normFont);
                //Update the form with the outcome
            }
            catch (BR.Inv.Client.ApiException apiEx)
            {
                string msg = BRExceptionCleaner.GetErrorMessageFromBioRailsError(apiEx.Message);
                RichTextBoxExtensions.AppendText(rtbWSOutput, "Container Bin Failed - " + msg, Color.Red, _normFont);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred. " + ex.Message, "Error");
            }
        }
        private void BtnProtect_Click(object sender, EventArgs e)
        {
            ContainerProtect(true);
        }

        private void BtnUnProtect_Click(object sender, EventArgs e)
        {
            ContainerProtect(false);
        }

        private void ContainerProtect(bool badd)
        {
            try
            {
                if (badd == true)
                {
                    //if adding then call container protect with protector and protection type
                    RichTextBoxExtensions.AppendText(rtbWSOutput, "Container Protect", Color.Black, _bigFont);
                    _invOps.ProtectContainer(txtTubProtect.Text, cmbProtector.Text, cmbProtections.Text);
                    RichTextBoxExtensions.AppendText(rtbWSOutput, "Container Protect Succesful", Color.Green, _normFont);
                }
                else
                {
                    //if removing then call container protect without protector or protection type
                    RichTextBoxExtensions.AppendText(rtbWSOutput, "Container UnProtect", Color.Black, _bigFont);
                    _invOps.ProtectContainer(txtTubProtect.Text, null, null);
                    RichTextBoxExtensions.AppendText(rtbWSOutput, "Container UnProtect Succesful", Color.Green, _normFont);
                }
            }
            catch (BR.Inv.Client.ApiException apiEx)
            {
                string msg = BRExceptionCleaner.GetErrorMessageFromBioRailsError(apiEx.Message);
                RichTextBoxExtensions.AppendText(rtbWSOutput, "Container Protection Failed - " + msg, Color.Red, _normFont);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred. " + ex.Message, "Error");
            }
        }


        private void BtnMove_Click(object sender, EventArgs e)
        {
            ContainerMove();
        }
        private void BtnBin_Click(object sender, EventArgs e)
        {
            ContainerBin();
        }
        private void BtnCloneTest_Click(object sender, EventArgs e)
        {
            DupTube();
        }

        private void BtnSolvate_Click(object sender, EventArgs e)
        {
            ContainerSolvate();
        }

        private void BtnAll_Click(object sender, EventArgs e)
        {
            DupTube();
            ContainerSolvate();
            ContainerProtect(true);
            ContainerProtect(false);
            ContainerMove();
            ContainerBin();
            UpdateTube();
        }

        private string SelectTextFile(string initialDirectory)
        {
            //simple method to open a file browse dialog restricted to Excel files for use with the import plate method 
            //See supporting files folder in this project for the only supported file format. 
            OpenFileDialog dialog = new OpenFileDialog();

            try
            {
                //dialog.Filter = "Comma Seperated Files (*.csv)|*.csv|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                dialog.Filter = "New Excel(*.xlsx)|*.xlsx";
                dialog.InitialDirectory = initialDirectory;
                dialog.Title = "Select an Excel File ..";
                dialog.FileName = "";

                if (dialog.ShowDialog() == DialogResult.OK)
                {

                    //sStartPath = System.IO.Path.GetDirectoryName(dialog.FileName);
                    return (dialog.FileName);
                }
                else
                {
                    return (string.Empty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return (string.Empty);
            }
            return String.Empty;

        }

        private void BtnImportPlate_Click(object sender, EventArgs e)
        {
            try
            {
                //get a file starting in C:\
                string myfile = SelectTextFile("C:\\");
                //use static method to convert the Excel sheet to a dataset
                DataSet ds = ExcelToDataSet.Parse(myfile);
                DataSet pds = new DataSet();
                //check the dataset is actually compatible with the code by parsing it
                pds = PlateData.GetPlateDataSet(pds);
                if (PlateData.ValidPlateDataSet(pds, ds) == false)
                {
                    MessageBox.Show("Cannot import file. It is of the wrong format.");
                }
                else
                {
                    //instantiate a container
                    Container plateout = new Container();
                    //convert the dataset into a plate container
                    plateout = PlateFromDataSet.GetPlateFromDataSet(ds);
                    plateout.Id = null;
                    //call create container with the plate container
                    _invOps.CreateContainer(plateout);
                    //Update the form with the outcome
                    RichTextBoxExtensions.AppendText(rtbWSOutput, "Import Plate Success", Color.Green, _normFont);
                }
                //Console.WriteLine(pds.Tables[1].TableName.ToString());
            }
            catch (BR.Inv.Client.ApiException apiEx)
            {
                string msg = BRExceptionCleaner.GetErrorMessageFromBioRailsError(apiEx.Message);
                RichTextBoxExtensions.AppendText(rtbWSOutput, "Import Plate Failed - " + msg, Color.Red, _normFont);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error"); 
            }

        }

        private void BtnIndContainer_Click(object sender, EventArgs e)
        {
            try
            {   //launch form for testing individual field business rules
                using (frmIndTube frmInd = new frmIndTube( _session, _url))
                {
                    frmInd.Location = this.Location;
                    this.Hide();
                    frmInd.ShowDialog();
                }
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void BtnWatson_Click(object sender, EventArgs e)
        {
            try
            {
                //launch form for testing watson integration (customer specific)
                using (frmWatson frmWat = new frmWatson(_session, _url))
                {
                    frmWat.Location = this.Location;
                    this.Hide();
                    frmWat.ShowDialog();
                }
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }



        private void btmImpTubes_Click(object sender, EventArgs e)
        {
            //get a file starting in C:\
            string myfile = SelectTextFile("C:\\");
            //use static method to convert the Excel sheet to a dataset
            DataSet ds = ExcelToDataSet.Parse(myfile);
            DataSet pds = new DataSet();
            //check the dataset is actually compatible with the code by parsing it
            pds = PlateData.GetPlateDataSet(pds);
            if (PlateData.ValidPlateDataSet(pds, ds) == false)
            {
                MessageBox.Show("Cannot import file. It is of the wrong format.");
            }
            else
            {
                try
                {
                    //convert the dataset into tubes
                    ContainerBulk cBulk = new ContainerBulk();
                    ContainerArray cArray = TubesFromDataSet.GetTubesFromDataSet(ds);
                    cBulk.Containers = cArray;  
                    //instantiate a job id and set it equal to the job created when trying to create multiple materials with a list of names
                    BR.Inv.Model.JobReport jb = _invOps.CreateContainersBulk(cBulk);
                    InvWSOutcome.PostWSJobOutCome(jb.Id, "Bulk Container Creation or Update", rtbWSOutput, _session, _url);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

    }   
}
