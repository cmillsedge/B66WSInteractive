namespace BR6WSInteractive
{
    partial class frmMatEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMatEdit));
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescrip = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescrip = new System.Windows.Forms.TextBox();
            this.dgvMat = new System.Windows.Forms.DataGridView();
            this.PropName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PropVal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.rtbWSOutput = new System.Windows.Forms.RichTextBox();
            this.txtSampleType = new System.Windows.Forms.TextBox();
            this.lblSType = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblIdVal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMat)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblDescrip
            // 
            this.lblDescrip.AutoSize = true;
            this.lblDescrip.Location = new System.Drawing.Point(13, 50);
            this.lblDescrip.Name = "lblDescrip";
            this.lblDescrip.Size = new System.Drawing.Size(60, 13);
            this.lblDescrip.TabIndex = 1;
            this.lblDescrip.Text = "Description";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(114, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(220, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtDescrip
            // 
            this.txtDescrip.Location = new System.Drawing.Point(114, 47);
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Size = new System.Drawing.Size(220, 20);
            this.txtDescrip.TabIndex = 5;
            // 
            // dgvMat
            // 
            this.dgvMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PropName,
            this.PropVal});
            this.dgvMat.Location = new System.Drawing.Point(16, 111);
            this.dgvMat.Name = "dgvMat";
            this.dgvMat.Size = new System.Drawing.Size(318, 327);
            this.dgvMat.TabIndex = 6;
            // 
            // PropName
            // 
            this.PropName.HeaderText = "Property Name";
            this.PropName.Name = "PropName";
            this.PropName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PropVal
            // 
            this.PropVal.HeaderText = "PropertyValue";
            this.PropVal.Name = "PropVal";
            this.PropVal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(485, 408);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(76, 30);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // rtbWSOutput
            // 
            this.rtbWSOutput.Location = new System.Drawing.Point(340, 21);
            this.rtbWSOutput.Name = "rtbWSOutput";
            this.rtbWSOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbWSOutput.Size = new System.Drawing.Size(387, 381);
            this.rtbWSOutput.TabIndex = 8;
            this.rtbWSOutput.Text = "";
            // 
            // txtSampleType
            // 
            this.txtSampleType.Location = new System.Drawing.Point(114, 71);
            this.txtSampleType.Name = "txtSampleType";
            this.txtSampleType.Size = new System.Drawing.Size(220, 20);
            this.txtSampleType.TabIndex = 10;
            // 
            // lblSType
            // 
            this.lblSType.AutoSize = true;
            this.lblSType.Location = new System.Drawing.Point(13, 74);
            this.lblSType.Name = "lblSType";
            this.lblSType.Size = new System.Drawing.Size(69, 13);
            this.lblSType.TabIndex = 9;
            this.lblSType.Text = "Sample Type";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(340, 468);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 11;
            this.lblId.Text = "Id";
            // 
            // lblIdVal
            // 
            this.lblIdVal.AutoSize = true;
            this.lblIdVal.Location = new System.Drawing.Point(362, 468);
            this.lblIdVal.Name = "lblIdVal";
            this.lblIdVal.Size = new System.Drawing.Size(0, 13);
            this.lblIdVal.TabIndex = 12;
            // 
            // frmMatEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 452);
            this.Controls.Add(this.lblIdVal);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtSampleType);
            this.Controls.Add(this.lblSType);
            this.Controls.Add(this.rtbWSOutput);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvMat);
            this.Controls.Add(this.txtDescrip);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDescrip);
            this.Controls.Add(this.lblName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMatEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Edit Material";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescrip;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescrip;
        private System.Windows.Forms.DataGridView dgvMat;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.RichTextBox rtbWSOutput;
        private System.Windows.Forms.TextBox txtSampleType;
        private System.Windows.Forms.Label lblSType;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropVal;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblIdVal;
    }
}