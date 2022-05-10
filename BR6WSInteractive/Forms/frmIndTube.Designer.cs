namespace BR6WSInteractive
{
    partial class frmIndTube
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIndTube));
            this.grpClone = new System.Windows.Forms.GroupBox();
            this.txtCloneDescrip = new System.Windows.Forms.TextBox();
            this.lblSource = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.btnGetTest = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblTubeName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblLayout = new System.Windows.Forms.Label();
            this.lblSType = new System.Windows.Forms.Label();
            this.lblProtection = new System.Windows.Forms.Label();
            this.lblProtector = new System.Windows.Forms.Label();
            this.lblCollection = new System.Windows.Forms.Label();
            this.txtCollection = new System.Windows.Forms.TextBox();
            this.lblSystem = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtDescrip = new System.Windows.Forms.TextBox();
            this.cmbLayoutLoad = new System.Windows.Forms.ComboBox();
            this.cmbTypeLoad = new System.Windows.Forms.ComboBox();
            this.cmbProtections = new System.Windows.Forms.ComboBox();
            this.cmbProtector = new System.Windows.Forms.ComboBox();
            this.cmbSType = new System.Windows.Forms.ComboBox();
            this.cmbSystem = new System.Windows.Forms.ComboBox();
            this.lblTransport = new System.Windows.Forms.Label();
            this.txtTransport = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblTare = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.rtbWSOutput = new System.Windows.Forms.RichTextBox();
            this.cmbTareUnit = new System.Windows.Forms.ComboBox();
            this.numTare = new System.Windows.Forms.NumericUpDown();
            this.lblCThaw = new System.Windows.Forms.Label();
            this.lblMThaw = new System.Windows.Forms.Label();
            this.lblQDate = new System.Windows.Forms.Label();
            this.dtQualDate = new System.Windows.Forms.DateTimePicker();
            this.dtExpireDate = new System.Windows.Forms.DateTimePicker();
            this.lblEDate = new System.Windows.Forms.Label();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.cmbQtyUnit = new System.Windows.Forms.ComboBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.numConc = new System.Windows.Forms.NumericUpDown();
            this.cmbConcUnit = new System.Windows.Forms.ComboBox();
            this.lblConc = new System.Windows.Forms.Label();
            this.lblRow = new System.Windows.Forms.Label();
            this.cmbSolvent = new System.Windows.Forms.ComboBox();
            this.lblSolvent = new System.Windows.Forms.Label();
            this.lblPercent = new System.Windows.Forms.Label();
            this.cmbContents = new System.Windows.Forms.ComboBox();
            this.lblContents = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSPercent = new System.Windows.Forms.TextBox();
            this.lblCol = new System.Windows.Forms.Label();
            this.numRow = new System.Windows.Forms.NumericUpDown();
            this.numCol = new System.Windows.Forms.NumericUpDown();
            this.cmdBulkCreate = new System.Windows.Forms.Button();
            this.txtCThaw = new System.Windows.Forms.TextBox();
            this.txtMThaw = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.grpClone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numConc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCol)).BeginInit();
            this.SuspendLayout();
            // 
            // grpClone
            // 
            this.grpClone.Controls.Add(this.txtCloneDescrip);
            this.grpClone.Controls.Add(this.lblSource);
            this.grpClone.Controls.Add(this.txtSource);
            this.grpClone.Controls.Add(this.btnGetTest);
            this.grpClone.Location = new System.Drawing.Point(12, 12);
            this.grpClone.Name = "grpClone";
            this.grpClone.Size = new System.Drawing.Size(572, 75);
            this.grpClone.TabIndex = 7;
            this.grpClone.TabStop = false;
            this.grpClone.Text = "Clone Tube";
            // 
            // txtCloneDescrip
            // 
            this.txtCloneDescrip.Enabled = false;
            this.txtCloneDescrip.Location = new System.Drawing.Point(263, 29);
            this.txtCloneDescrip.Multiline = true;
            this.txtCloneDescrip.Name = "txtCloneDescrip";
            this.txtCloneDescrip.Size = new System.Drawing.Size(298, 40);
            this.txtCloneDescrip.TabIndex = 11;
            this.txtCloneDescrip.Text = "This will test the container_get method and populate all the fields below";
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(26, 26);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(68, 13);
            this.lblSource.TabIndex = 7;
            this.lblSource.Text = "Tube To Get";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(16, 42);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(100, 20);
            this.txtSource.TabIndex = 5;
            this.txtSource.Text = "tube4";
            // 
            // btnGetTest
            // 
            this.btnGetTest.Location = new System.Drawing.Point(122, 40);
            this.btnGetTest.Name = "btnGetTest";
            this.btnGetTest.Size = new System.Drawing.Size(126, 23);
            this.btnGetTest.TabIndex = 0;
            this.btnGetTest.Text = "Get Tube";
            this.btnGetTest.UseVisualStyleBackColor = true;
            this.btnGetTest.Click += new System.EventHandler(this.BtnGetTest_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(134, 102);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(226, 20);
            this.txtName.TabIndex = 12;
            // 
            // lblTubeName
            // 
            this.lblTubeName.AutoSize = true;
            this.lblTubeName.Location = new System.Drawing.Point(25, 105);
            this.lblTubeName.Name = "lblTubeName";
            this.lblTubeName.Size = new System.Drawing.Size(35, 13);
            this.lblTubeName.TabIndex = 12;
            this.lblTubeName.Text = "Name";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(25, 170);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 13;
            this.lblType.Text = "Type";
            // 
            // lblLayout
            // 
            this.lblLayout.AutoSize = true;
            this.lblLayout.Location = new System.Drawing.Point(25, 202);
            this.lblLayout.Name = "lblLayout";
            this.lblLayout.Size = new System.Drawing.Size(39, 13);
            this.lblLayout.TabIndex = 15;
            this.lblLayout.Text = "Layout";
            // 
            // lblSType
            // 
            this.lblSType.AutoSize = true;
            this.lblSType.Location = new System.Drawing.Point(25, 234);
            this.lblSType.Name = "lblSType";
            this.lblSType.Size = new System.Drawing.Size(69, 13);
            this.lblSType.TabIndex = 17;
            this.lblSType.Text = "Sample Type";
            // 
            // lblProtection
            // 
            this.lblProtection.AutoSize = true;
            this.lblProtection.Location = new System.Drawing.Point(25, 266);
            this.lblProtection.Name = "lblProtection";
            this.lblProtection.Size = new System.Drawing.Size(55, 13);
            this.lblProtection.TabIndex = 19;
            this.lblProtection.Text = "Protection";
            // 
            // lblProtector
            // 
            this.lblProtector.AutoSize = true;
            this.lblProtector.Location = new System.Drawing.Point(25, 298);
            this.lblProtector.Name = "lblProtector";
            this.lblProtector.Size = new System.Drawing.Size(50, 13);
            this.lblProtector.TabIndex = 21;
            this.lblProtector.Text = "Protector";
            // 
            // lblCollection
            // 
            this.lblCollection.AutoSize = true;
            this.lblCollection.Location = new System.Drawing.Point(25, 332);
            this.lblCollection.Name = "lblCollection";
            this.lblCollection.Size = new System.Drawing.Size(53, 13);
            this.lblCollection.TabIndex = 23;
            this.lblCollection.Text = "Collection";
            // 
            // txtCollection
            // 
            this.txtCollection.Location = new System.Drawing.Point(134, 329);
            this.txtCollection.Name = "txtCollection";
            this.txtCollection.Size = new System.Drawing.Size(226, 20);
            this.txtCollection.TabIndex = 24;
            // 
            // lblSystem
            // 
            this.lblSystem.AutoSize = true;
            this.lblSystem.Location = new System.Drawing.Point(25, 369);
            this.lblSystem.Name = "lblSystem";
            this.lblSystem.Size = new System.Drawing.Size(70, 13);
            this.lblSystem.TabIndex = 25;
            this.lblSystem.Text = "Order System";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(25, 136);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(60, 13);
            this.lblDesc.TabIndex = 27;
            this.lblDesc.Text = "Description";
            // 
            // txtDescrip
            // 
            this.txtDescrip.Location = new System.Drawing.Point(134, 133);
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Size = new System.Drawing.Size(226, 20);
            this.txtDescrip.TabIndex = 28;
            // 
            // cmbLayoutLoad
            // 
            this.cmbLayoutLoad.FormattingEnabled = true;
            this.cmbLayoutLoad.Location = new System.Drawing.Point(134, 199);
            this.cmbLayoutLoad.Name = "cmbLayoutLoad";
            this.cmbLayoutLoad.Size = new System.Drawing.Size(226, 21);
            this.cmbLayoutLoad.TabIndex = 30;
            // 
            // cmbTypeLoad
            // 
            this.cmbTypeLoad.FormattingEnabled = true;
            this.cmbTypeLoad.Location = new System.Drawing.Point(134, 167);
            this.cmbTypeLoad.Name = "cmbTypeLoad";
            this.cmbTypeLoad.Size = new System.Drawing.Size(226, 21);
            this.cmbTypeLoad.TabIndex = 29;
            // 
            // cmbProtections
            // 
            this.cmbProtections.FormattingEnabled = true;
            this.cmbProtections.Location = new System.Drawing.Point(134, 263);
            this.cmbProtections.Name = "cmbProtections";
            this.cmbProtections.Size = new System.Drawing.Size(226, 21);
            this.cmbProtections.TabIndex = 32;
            this.cmbProtections.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CmbProtections_KeyUp);
            // 
            // cmbProtector
            // 
            this.cmbProtector.FormattingEnabled = true;
            this.cmbProtector.Location = new System.Drawing.Point(134, 295);
            this.cmbProtector.Name = "cmbProtector";
            this.cmbProtector.Size = new System.Drawing.Size(226, 21);
            this.cmbProtector.TabIndex = 31;
            this.cmbProtector.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CmbProtector_KeyUp);
            // 
            // cmbSType
            // 
            this.cmbSType.FormattingEnabled = true;
            this.cmbSType.Location = new System.Drawing.Point(134, 231);
            this.cmbSType.Name = "cmbSType";
            this.cmbSType.Size = new System.Drawing.Size(226, 21);
            this.cmbSType.TabIndex = 33;
            this.cmbSType.Text = "batch";
            this.cmbSType.SelectedIndexChanged += new System.EventHandler(this.cmbSType_SelectedIndexChanged);
            // 
            // cmbSystem
            // 
            this.cmbSystem.FormattingEnabled = true;
            this.cmbSystem.Location = new System.Drawing.Point(134, 361);
            this.cmbSystem.Name = "cmbSystem";
            this.cmbSystem.Size = new System.Drawing.Size(226, 21);
            this.cmbSystem.TabIndex = 34;
            this.cmbSystem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CmbSystem_KeyUp);
            // 
            // lblTransport
            // 
            this.lblTransport.AutoSize = true;
            this.lblTransport.Location = new System.Drawing.Point(25, 398);
            this.lblTransport.Name = "lblTransport";
            this.lblTransport.Size = new System.Drawing.Size(81, 13);
            this.lblTransport.TabIndex = 35;
            this.lblTransport.Text = "Transport Label";
            // 
            // txtTransport
            // 
            this.txtTransport.Location = new System.Drawing.Point(134, 395);
            this.txtTransport.Name = "txtTransport";
            this.txtTransport.Size = new System.Drawing.Size(226, 20);
            this.txtTransport.TabIndex = 36;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(25, 431);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(48, 13);
            this.lblLocation.TabIndex = 37;
            this.lblLocation.Text = "Location";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(134, 428);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(226, 20);
            this.txtLocation.TabIndex = 38;
            // 
            // lblTare
            // 
            this.lblTare.AutoSize = true;
            this.lblTare.Location = new System.Drawing.Point(25, 459);
            this.lblTare.Name = "lblTare";
            this.lblTare.Size = new System.Drawing.Size(66, 13);
            this.lblTare.TabIndex = 39;
            this.lblTare.Text = "Tare Weight";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(631, 12);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(60, 13);
            this.lblOutput.TabIndex = 44;
            this.lblOutput.Text = "WS Output";
            // 
            // rtbWSOutput
            // 
            this.rtbWSOutput.Location = new System.Drawing.Point(634, 28);
            this.rtbWSOutput.Name = "rtbWSOutput";
            this.rtbWSOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbWSOutput.Size = new System.Drawing.Size(558, 664);
            this.rtbWSOutput.TabIndex = 43;
            this.rtbWSOutput.Text = "";
            // 
            // cmbTareUnit
            // 
            this.cmbTareUnit.FormattingEnabled = true;
            this.cmbTareUnit.Items.AddRange(new object[] {
            "mg",
            "g",
            "kg"});
            this.cmbTareUnit.Location = new System.Drawing.Point(366, 455);
            this.cmbTareUnit.Name = "cmbTareUnit";
            this.cmbTareUnit.Size = new System.Drawing.Size(94, 21);
            this.cmbTareUnit.TabIndex = 45;
            this.cmbTareUnit.Text = "mg";
            // 
            // numTare
            // 
            this.numTare.DecimalPlaces = 3;
            this.numTare.Location = new System.Drawing.Point(134, 456);
            this.numTare.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numTare.Name = "numTare";
            this.numTare.Size = new System.Drawing.Size(226, 20);
            this.numTare.TabIndex = 46;
            // 
            // lblCThaw
            // 
            this.lblCThaw.AutoSize = true;
            this.lblCThaw.Location = new System.Drawing.Point(25, 484);
            this.lblCThaw.Name = "lblCThaw";
            this.lblCThaw.Size = new System.Drawing.Size(44, 13);
            this.lblCThaw.TabIndex = 48;
            this.lblCThaw.Text = "C.Thaw";
            // 
            // lblMThaw
            // 
            this.lblMThaw.AutoSize = true;
            this.lblMThaw.Location = new System.Drawing.Point(25, 512);
            this.lblMThaw.Name = "lblMThaw";
            this.lblMThaw.Size = new System.Drawing.Size(46, 13);
            this.lblMThaw.TabIndex = 50;
            this.lblMThaw.Text = "M.Thaw";
            // 
            // lblQDate
            // 
            this.lblQDate.AutoSize = true;
            this.lblQDate.Location = new System.Drawing.Point(25, 540);
            this.lblQDate.Name = "lblQDate";
            this.lblQDate.Size = new System.Drawing.Size(55, 13);
            this.lblQDate.TabIndex = 51;
            this.lblQDate.Text = "Qual Date";
            // 
            // dtQualDate
            // 
            this.dtQualDate.Checked = false;
            this.dtQualDate.Location = new System.Drawing.Point(134, 537);
            this.dtQualDate.Name = "dtQualDate";
            this.dtQualDate.ShowCheckBox = true;
            this.dtQualDate.Size = new System.Drawing.Size(226, 20);
            this.dtQualDate.TabIndex = 52;
            this.dtQualDate.Value = new System.DateTime(2023, 12, 29, 0, 0, 0, 0);
            this.dtQualDate.ValueChanged += new System.EventHandler(this.dtQualDate_ValueChanged);
            // 
            // dtExpireDate
            // 
            this.dtExpireDate.Checked = false;
            this.dtExpireDate.Location = new System.Drawing.Point(134, 566);
            this.dtExpireDate.Name = "dtExpireDate";
            this.dtExpireDate.ShowCheckBox = true;
            this.dtExpireDate.Size = new System.Drawing.Size(226, 20);
            this.dtExpireDate.TabIndex = 54;
            this.dtExpireDate.Value = new System.DateTime(2023, 12, 29, 0, 0, 0, 0);
            this.dtExpireDate.ValueChanged += new System.EventHandler(this.dtExpireDate_ValueChanged);
            // 
            // lblEDate
            // 
            this.lblEDate.AutoSize = true;
            this.lblEDate.Location = new System.Drawing.Point(25, 569);
            this.lblEDate.Name = "lblEDate";
            this.lblEDate.Size = new System.Drawing.Size(61, 13);
            this.lblEDate.TabIndex = 53;
            this.lblEDate.Text = "Expiry Date";
            // 
            // numQty
            // 
            this.numQty.DecimalPlaces = 3;
            this.numQty.Location = new System.Drawing.Point(134, 595);
            this.numQty.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(226, 20);
            this.numQty.TabIndex = 57;
            // 
            // cmbQtyUnit
            // 
            this.cmbQtyUnit.FormattingEnabled = true;
            this.cmbQtyUnit.Items.AddRange(new object[] {
            "mg",
            "g",
            "kg",
            "ul",
            "ml",
            "count"});
            this.cmbQtyUnit.Location = new System.Drawing.Point(366, 594);
            this.cmbQtyUnit.Name = "cmbQtyUnit";
            this.cmbQtyUnit.Size = new System.Drawing.Size(94, 21);
            this.cmbQtyUnit.TabIndex = 56;
            this.cmbQtyUnit.Text = "mg";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(25, 598);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(60, 13);
            this.lblQty.TabIndex = 55;
            this.lblQty.Text = "Current Qty";
            // 
            // numConc
            // 
            this.numConc.DecimalPlaces = 3;
            this.numConc.Location = new System.Drawing.Point(134, 623);
            this.numConc.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numConc.Name = "numConc";
            this.numConc.Size = new System.Drawing.Size(226, 20);
            this.numConc.TabIndex = 60;
            // 
            // cmbConcUnit
            // 
            this.cmbConcUnit.FormattingEnabled = true;
            this.cmbConcUnit.Items.AddRange(new object[] {
            "",
            "mM",
            "uM",
            "M",
            "mg/ml",
            "mg/l",
            "g/l",
            "%",
            "ppm",
            "ul/l",
            "ul/ml",
            "ml/l",
            "count/ml",
            "count/l",
            "count/ul",
            "cell/ml",
            "cell/ul",
            "cell/l"});
            this.cmbConcUnit.Location = new System.Drawing.Point(366, 622);
            this.cmbConcUnit.Name = "cmbConcUnit";
            this.cmbConcUnit.Size = new System.Drawing.Size(94, 21);
            this.cmbConcUnit.TabIndex = 59;
            this.cmbConcUnit.Text = "mM";
            // 
            // lblConc
            // 
            this.lblConc.AutoSize = true;
            this.lblConc.Location = new System.Drawing.Point(25, 626);
            this.lblConc.Name = "lblConc";
            this.lblConc.Size = new System.Drawing.Size(73, 13);
            this.lblConc.TabIndex = 58;
            this.lblConc.Text = "Concentration";
            // 
            // lblRow
            // 
            this.lblRow.AutoSize = true;
            this.lblRow.Location = new System.Drawing.Point(373, 412);
            this.lblRow.Name = "lblRow";
            this.lblRow.Size = new System.Drawing.Size(29, 13);
            this.lblRow.TabIndex = 61;
            this.lblRow.Text = "Row";
            // 
            // cmbSolvent
            // 
            this.cmbSolvent.FormattingEnabled = true;
            this.cmbSolvent.Items.AddRange(new object[] {
            "DMSO",
            "Ethanol",
            "Water",
            "None"});
            this.cmbSolvent.Location = new System.Drawing.Point(134, 651);
            this.cmbSolvent.Name = "cmbSolvent";
            this.cmbSolvent.Size = new System.Drawing.Size(226, 21);
            this.cmbSolvent.TabIndex = 64;
            // 
            // lblSolvent
            // 
            this.lblSolvent.AutoSize = true;
            this.lblSolvent.Location = new System.Drawing.Point(25, 654);
            this.lblSolvent.Name = "lblSolvent";
            this.lblSolvent.Size = new System.Drawing.Size(43, 13);
            this.lblSolvent.TabIndex = 63;
            this.lblSolvent.Text = "Solvent";
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Location = new System.Drawing.Point(25, 685);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(54, 13);
            this.lblPercent.TabIndex = 65;
            this.lblPercent.Text = "Solvent %";
            // 
            // cmbContents
            // 
            this.cmbContents.FormattingEnabled = true;
            this.cmbContents.Items.AddRange(new object[] {
            "DMSO",
            "Ethanol",
            "Water",
            "None"});
            this.cmbContents.Location = new System.Drawing.Point(134, 714);
            this.cmbContents.Name = "cmbContents";
            this.cmbContents.Size = new System.Drawing.Size(226, 21);
            this.cmbContents.TabIndex = 68;
            this.cmbContents.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbContents_KeyUp);
            // 
            // lblContents
            // 
            this.lblContents.AutoSize = true;
            this.lblContents.Location = new System.Drawing.Point(25, 717);
            this.lblContents.Name = "lblContents";
            this.lblContents.Size = new System.Drawing.Size(73, 13);
            this.lblContents.TabIndex = 67;
            this.lblContents.Text = "Well Contents";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(818, 735);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 23);
            this.btnSave.TabIndex = 69;
            this.btnSave.Text = "Create or Update";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtSPercent
            // 
            this.txtSPercent.Location = new System.Drawing.Point(134, 682);
            this.txtSPercent.Name = "txtSPercent";
            this.txtSPercent.Size = new System.Drawing.Size(226, 20);
            this.txtSPercent.TabIndex = 70;
            // 
            // lblCol
            // 
            this.lblCol.AutoSize = true;
            this.lblCol.Location = new System.Drawing.Point(453, 412);
            this.lblCol.Name = "lblCol";
            this.lblCol.Size = new System.Drawing.Size(22, 13);
            this.lblCol.TabIndex = 71;
            this.lblCol.Text = "Col";
            // 
            // numRow
            // 
            this.numRow.Location = new System.Drawing.Point(366, 428);
            this.numRow.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numRow.Name = "numRow";
            this.numRow.Size = new System.Drawing.Size(76, 20);
            this.numRow.TabIndex = 73;
            // 
            // numCol
            // 
            this.numCol.Location = new System.Drawing.Point(448, 428);
            this.numCol.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numCol.Name = "numCol";
            this.numCol.Size = new System.Drawing.Size(76, 20);
            this.numCol.TabIndex = 74;
            // 
            // cmdBulkCreate
            // 
            this.cmdBulkCreate.Location = new System.Drawing.Point(950, 735);
            this.cmdBulkCreate.Name = "cmdBulkCreate";
            this.cmdBulkCreate.Size = new System.Drawing.Size(113, 23);
            this.cmdBulkCreate.TabIndex = 75;
            this.cmdBulkCreate.Text = "Bulk Create";
            this.cmdBulkCreate.UseVisualStyleBackColor = true;
            this.cmdBulkCreate.Click += new System.EventHandler(this.cmdBulkCreate_Click);
            // 
            // txtCThaw
            // 
            this.txtCThaw.Location = new System.Drawing.Point(134, 482);
            this.txtCThaw.Name = "txtCThaw";
            this.txtCThaw.Size = new System.Drawing.Size(226, 20);
            this.txtCThaw.TabIndex = 76;
            // 
            // txtMThaw
            // 
            this.txtMThaw.Location = new System.Drawing.Point(134, 511);
            this.txtMThaw.Name = "txtMThaw";
            this.txtMThaw.Size = new System.Drawing.Size(226, 20);
            this.txtMThaw.TabIndex = 77;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(376, 108);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(61, 13);
            this.lblId.TabIndex = 78;
            this.lblId.Text = "ContainerId";
            // 
            // frmIndTube
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 779);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtMThaw);
            this.Controls.Add(this.txtCThaw);
            this.Controls.Add(this.cmdBulkCreate);
            this.Controls.Add(this.numCol);
            this.Controls.Add(this.numRow);
            this.Controls.Add(this.lblCol);
            this.Controls.Add(this.txtSPercent);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbContents);
            this.Controls.Add(this.lblContents);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.cmbSolvent);
            this.Controls.Add(this.lblSolvent);
            this.Controls.Add(this.lblRow);
            this.Controls.Add(this.numConc);
            this.Controls.Add(this.cmbConcUnit);
            this.Controls.Add(this.lblConc);
            this.Controls.Add(this.numQty);
            this.Controls.Add(this.cmbQtyUnit);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.dtExpireDate);
            this.Controls.Add(this.lblEDate);
            this.Controls.Add(this.dtQualDate);
            this.Controls.Add(this.lblQDate);
            this.Controls.Add(this.lblMThaw);
            this.Controls.Add(this.lblCThaw);
            this.Controls.Add(this.numTare);
            this.Controls.Add(this.cmbTareUnit);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.rtbWSOutput);
            this.Controls.Add(this.lblTare);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblTransport);
            this.Controls.Add(this.txtTransport);
            this.Controls.Add(this.cmbSystem);
            this.Controls.Add(this.cmbSType);
            this.Controls.Add(this.cmbProtections);
            this.Controls.Add(this.cmbProtector);
            this.Controls.Add(this.cmbLayoutLoad);
            this.Controls.Add(this.cmbTypeLoad);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.txtDescrip);
            this.Controls.Add(this.lblSystem);
            this.Controls.Add(this.lblCollection);
            this.Controls.Add(this.txtCollection);
            this.Controls.Add(this.lblProtector);
            this.Controls.Add(this.lblProtection);
            this.Controls.Add(this.lblSType);
            this.Controls.Add(this.lblLayout);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblTubeName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.grpClone);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmIndTube";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Individual Field Tester";
            this.grpClone.ResumeLayout(false);
            this.grpClone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numConc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpClone;
        private System.Windows.Forms.TextBox txtCloneDescrip;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Button btnGetTest;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblTubeName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblLayout;
        private System.Windows.Forms.Label lblSType;
        private System.Windows.Forms.Label lblProtection;
        private System.Windows.Forms.Label lblProtector;
        private System.Windows.Forms.Label lblCollection;
        private System.Windows.Forms.TextBox txtCollection;
        private System.Windows.Forms.Label lblSystem;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtDescrip;
        private System.Windows.Forms.ComboBox cmbLayoutLoad;
        private System.Windows.Forms.ComboBox cmbTypeLoad;
        private System.Windows.Forms.ComboBox cmbProtections;
        private System.Windows.Forms.ComboBox cmbProtector;
        private System.Windows.Forms.ComboBox cmbSType;
        private System.Windows.Forms.ComboBox cmbSystem;
        private System.Windows.Forms.Label lblTransport;
        private System.Windows.Forms.TextBox txtTransport;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblTare;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.RichTextBox rtbWSOutput;
        private System.Windows.Forms.ComboBox cmbTareUnit;
        private System.Windows.Forms.NumericUpDown numTare;
        private System.Windows.Forms.Label lblCThaw;
        private System.Windows.Forms.Label lblMThaw;
        private System.Windows.Forms.Label lblQDate;
        private System.Windows.Forms.DateTimePicker dtQualDate;
        private System.Windows.Forms.DateTimePicker dtExpireDate;
        private System.Windows.Forms.Label lblEDate;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.ComboBox cmbQtyUnit;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.NumericUpDown numConc;
        private System.Windows.Forms.ComboBox cmbConcUnit;
        private System.Windows.Forms.Label lblConc;
        private System.Windows.Forms.Label lblRow;
        private System.Windows.Forms.ComboBox cmbSolvent;
        private System.Windows.Forms.Label lblSolvent;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.ComboBox cmbContents;
        private System.Windows.Forms.Label lblContents;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtSPercent;
        private System.Windows.Forms.Label lblCol;
        private System.Windows.Forms.NumericUpDown numRow;
        private System.Windows.Forms.NumericUpDown numCol;
        private System.Windows.Forms.Button cmdBulkCreate;
        private System.Windows.Forms.TextBox txtCThaw;
        private System.Windows.Forms.TextBox txtMThaw;
        private System.Windows.Forms.Label lblId;
    }
}