namespace BR6WSInteractive
{
    partial class frmNewRecipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewRecipe));
            this.grpRowEdit = new System.Windows.Forms.GroupBox();
            this.numRow = new System.Windows.Forms.NumericUpDown();
            this.lblRow = new System.Windows.Forms.Label();
            this.btnFetchRow = new System.Windows.Forms.Button();
            this.btnUpdRow = new System.Windows.Forms.Button();
            this.txtPercentage = new System.Windows.Forms.TextBox();
            this.cmbSType = new System.Windows.Forms.ComboBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.txtCommonName = new System.Windows.Forms.TextBox();
            this.lblPerc = new System.Windows.Forms.Label();
            this.lblCommonName = new System.Windows.Forms.Label();
            this.lblSampleType = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblRecIngred = new System.Windows.Forms.Label();
            this.dgvIngredients = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SampleType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TheoreticalPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMType = new System.Windows.Forms.Label();
            this.txtMType = new System.Windows.Forms.TextBox();
            this.lblOutcome = new System.Windows.Forms.Label();
            this.lblRecProps = new System.Windows.Forms.Label();
            this.lblRecCProps = new System.Windows.Forms.Label();
            this.rtbWSOutput = new System.Windows.Forms.RichTextBox();
            this.dgvMat = new System.Windows.Forms.DataGridView();
            this.PropName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PropVal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDescrip = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDescrip = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.grpRowEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMat)).BeginInit();
            this.SuspendLayout();
            // 
            // grpRowEdit
            // 
            this.grpRowEdit.Controls.Add(this.numRow);
            this.grpRowEdit.Controls.Add(this.lblRow);
            this.grpRowEdit.Controls.Add(this.btnFetchRow);
            this.grpRowEdit.Controls.Add(this.btnUpdRow);
            this.grpRowEdit.Controls.Add(this.txtPercentage);
            this.grpRowEdit.Controls.Add(this.cmbSType);
            this.grpRowEdit.Controls.Add(this.cmbRole);
            this.grpRowEdit.Controls.Add(this.txtCommonName);
            this.grpRowEdit.Controls.Add(this.lblPerc);
            this.grpRowEdit.Controls.Add(this.lblCommonName);
            this.grpRowEdit.Controls.Add(this.lblSampleType);
            this.grpRowEdit.Controls.Add(this.lblRole);
            this.grpRowEdit.Location = new System.Drawing.Point(15, 392);
            this.grpRowEdit.Name = "grpRowEdit";
            this.grpRowEdit.Size = new System.Drawing.Size(1130, 86);
            this.grpRowEdit.TabIndex = 52;
            this.grpRowEdit.TabStop = false;
            this.grpRowEdit.Text = "Row Add or Update";
            // 
            // numRow
            // 
            this.numRow.Enabled = false;
            this.numRow.Location = new System.Drawing.Point(986, 36);
            this.numRow.Name = "numRow";
            this.numRow.Size = new System.Drawing.Size(45, 20);
            this.numRow.TabIndex = 42;
            // 
            // lblRow
            // 
            this.lblRow.AutoSize = true;
            this.lblRow.Location = new System.Drawing.Point(948, 40);
            this.lblRow.Name = "lblRow";
            this.lblRow.Size = new System.Drawing.Size(32, 13);
            this.lblRow.TabIndex = 41;
            this.lblRow.Text = "Row:";
            // 
            // btnFetchRow
            // 
            this.btnFetchRow.Location = new System.Drawing.Point(1049, 16);
            this.btnFetchRow.Name = "btnFetchRow";
            this.btnFetchRow.Size = new System.Drawing.Size(75, 23);
            this.btnFetchRow.TabIndex = 40;
            this.btnFetchRow.Text = "Fetch Row";
            this.btnFetchRow.UseVisualStyleBackColor = true;
            this.btnFetchRow.Click += new System.EventHandler(this.btnFetchRow_Click);
            // 
            // btnUpdRow
            // 
            this.btnUpdRow.Location = new System.Drawing.Point(1049, 45);
            this.btnUpdRow.Name = "btnUpdRow";
            this.btnUpdRow.Size = new System.Drawing.Size(75, 23);
            this.btnUpdRow.TabIndex = 34;
            this.btnUpdRow.Text = "Update Row";
            this.btnUpdRow.UseVisualStyleBackColor = true;
            this.btnUpdRow.Click += new System.EventHandler(this.btnUpdRow_Click);
            // 
            // txtPercentage
            // 
            this.txtPercentage.Location = new System.Drawing.Point(488, 37);
            this.txtPercentage.Name = "txtPercentage";
            this.txtPercentage.Size = new System.Drawing.Size(148, 20);
            this.txtPercentage.TabIndex = 37;
            // 
            // cmbSType
            // 
            this.cmbSType.FormattingEnabled = true;
            this.cmbSType.Location = new System.Drawing.Point(336, 37);
            this.cmbSType.Name = "cmbSType";
            this.cmbSType.Size = new System.Drawing.Size(146, 21);
            this.cmbSType.TabIndex = 36;
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(191, 37);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(139, 21);
            this.cmbRole.TabIndex = 35;
            // 
            // txtCommonName
            // 
            this.txtCommonName.Location = new System.Drawing.Point(37, 37);
            this.txtCommonName.Name = "txtCommonName";
            this.txtCommonName.Size = new System.Drawing.Size(148, 20);
            this.txtCommonName.TabIndex = 34;
            // 
            // lblPerc
            // 
            this.lblPerc.AutoSize = true;
            this.lblPerc.Location = new System.Drawing.Point(500, 21);
            this.lblPerc.Name = "lblPerc";
            this.lblPerc.Size = new System.Drawing.Size(93, 13);
            this.lblPerc.TabIndex = 31;
            this.lblPerc.Text = "Theor Percentage";
            // 
            // lblCommonName
            // 
            this.lblCommonName.AutoSize = true;
            this.lblCommonName.Location = new System.Drawing.Point(34, 21);
            this.lblCommonName.Name = "lblCommonName";
            this.lblCommonName.Size = new System.Drawing.Size(79, 13);
            this.lblCommonName.TabIndex = 29;
            this.lblCommonName.Text = "Common Name";
            // 
            // lblSampleType
            // 
            this.lblSampleType.AutoSize = true;
            this.lblSampleType.Location = new System.Drawing.Point(348, 21);
            this.lblSampleType.Name = "lblSampleType";
            this.lblSampleType.Size = new System.Drawing.Size(69, 13);
            this.lblSampleType.TabIndex = 30;
            this.lblSampleType.Text = "Sample Type";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(198, 21);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(29, 13);
            this.lblRole.TabIndex = 28;
            this.lblRole.Text = "Role";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(1070, 490);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 47;
            this.btnCreate.Text = "Create Formulation";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblRecIngred
            // 
            this.lblRecIngred.AutoSize = true;
            this.lblRecIngred.Location = new System.Drawing.Point(12, 183);
            this.lblRecIngred.Name = "lblRecIngred";
            this.lblRecIngred.Size = new System.Drawing.Size(116, 13);
            this.lblRecIngred.TabIndex = 46;
            this.lblRecIngred.Text = "Formulation Ingredients";
            // 
            // dgvIngredients
            // 
            this.dgvIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngredients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.SampleType,
            this.TheoreticalPercentage});
            this.dgvIngredients.Location = new System.Drawing.Point(15, 209);
            this.dgvIngredients.Name = "dgvIngredients";
            this.dgvIngredients.Size = new System.Drawing.Size(1130, 167);
            this.dgvIngredients.TabIndex = 45;
            this.dgvIngredients.CurrentCellChanged += new System.EventHandler(this.dgvIngredients_CurrentCellChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CommonName";
            this.dataGridViewTextBoxColumn1.HeaderText = "CommonName";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Role";
            this.dataGridViewTextBoxColumn2.HeaderText = "Role";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // SampleType
            // 
            this.SampleType.HeaderText = "SampleType";
            this.SampleType.Name = "SampleType";
            this.SampleType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SampleType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SampleType.Width = 150;
            // 
            // TheoreticalPercentage
            // 
            this.TheoreticalPercentage.DataPropertyName = "TheoreticalPercentage";
            this.TheoreticalPercentage.HeaderText = "TheoreticalPercentage";
            this.TheoreticalPercentage.Name = "TheoreticalPercentage";
            this.TheoreticalPercentage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TheoreticalPercentage.Width = 150;
            // 
            // lblMType
            // 
            this.lblMType.AutoSize = true;
            this.lblMType.Location = new System.Drawing.Point(12, 93);
            this.lblMType.Name = "lblMType";
            this.lblMType.Size = new System.Drawing.Size(71, 13);
            this.lblMType.TabIndex = 44;
            this.lblMType.Text = "Material Type";
            // 
            // txtMType
            // 
            this.txtMType.Enabled = false;
            this.txtMType.Location = new System.Drawing.Point(113, 90);
            this.txtMType.Name = "txtMType";
            this.txtMType.Size = new System.Drawing.Size(220, 20);
            this.txtMType.TabIndex = 43;
            // 
            // lblOutcome
            // 
            this.lblOutcome.AutoSize = true;
            this.lblOutcome.Location = new System.Drawing.Point(701, 9);
            this.lblOutcome.Name = "lblOutcome";
            this.lblOutcome.Size = new System.Drawing.Size(135, 13);
            this.lblOutcome.TabIndex = 42;
            this.lblOutcome.Text = "Web Service Call Outcome";
            // 
            // lblRecProps
            // 
            this.lblRecProps.AutoSize = true;
            this.lblRecProps.Location = new System.Drawing.Point(12, 9);
            this.lblRecProps.Name = "lblRecProps";
            this.lblRecProps.Size = new System.Drawing.Size(91, 13);
            this.lblRecProps.TabIndex = 41;
            this.lblRecProps.Text = "Recipe Properties";
            // 
            // lblRecCProps
            // 
            this.lblRecCProps.AutoSize = true;
            this.lblRecCProps.Location = new System.Drawing.Point(348, 9);
            this.lblRecCProps.Name = "lblRecCProps";
            this.lblRecCProps.Size = new System.Drawing.Size(149, 13);
            this.lblRecCProps.TabIndex = 40;
            this.lblRecCProps.Text = "Formulation Custom Properties";
            // 
            // rtbWSOutput
            // 
            this.rtbWSOutput.Location = new System.Drawing.Point(704, 35);
            this.rtbWSOutput.Name = "rtbWSOutput";
            this.rtbWSOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbWSOutput.Size = new System.Drawing.Size(441, 142);
            this.rtbWSOutput.TabIndex = 39;
            this.rtbWSOutput.Text = "";
            // 
            // dgvMat
            // 
            this.dgvMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PropName,
            this.PropVal});
            this.dgvMat.Location = new System.Drawing.Point(351, 35);
            this.dgvMat.Name = "dgvMat";
            this.dgvMat.Size = new System.Drawing.Size(318, 142);
            this.dgvMat.TabIndex = 38;
            // 
            // PropName
            // 
            this.PropName.HeaderText = "Property Name";
            this.PropName.Name = "PropName";
            // 
            // PropVal
            // 
            this.PropVal.HeaderText = "PropertyValue";
            this.PropVal.Name = "PropVal";
            // 
            // txtDescrip
            // 
            this.txtDescrip.Location = new System.Drawing.Point(113, 64);
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Size = new System.Drawing.Size(220, 20);
            this.txtDescrip.TabIndex = 37;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(113, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(220, 20);
            this.txtName.TabIndex = 36;
            // 
            // lblDescrip
            // 
            this.lblDescrip.AutoSize = true;
            this.lblDescrip.Location = new System.Drawing.Point(12, 67);
            this.lblDescrip.Name = "lblDescrip";
            this.lblDescrip.Size = new System.Drawing.Size(60, 13);
            this.lblDescrip.TabIndex = 35;
            this.lblDescrip.Text = "Description";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 41);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 34;
            this.lblName.Text = "Name";
            // 
            // frmNewRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 540);
            this.Controls.Add(this.grpRowEdit);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblRecIngred);
            this.Controls.Add(this.dgvIngredients);
            this.Controls.Add(this.lblMType);
            this.Controls.Add(this.txtMType);
            this.Controls.Add(this.lblOutcome);
            this.Controls.Add(this.lblRecProps);
            this.Controls.Add(this.lblRecCProps);
            this.Controls.Add(this.rtbWSOutput);
            this.Controls.Add(this.dgvMat);
            this.Controls.Add(this.txtDescrip);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDescrip);
            this.Controls.Add(this.lblName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNewRecipe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "New Recipe";
            this.grpRowEdit.ResumeLayout(false);
            this.grpRowEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRowEdit;
        private System.Windows.Forms.NumericUpDown numRow;
        private System.Windows.Forms.Label lblRow;
        private System.Windows.Forms.Button btnFetchRow;
        private System.Windows.Forms.Button btnUpdRow;
        private System.Windows.Forms.TextBox txtPercentage;
        private System.Windows.Forms.ComboBox cmbSType;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.TextBox txtCommonName;
        private System.Windows.Forms.Label lblPerc;
        private System.Windows.Forms.Label lblCommonName;
        private System.Windows.Forms.Label lblSampleType;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblRecIngred;
        private System.Windows.Forms.DataGridView dgvIngredients;
        private System.Windows.Forms.Label lblMType;
        private System.Windows.Forms.TextBox txtMType;
        private System.Windows.Forms.Label lblOutcome;
        private System.Windows.Forms.Label lblRecProps;
        private System.Windows.Forms.Label lblRecCProps;
        private System.Windows.Forms.RichTextBox rtbWSOutput;
        private System.Windows.Forms.DataGridView dgvMat;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropVal;
        private System.Windows.Forms.TextBox txtDescrip;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDescrip;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SampleType;
        private System.Windows.Forms.DataGridViewTextBoxColumn TheoreticalPercentage;
    }
}