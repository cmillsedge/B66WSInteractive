namespace BR6WSInteractive
{
    partial class frmOrdCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrdCreate));
            this.cmbSType = new System.Windows.Forms.ComboBox();
            this.lblSType = new System.Windows.Forms.Label();
            this.cmbOType = new System.Windows.Forms.ComboBox();
            this.lblOType = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.cmbLayout = new System.Windows.Forms.ComboBox();
            this.lblLayout = new System.Windows.Forms.Label();
            this.cmbTypes = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblSamples = new System.Windows.Forms.Label();
            this.cmbSamples = new System.Windows.Forms.ComboBox();
            this.btnAddSample = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.rtbWSOutput = new System.Windows.Forms.RichTextBox();
            this.lblMessages = new System.Windows.Forms.Label();
            this.lblInstruc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSType
            // 
            this.cmbSType.FormattingEnabled = true;
            this.cmbSType.Items.AddRange(new object[] {
            "batch"});
            this.cmbSType.Location = new System.Drawing.Point(132, 62);
            this.cmbSType.Name = "cmbSType";
            this.cmbSType.Size = new System.Drawing.Size(226, 21);
            this.cmbSType.TabIndex = 46;
            this.cmbSType.Text = "batch";
            // 
            // lblSType
            // 
            this.lblSType.AutoSize = true;
            this.lblSType.Location = new System.Drawing.Point(23, 65);
            this.lblSType.Name = "lblSType";
            this.lblSType.Size = new System.Drawing.Size(69, 13);
            this.lblSType.TabIndex = 45;
            this.lblSType.Text = "Sample Type";
            // 
            // cmbOType
            // 
            this.cmbOType.FormattingEnabled = true;
            this.cmbOType.Items.AddRange(new object[] {
            "Thing1",
            "Thing2"});
            this.cmbOType.Location = new System.Drawing.Point(132, 28);
            this.cmbOType.Name = "cmbOType";
            this.cmbOType.Size = new System.Drawing.Size(226, 21);
            this.cmbOType.TabIndex = 48;
            this.cmbOType.Text = "evotec_powders";
            this.cmbOType.TextChanged += new System.EventHandler(this.CmbOType_TextChanged);
            // 
            // lblOType
            // 
            this.lblOType.AutoSize = true;
            this.lblOType.Location = new System.Drawing.Point(23, 31);
            this.lblOType.Name = "lblOType";
            this.lblOType.Size = new System.Drawing.Size(60, 13);
            this.lblOType.TabIndex = 47;
            this.lblOType.Text = "Order Type";
            // 
            // btnOrder
            // 
            this.btnOrder.Enabled = false;
            this.btnOrder.Location = new System.Drawing.Point(1309, 475);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 49;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.BtnOrder_Click);
            // 
            // cmbLayout
            // 
            this.cmbLayout.FormattingEnabled = true;
            this.cmbLayout.Items.AddRange(new object[] {
            "batch"});
            this.cmbLayout.Location = new System.Drawing.Point(132, 98);
            this.cmbLayout.Name = "cmbLayout";
            this.cmbLayout.Size = new System.Drawing.Size(226, 21);
            this.cmbLayout.TabIndex = 50;
            this.cmbLayout.Text = "tube";
            // 
            // lblLayout
            // 
            this.lblLayout.AutoSize = true;
            this.lblLayout.Location = new System.Drawing.Point(23, 101);
            this.lblLayout.Name = "lblLayout";
            this.lblLayout.Size = new System.Drawing.Size(87, 13);
            this.lblLayout.TabIndex = 51;
            this.lblLayout.Text = "Container Layout";
            // 
            // cmbTypes
            // 
            this.cmbTypes.FormattingEnabled = true;
            this.cmbTypes.Items.AddRange(new object[] {
            "batch"});
            this.cmbTypes.Location = new System.Drawing.Point(132, 136);
            this.cmbTypes.Name = "cmbTypes";
            this.cmbTypes.Size = new System.Drawing.Size(226, 21);
            this.cmbTypes.TabIndex = 52;
            this.cmbTypes.Text = "1 dram vial";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(23, 139);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(79, 13);
            this.lblType.TabIndex = 53;
            this.lblType.Text = "Container Type";
            // 
            // lblSamples
            // 
            this.lblSamples.AutoSize = true;
            this.lblSamples.Location = new System.Drawing.Point(23, 179);
            this.lblSamples.Name = "lblSamples";
            this.lblSamples.Size = new System.Drawing.Size(47, 13);
            this.lblSamples.TabIndex = 54;
            this.lblSamples.Text = "Samples";
            // 
            // cmbSamples
            // 
            this.cmbSamples.FormattingEnabled = true;
            this.cmbSamples.Items.AddRange(new object[] {
            "batch"});
            this.cmbSamples.Location = new System.Drawing.Point(132, 176);
            this.cmbSamples.Name = "cmbSamples";
            this.cmbSamples.Size = new System.Drawing.Size(226, 21);
            this.cmbSamples.TabIndex = 55;
            this.cmbSamples.TextChanged += new System.EventHandler(this.cmbSamples_TextChanged);
            // 
            // btnAddSample
            // 
            this.btnAddSample.Location = new System.Drawing.Point(364, 174);
            this.btnAddSample.Name = "btnAddSample";
            this.btnAddSample.Size = new System.Drawing.Size(105, 23);
            this.btnAddSample.TabIndex = 56;
            this.btnAddSample.Text = "Add Sample";
            this.btnAddSample.UseVisualStyleBackColor = true;
            this.btnAddSample.Click += new System.EventHandler(this.BtnAddSample_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(1228, 475);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 59;
            this.btnCheck.Text = "Check Order";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // dgvOrder
            // 
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(12, 239);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.Size = new System.Drawing.Size(1372, 230);
            this.dgvOrder.TabIndex = 60;
            this.dgvOrder.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DgvOrder_RowsAdded);
            // 
            // rtbWSOutput
            // 
            this.rtbWSOutput.Location = new System.Drawing.Point(539, 28);
            this.rtbWSOutput.Name = "rtbWSOutput";
            this.rtbWSOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbWSOutput.Size = new System.Drawing.Size(286, 169);
            this.rtbWSOutput.TabIndex = 91;
            this.rtbWSOutput.Text = "";
            // 
            // lblMessages
            // 
            this.lblMessages.AutoSize = true;
            this.lblMessages.Location = new System.Drawing.Point(536, 12);
            this.lblMessages.Name = "lblMessages";
            this.lblMessages.Size = new System.Drawing.Size(39, 13);
            this.lblMessages.TabIndex = 92;
            this.lblMessages.Text = "Output";
            // 
            // lblInstruc
            // 
            this.lblInstruc.AutoSize = true;
            this.lblInstruc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInstruc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruc.ForeColor = System.Drawing.Color.DarkRed;
            this.lblInstruc.Location = new System.Drawing.Point(12, 214);
            this.lblInstruc.Name = "lblInstruc";
            this.lblInstruc.Size = new System.Drawing.Size(1117, 22);
            this.lblInstruc.TabIndex = 93;
            this.lblInstruc.Text = "To add rows to the data grid simply type something in any cell and a row will be " +
    "added below. To assign a sample to a row, select the row and click add sample.";
            // 
            // frmOrdCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 508);
            this.Controls.Add(this.lblInstruc);
            this.Controls.Add(this.lblMessages);
            this.Controls.Add(this.rtbWSOutput);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnAddSample);
            this.Controls.Add(this.cmbSamples);
            this.Controls.Add(this.lblSamples);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cmbTypes);
            this.Controls.Add(this.lblLayout);
            this.Controls.Add(this.cmbLayout);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.cmbOType);
            this.Controls.Add(this.lblOType);
            this.Controls.Add(this.cmbSType);
            this.Controls.Add(this.lblSType);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOrdCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Order Create";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbSType;
        private System.Windows.Forms.Label lblSType;
        private System.Windows.Forms.ComboBox cmbOType;
        private System.Windows.Forms.Label lblOType;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.ComboBox cmbLayout;
        private System.Windows.Forms.Label lblLayout;
        private System.Windows.Forms.ComboBox cmbTypes;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblSamples;
        private System.Windows.Forms.ComboBox cmbSamples;
        private System.Windows.Forms.Button btnAddSample;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.RichTextBox rtbWSOutput;
        private System.Windows.Forms.Label lblMessages;
        private System.Windows.Forms.Label lblInstruc;
    }
}