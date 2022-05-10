namespace BR6WSInteractive
{
    partial class frmInvTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvTest));
            this.btnCloneTest = new System.Windows.Forms.Button();
            this.rtbWSOutput = new System.Windows.Forms.RichTextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.grpClone = new System.Windows.Forms.GroupBox();
            this.txtCloneDescrip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCloned = new System.Windows.Forms.TextBox();
            this.lblSource = new System.Windows.Forms.Label();
            this.grpContainerSolvate = new System.Windows.Forms.GroupBox();
            this.cmbTypes = new System.Windows.Forms.ComboBox();
            this.numVol = new System.Windows.Forms.NumericUpDown();
            this.numConc = new System.Windows.Forms.NumericUpDown();
            this.lblVol = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.btnSolvate = new System.Windows.Forms.Button();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.lblConc = new System.Windows.Forms.Label();
            this.txtSolvDescription = new System.Windows.Forms.TextBox();
            this.lblCType = new System.Windows.Forms.Label();
            this.lblSolvTube = new System.Windows.Forms.Label();
            this.txtSolvTube = new System.Windows.Forms.TextBox();
            this.grpFormLoad = new System.Windows.Forms.GroupBox();
            this.cmbLayoutLoad = new System.Windows.Forms.ComboBox();
            this.cmbTypeLoad = new System.Windows.Forms.ComboBox();
            this.txtListDesciption = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpProtect = new System.Windows.Forms.GroupBox();
            this.cmbProtections = new System.Windows.Forms.ComboBox();
            this.cmbProtector = new System.Windows.Forms.ComboBox();
            this.btnUnProtect = new System.Windows.Forms.Button();
            this.lblProtection = new System.Windows.Forms.Label();
            this.txtProtectDescription = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblTubProtect = new System.Windows.Forms.Label();
            this.txtTubProtect = new System.Windows.Forms.TextBox();
            this.btnProtect = new System.Windows.Forms.Button();
            this.grpMove = new System.Windows.Forms.GroupBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.btnBin = new System.Windows.Forms.Button();
            this.lblLocations = new System.Windows.Forms.Label();
            this.txtMoveDescription = new System.Windows.Forms.TextBox();
            this.lblTubMove = new System.Windows.Forms.Label();
            this.txtTubMove = new System.Windows.Forms.TextBox();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblDescrip = new System.Windows.Forms.Label();
            this.txtDescrip = new System.Windows.Forms.TextBox();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.txtUpdate = new System.Windows.Forms.TextBox();
            this.btnUpdateTube = new System.Windows.Forms.Button();
            this.btnImportPlate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btmImpTubes = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnIndContainer = new System.Windows.Forms.Button();
            this.btnWatson = new System.Windows.Forms.Button();
            this.grpClone.SuspendLayout();
            this.grpContainerSolvate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numConc)).BeginInit();
            this.grpFormLoad.SuspendLayout();
            this.grpProtect.SuspendLayout();
            this.grpMove.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCloneTest
            // 
            this.btnCloneTest.Location = new System.Drawing.Point(228, 40);
            this.btnCloneTest.Name = "btnCloneTest";
            this.btnCloneTest.Size = new System.Drawing.Size(126, 23);
            this.btnCloneTest.TabIndex = 0;
            this.btnCloneTest.Text = "Clone Tube";
            this.btnCloneTest.UseVisualStyleBackColor = true;
            this.btnCloneTest.Click += new System.EventHandler(this.BtnCloneTest_Click);
            // 
            // rtbWSOutput
            // 
            this.rtbWSOutput.Location = new System.Drawing.Point(696, 115);
            this.rtbWSOutput.Name = "rtbWSOutput";
            this.rtbWSOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbWSOutput.Size = new System.Drawing.Size(558, 546);
            this.rtbWSOutput.TabIndex = 1;
            this.rtbWSOutput.Text = "";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(699, 99);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(60, 13);
            this.lblOutput.TabIndex = 2;
            this.lblOutput.Text = "WS Output";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(16, 42);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(100, 20);
            this.txtSource.TabIndex = 5;
            this.txtSource.Text = "tube4";
            // 
            // grpClone
            // 
            this.grpClone.Controls.Add(this.txtCloneDescrip);
            this.grpClone.Controls.Add(this.label1);
            this.grpClone.Controls.Add(this.txtCloned);
            this.grpClone.Controls.Add(this.lblSource);
            this.grpClone.Controls.Add(this.txtSource);
            this.grpClone.Controls.Add(this.btnCloneTest);
            this.grpClone.Location = new System.Drawing.Point(12, 12);
            this.grpClone.Name = "grpClone";
            this.grpClone.Size = new System.Drawing.Size(664, 75);
            this.grpClone.TabIndex = 6;
            this.grpClone.TabStop = false;
            this.grpClone.Text = "Clone Tube";
            // 
            // txtCloneDescrip
            // 
            this.txtCloneDescrip.Enabled = false;
            this.txtCloneDescrip.Location = new System.Drawing.Point(360, 29);
            this.txtCloneDescrip.Multiline = true;
            this.txtCloneDescrip.Name = "txtCloneDescrip";
            this.txtCloneDescrip.Size = new System.Drawing.Size(298, 40);
            this.txtCloneDescrip.TabIndex = 11;
            this.txtCloneDescrip.Text = "This will test the container_get and container_create methods with the source and" +
    " destinations provided";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "New Tube";
            // 
            // txtCloned
            // 
            this.txtCloned.Location = new System.Drawing.Point(122, 42);
            this.txtCloned.Name = "txtCloned";
            this.txtCloned.Size = new System.Drawing.Size(100, 20);
            this.txtCloned.TabIndex = 8;
            this.txtCloned.Text = "ClonedTube03";
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(26, 26);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(75, 13);
            this.lblSource.TabIndex = 7;
            this.lblSource.Text = "Tube To Copy";
            // 
            // grpContainerSolvate
            // 
            this.grpContainerSolvate.Controls.Add(this.cmbTypes);
            this.grpContainerSolvate.Controls.Add(this.numVol);
            this.grpContainerSolvate.Controls.Add(this.numConc);
            this.grpContainerSolvate.Controls.Add(this.lblVol);
            this.grpContainerSolvate.Controls.Add(this.lblUnit);
            this.grpContainerSolvate.Controls.Add(this.btnSolvate);
            this.grpContainerSolvate.Controls.Add(this.txtUnit);
            this.grpContainerSolvate.Controls.Add(this.lblConc);
            this.grpContainerSolvate.Controls.Add(this.txtSolvDescription);
            this.grpContainerSolvate.Controls.Add(this.lblCType);
            this.grpContainerSolvate.Controls.Add(this.lblSolvTube);
            this.grpContainerSolvate.Controls.Add(this.txtSolvTube);
            this.grpContainerSolvate.Location = new System.Drawing.Point(12, 93);
            this.grpContainerSolvate.Name = "grpContainerSolvate";
            this.grpContainerSolvate.Size = new System.Drawing.Size(664, 116);
            this.grpContainerSolvate.TabIndex = 10;
            this.grpContainerSolvate.TabStop = false;
            this.grpContainerSolvate.Text = "Tube Solvate";
            // 
            // cmbTypes
            // 
            this.cmbTypes.FormattingEnabled = true;
            this.cmbTypes.Location = new System.Drawing.Point(122, 42);
            this.cmbTypes.Name = "cmbTypes";
            this.cmbTypes.Size = new System.Drawing.Size(121, 21);
            this.cmbTypes.TabIndex = 11;
            // 
            // numVol
            // 
            this.numVol.Location = new System.Drawing.Point(122, 84);
            this.numVol.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numVol.Name = "numVol";
            this.numVol.Size = new System.Drawing.Size(121, 20);
            this.numVol.TabIndex = 19;
            this.numVol.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numConc
            // 
            this.numConc.Location = new System.Drawing.Point(249, 42);
            this.numConc.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numConc.Name = "numConc";
            this.numConc.Size = new System.Drawing.Size(101, 20);
            this.numConc.TabIndex = 11;
            this.numConc.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // lblVol
            // 
            this.lblVol.AutoSize = true;
            this.lblVol.Location = new System.Drawing.Point(134, 68);
            this.lblVol.Name = "lblVol";
            this.lblVol.Size = new System.Drawing.Size(55, 13);
            this.lblVol.TabIndex = 18;
            this.lblVol.Text = "Actual Vol";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(28, 68);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(54, 13);
            this.lblUnit.TabIndex = 16;
            this.lblUnit.Text = "Conc Unit";
            // 
            // btnSolvate
            // 
            this.btnSolvate.Location = new System.Drawing.Point(249, 81);
            this.btnSolvate.Name = "btnSolvate";
            this.btnSolvate.Size = new System.Drawing.Size(101, 23);
            this.btnSolvate.TabIndex = 0;
            this.btnSolvate.Text = "Dissolve";
            this.btnSolvate.UseVisualStyleBackColor = true;
            this.btnSolvate.Click += new System.EventHandler(this.BtnSolvate_Click);
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(16, 84);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(100, 20);
            this.txtUnit.TabIndex = 15;
            this.txtUnit.Text = "mg/ml";
            // 
            // lblConc
            // 
            this.lblConc.AutoSize = true;
            this.lblConc.Location = new System.Drawing.Point(265, 26);
            this.lblConc.Name = "lblConc";
            this.lblConc.Size = new System.Drawing.Size(66, 13);
            this.lblConc.TabIndex = 14;
            this.lblConc.Text = "Target Conc";
            // 
            // txtSolvDescription
            // 
            this.txtSolvDescription.Enabled = false;
            this.txtSolvDescription.Location = new System.Drawing.Point(360, 64);
            this.txtSolvDescription.Multiline = true;
            this.txtSolvDescription.Name = "txtSolvDescription";
            this.txtSolvDescription.Size = new System.Drawing.Size(298, 40);
            this.txtSolvDescription.TabIndex = 12;
            this.txtSolvDescription.Text = "This will test the container_solvate method for the  tube name entered. Solvent w" +
    "ill be DMSO 100%.";
            // 
            // lblCType
            // 
            this.lblCType.AutoSize = true;
            this.lblCType.Location = new System.Drawing.Point(143, 26);
            this.lblCType.Name = "lblCType";
            this.lblCType.Size = new System.Drawing.Size(79, 13);
            this.lblCType.TabIndex = 9;
            this.lblCType.Text = "Container Type";
            // 
            // lblSolvTube
            // 
            this.lblSolvTube.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.lblSolvTube.AutoSize = true;
            this.lblSolvTube.Location = new System.Drawing.Point(26, 26);
            this.lblSolvTube.Name = "lblSolvTube";
            this.lblSolvTube.Size = new System.Drawing.Size(91, 13);
            this.lblSolvTube.TabIndex = 7;
            this.lblSolvTube.Text = "Tube To Dissolve";
            // 
            // txtSolvTube
            // 
            this.txtSolvTube.Location = new System.Drawing.Point(16, 42);
            this.txtSolvTube.Name = "txtSolvTube";
            this.txtSolvTube.Size = new System.Drawing.Size(100, 20);
            this.txtSolvTube.TabIndex = 5;
            this.txtSolvTube.Text = "powder1";
            // 
            // grpFormLoad
            // 
            this.grpFormLoad.Controls.Add(this.cmbLayoutLoad);
            this.grpFormLoad.Controls.Add(this.cmbTypeLoad);
            this.grpFormLoad.Controls.Add(this.txtListDesciption);
            this.grpFormLoad.Controls.Add(this.label2);
            this.grpFormLoad.Controls.Add(this.label3);
            this.grpFormLoad.Location = new System.Drawing.Point(696, 12);
            this.grpFormLoad.Name = "grpFormLoad";
            this.grpFormLoad.Size = new System.Drawing.Size(569, 75);
            this.grpFormLoad.TabIndex = 12;
            this.grpFormLoad.TabStop = false;
            this.grpFormLoad.Text = "Form Load";
            // 
            // cmbLayoutLoad
            // 
            this.cmbLayoutLoad.FormattingEnabled = true;
            this.cmbLayoutLoad.Location = new System.Drawing.Point(133, 42);
            this.cmbLayoutLoad.Name = "cmbLayoutLoad";
            this.cmbLayoutLoad.Size = new System.Drawing.Size(121, 21);
            this.cmbLayoutLoad.TabIndex = 21;
            // 
            // cmbTypeLoad
            // 
            this.cmbTypeLoad.FormattingEnabled = true;
            this.cmbTypeLoad.Location = new System.Drawing.Point(6, 42);
            this.cmbTypeLoad.Name = "cmbTypeLoad";
            this.cmbTypeLoad.Size = new System.Drawing.Size(121, 21);
            this.cmbTypeLoad.TabIndex = 20;
            // 
            // txtListDesciption
            // 
            this.txtListDesciption.Enabled = false;
            this.txtListDesciption.Location = new System.Drawing.Point(260, 23);
            this.txtListDesciption.Multiline = true;
            this.txtListDesciption.Name = "txtListDesciption";
            this.txtListDesciption.Size = new System.Drawing.Size(298, 46);
            this.txtListDesciption.TabIndex = 11;
            this.txtListDesciption.Text = "When the form loads. The list layout and type methods are called to populate thes" +
    "e comboboxes. If they are populated then it passes.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "ContainerLayout";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ContainerType";
            // 
            // grpProtect
            // 
            this.grpProtect.Controls.Add(this.cmbProtections);
            this.grpProtect.Controls.Add(this.cmbProtector);
            this.grpProtect.Controls.Add(this.btnUnProtect);
            this.grpProtect.Controls.Add(this.lblProtection);
            this.grpProtect.Controls.Add(this.txtProtectDescription);
            this.grpProtect.Controls.Add(this.lblUser);
            this.grpProtect.Controls.Add(this.lblTubProtect);
            this.grpProtect.Controls.Add(this.txtTubProtect);
            this.grpProtect.Controls.Add(this.btnProtect);
            this.grpProtect.Location = new System.Drawing.Point(12, 215);
            this.grpProtect.Name = "grpProtect";
            this.grpProtect.Size = new System.Drawing.Size(664, 111);
            this.grpProtect.TabIndex = 13;
            this.grpProtect.TabStop = false;
            this.grpProtect.Text = "Protections";
            // 
            // cmbProtections
            // 
            this.cmbProtections.FormattingEnabled = true;
            this.cmbProtections.Location = new System.Drawing.Point(16, 81);
            this.cmbProtections.Name = "cmbProtections";
            this.cmbProtections.Size = new System.Drawing.Size(206, 21);
            this.cmbProtections.TabIndex = 21;
            // 
            // cmbProtector
            // 
            this.cmbProtector.FormattingEnabled = true;
            this.cmbProtector.Location = new System.Drawing.Point(122, 42);
            this.cmbProtector.Name = "cmbProtector";
            this.cmbProtector.Size = new System.Drawing.Size(100, 21);
            this.cmbProtector.TabIndex = 20;
            // 
            // btnUnProtect
            // 
            this.btnUnProtect.Location = new System.Drawing.Point(228, 69);
            this.btnUnProtect.Name = "btnUnProtect";
            this.btnUnProtect.Size = new System.Drawing.Size(126, 23);
            this.btnUnProtect.TabIndex = 14;
            this.btnUnProtect.Text = "Unprotect Tube";
            this.btnUnProtect.UseVisualStyleBackColor = true;
            this.btnUnProtect.Click += new System.EventHandler(this.BtnUnProtect_Click);
            // 
            // lblProtection
            // 
            this.lblProtection.AutoSize = true;
            this.lblProtection.Location = new System.Drawing.Point(87, 65);
            this.lblProtection.Name = "lblProtection";
            this.lblProtection.Size = new System.Drawing.Size(55, 13);
            this.lblProtection.TabIndex = 13;
            this.lblProtection.Text = "Protection";
            // 
            // txtProtectDescription
            // 
            this.txtProtectDescription.Enabled = false;
            this.txtProtectDescription.Location = new System.Drawing.Point(360, 29);
            this.txtProtectDescription.Multiline = true;
            this.txtProtectDescription.Name = "txtProtectDescription";
            this.txtProtectDescription.Size = new System.Drawing.Size(298, 40);
            this.txtProtectDescription.TabIndex = 11;
            this.txtProtectDescription.Text = "This will test the container protect and container unprotect methods ";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(134, 26);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(50, 13);
            this.lblUser.TabIndex = 9;
            this.lblUser.Text = "Protector";
            // 
            // lblTubProtect
            // 
            this.lblTubProtect.AutoSize = true;
            this.lblTubProtect.Location = new System.Drawing.Point(50, 26);
            this.lblTubProtect.Name = "lblTubProtect";
            this.lblTubProtect.Size = new System.Drawing.Size(32, 13);
            this.lblTubProtect.TabIndex = 7;
            this.lblTubProtect.Text = "Tube";
            // 
            // txtTubProtect
            // 
            this.txtTubProtect.Location = new System.Drawing.Point(16, 42);
            this.txtTubProtect.Name = "txtTubProtect";
            this.txtTubProtect.Size = new System.Drawing.Size(100, 20);
            this.txtTubProtect.TabIndex = 5;
            this.txtTubProtect.Text = "tube3";
            // 
            // btnProtect
            // 
            this.btnProtect.Location = new System.Drawing.Point(228, 40);
            this.btnProtect.Name = "btnProtect";
            this.btnProtect.Size = new System.Drawing.Size(126, 23);
            this.btnProtect.TabIndex = 0;
            this.btnProtect.Text = "Protect  Tube";
            this.btnProtect.UseVisualStyleBackColor = true;
            this.btnProtect.Click += new System.EventHandler(this.BtnProtect_Click);
            // 
            // grpMove
            // 
            this.grpMove.Controls.Add(this.txtLocation);
            this.grpMove.Controls.Add(this.btnBin);
            this.grpMove.Controls.Add(this.lblLocations);
            this.grpMove.Controls.Add(this.txtMoveDescription);
            this.grpMove.Controls.Add(this.lblTubMove);
            this.grpMove.Controls.Add(this.txtTubMove);
            this.grpMove.Controls.Add(this.btnMove);
            this.grpMove.Location = new System.Drawing.Point(12, 332);
            this.grpMove.Name = "grpMove";
            this.grpMove.Size = new System.Drawing.Size(664, 111);
            this.grpMove.TabIndex = 22;
            this.grpMove.TabStop = false;
            this.grpMove.Text = "Move";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(16, 80);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(312, 20);
            this.txtLocation.TabIndex = 20;
            this.txtLocation.Text = "UK/B";
            // 
            // btnBin
            // 
            this.btnBin.Location = new System.Drawing.Point(122, 39);
            this.btnBin.Name = "btnBin";
            this.btnBin.Size = new System.Drawing.Size(100, 23);
            this.btnBin.TabIndex = 24;
            this.btnBin.Text = "Bin Tube";
            this.btnBin.UseVisualStyleBackColor = true;
            this.btnBin.Click += new System.EventHandler(this.BtnBin_Click);
            // 
            // lblLocations
            // 
            this.lblLocations.AutoSize = true;
            this.lblLocations.Location = new System.Drawing.Point(143, 65);
            this.lblLocations.Name = "lblLocations";
            this.lblLocations.Size = new System.Drawing.Size(48, 13);
            this.lblLocations.TabIndex = 13;
            this.lblLocations.Text = "Location";
            // 
            // txtMoveDescription
            // 
            this.txtMoveDescription.Enabled = false;
            this.txtMoveDescription.Location = new System.Drawing.Point(360, 29);
            this.txtMoveDescription.Multiline = true;
            this.txtMoveDescription.Name = "txtMoveDescription";
            this.txtMoveDescription.Size = new System.Drawing.Size(298, 40);
            this.txtMoveDescription.TabIndex = 11;
            this.txtMoveDescription.Text = "This will test the container move and container move to bin. The slot will always" +
    " be A1";
            // 
            // lblTubMove
            // 
            this.lblTubMove.AutoSize = true;
            this.lblTubMove.Location = new System.Drawing.Point(50, 26);
            this.lblTubMove.Name = "lblTubMove";
            this.lblTubMove.Size = new System.Drawing.Size(32, 13);
            this.lblTubMove.TabIndex = 7;
            this.lblTubMove.Text = "Tube";
            // 
            // txtTubMove
            // 
            this.txtTubMove.Location = new System.Drawing.Point(16, 42);
            this.txtTubMove.Name = "txtTubMove";
            this.txtTubMove.Size = new System.Drawing.Size(100, 20);
            this.txtTubMove.TabIndex = 5;
            this.txtTubMove.Text = "tube3";
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(228, 39);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(100, 23);
            this.btnMove.TabIndex = 0;
            this.btnMove.Text = "Move Tube";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.BtnMove_Click);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(12, 627);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(126, 23);
            this.btnAll.TabIndex = 12;
            this.btnAll.Text = "RunAll";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.BtnAll_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.lblDescrip);
            this.groupBox1.Controls.Add(this.txtDescrip);
            this.groupBox1.Controls.Add(this.lblUpdate);
            this.groupBox1.Controls.Add(this.txtUpdate);
            this.groupBox1.Controls.Add(this.btnUpdateTube);
            this.groupBox1.Location = new System.Drawing.Point(12, 449);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 75);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update Tube";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(360, 29);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(298, 40);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "This will test the container_get and container_update methods with the tube and d" +
    "escription provided";
            // 
            // lblDescrip
            // 
            this.lblDescrip.AutoSize = true;
            this.lblDescrip.Location = new System.Drawing.Point(134, 26);
            this.lblDescrip.Name = "lblDescrip";
            this.lblDescrip.Size = new System.Drawing.Size(60, 13);
            this.lblDescrip.TabIndex = 9;
            this.lblDescrip.Text = "Description";
            // 
            // txtDescrip
            // 
            this.txtDescrip.Location = new System.Drawing.Point(122, 42);
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Size = new System.Drawing.Size(100, 20);
            this.txtDescrip.TabIndex = 8;
            this.txtDescrip.Text = "Updated by WS";
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Location = new System.Drawing.Point(26, 26);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(86, 13);
            this.lblUpdate.TabIndex = 7;
            this.lblUpdate.Text = "Tube To Update";
            // 
            // txtUpdate
            // 
            this.txtUpdate.Location = new System.Drawing.Point(16, 42);
            this.txtUpdate.Name = "txtUpdate";
            this.txtUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtUpdate.TabIndex = 5;
            this.txtUpdate.Text = "tube4";
            // 
            // btnUpdateTube
            // 
            this.btnUpdateTube.Location = new System.Drawing.Point(228, 40);
            this.btnUpdateTube.Name = "btnUpdateTube";
            this.btnUpdateTube.Size = new System.Drawing.Size(126, 23);
            this.btnUpdateTube.TabIndex = 0;
            this.btnUpdateTube.Text = "Update Descrip";
            this.btnUpdateTube.UseVisualStyleBackColor = true;
            this.btnUpdateTube.Click += new System.EventHandler(this.BtnUpdateTube_Click);
            // 
            // btnImportPlate
            // 
            this.btnImportPlate.Location = new System.Drawing.Point(16, 27);
            this.btnImportPlate.Name = "btnImportPlate";
            this.btnImportPlate.Size = new System.Drawing.Size(126, 23);
            this.btnImportPlate.TabIndex = 12;
            this.btnImportPlate.Text = "Import Plate";
            this.btnImportPlate.UseVisualStyleBackColor = true;
            this.btnImportPlate.Click += new System.EventHandler(this.BtnImportPlate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btmImpTubes);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.btnImportPlate);
            this.groupBox2.Location = new System.Drawing.Point(12, 541);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(664, 75);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Plate From File";
            // 
            // btmImpTubes
            // 
            this.btmImpTubes.Location = new System.Drawing.Point(148, 27);
            this.btmImpTubes.Name = "btmImpTubes";
            this.btmImpTubes.Size = new System.Drawing.Size(126, 23);
            this.btmImpTubes.TabIndex = 13;
            this.btmImpTubes.Text = "Bulk Import Tubes";
            this.btmImpTubes.UseVisualStyleBackColor = true;
            this.btmImpTubes.Click += new System.EventHandler(this.btmImpTubes_Click);
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(366, 17);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(298, 47);
            this.textBox3.TabIndex = 11;
            this.textBox3.Text = "This will test the container_create method for a plate using the selected file OR" +
    " the container upload method for multiple tubes";
            // 
            // btnIndContainer
            // 
            this.btnIndContainer.Location = new System.Drawing.Point(158, 627);
            this.btnIndContainer.Name = "btnIndContainer";
            this.btnIndContainer.Size = new System.Drawing.Size(126, 23);
            this.btnIndContainer.TabIndex = 25;
            this.btnIndContainer.Text = "Individual Fields";
            this.btnIndContainer.UseVisualStyleBackColor = true;
            this.btnIndContainer.Click += new System.EventHandler(this.BtnIndContainer_Click);
            // 
            // btnWatson
            // 
            this.btnWatson.Location = new System.Drawing.Point(312, 627);
            this.btnWatson.Name = "btnWatson";
            this.btnWatson.Size = new System.Drawing.Size(126, 23);
            this.btnWatson.TabIndex = 26;
            this.btnWatson.Text = "Watson";
            this.btnWatson.UseVisualStyleBackColor = true;
            this.btnWatson.Click += new System.EventHandler(this.BtnWatson_Click);
            // 
            // frmInvTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 732);
            this.Controls.Add(this.btnWatson);
            this.Controls.Add(this.btnIndContainer);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.grpMove);
            this.Controls.Add(this.grpProtect);
            this.Controls.Add(this.grpFormLoad);
            this.Controls.Add(this.grpContainerSolvate);
            this.Controls.Add(this.grpClone);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.rtbWSOutput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInvTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Inventory Test";
            this.grpClone.ResumeLayout(false);
            this.grpClone.PerformLayout();
            this.grpContainerSolvate.ResumeLayout(false);
            this.grpContainerSolvate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numConc)).EndInit();
            this.grpFormLoad.ResumeLayout(false);
            this.grpFormLoad.PerformLayout();
            this.grpProtect.ResumeLayout(false);
            this.grpProtect.PerformLayout();
            this.grpMove.ResumeLayout(false);
            this.grpMove.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCloneTest;
        private System.Windows.Forms.RichTextBox rtbWSOutput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.GroupBox grpClone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCloned;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.TextBox txtCloneDescrip;
        private System.Windows.Forms.GroupBox grpContainerSolvate;
        private System.Windows.Forms.Label lblCType;
        private System.Windows.Forms.Label lblSolvTube;
        private System.Windows.Forms.TextBox txtSolvTube;
        private System.Windows.Forms.Button btnSolvate;
        private System.Windows.Forms.TextBox txtSolvDescription;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label lblConc;
        private System.Windows.Forms.Label lblVol;
        private System.Windows.Forms.NumericUpDown numConc;
        private System.Windows.Forms.NumericUpDown numVol;
        private System.Windows.Forms.ComboBox cmbTypes;
        private System.Windows.Forms.GroupBox grpFormLoad;
        private System.Windows.Forms.ComboBox cmbLayoutLoad;
        private System.Windows.Forms.ComboBox cmbTypeLoad;
        private System.Windows.Forms.TextBox txtListDesciption;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpProtect;
        private System.Windows.Forms.TextBox txtProtectDescription;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblTubProtect;
        private System.Windows.Forms.TextBox txtTubProtect;
        private System.Windows.Forms.Button btnProtect;
        private System.Windows.Forms.Button btnUnProtect;
        private System.Windows.Forms.Label lblProtection;
        private System.Windows.Forms.ComboBox cmbProtector;
        private System.Windows.Forms.ComboBox cmbProtections;
        private System.Windows.Forms.GroupBox grpMove;
        private System.Windows.Forms.Label lblLocations;
        private System.Windows.Forms.TextBox txtMoveDescription;
        private System.Windows.Forms.Label lblTubMove;
        private System.Windows.Forms.TextBox txtTubMove;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnBin;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblDescrip;
        private System.Windows.Forms.TextBox txtDescrip;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.TextBox txtUpdate;
        private System.Windows.Forms.Button btnUpdateTube;
        private System.Windows.Forms.Button btnImportPlate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnIndContainer;
        private System.Windows.Forms.Button btnWatson;
        private System.Windows.Forms.Button btmImpTubes;
    }
}

