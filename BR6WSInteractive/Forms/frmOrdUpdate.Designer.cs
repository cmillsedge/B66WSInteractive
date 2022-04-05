namespace BR6WSInteractive
{
    partial class frmOrdUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrdUpdate));
            this.lblOrderName = new System.Windows.Forms.Label();
            this.txtOrderName = new System.Windows.Forms.TextBox();
            this.btnGetOrder = new System.Windows.Forms.Button();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblMessages = new System.Windows.Forms.Label();
            this.rtbWSOutput = new System.Windows.Forms.RichTextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.btnOrdState = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrderName
            // 
            this.lblOrderName.AutoSize = true;
            this.lblOrderName.Location = new System.Drawing.Point(23, 23);
            this.lblOrderName.Name = "lblOrderName";
            this.lblOrderName.Size = new System.Drawing.Size(64, 13);
            this.lblOrderName.TabIndex = 0;
            this.lblOrderName.Text = "Order Name";
            // 
            // txtOrderName
            // 
            this.txtOrderName.Location = new System.Drawing.Point(107, 20);
            this.txtOrderName.Name = "txtOrderName";
            this.txtOrderName.Size = new System.Drawing.Size(187, 20);
            this.txtOrderName.TabIndex = 1;
            // 
            // btnGetOrder
            // 
            this.btnGetOrder.Location = new System.Drawing.Point(309, 18);
            this.btnGetOrder.Name = "btnGetOrder";
            this.btnGetOrder.Size = new System.Drawing.Size(110, 23);
            this.btnGetOrder.TabIndex = 2;
            this.btnGetOrder.Text = "Get Order";
            this.btnGetOrder.UseVisualStyleBackColor = true;
            this.btnGetOrder.Click += new System.EventHandler(this.BtnGetOrder_Click);
            // 
            // dgvOrder
            // 
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(26, 211);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.Size = new System.Drawing.Size(1032, 326);
            this.dgvOrder.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(931, 543);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(127, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update Order Items";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // lblMessages
            // 
            this.lblMessages.AutoSize = true;
            this.lblMessages.Location = new System.Drawing.Point(734, 18);
            this.lblMessages.Name = "lblMessages";
            this.lblMessages.Size = new System.Drawing.Size(39, 13);
            this.lblMessages.TabIndex = 94;
            this.lblMessages.Text = "Output";
            // 
            // rtbWSOutput
            // 
            this.rtbWSOutput.Location = new System.Drawing.Point(439, 34);
            this.rtbWSOutput.Name = "rtbWSOutput";
            this.rtbWSOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbWSOutput.Size = new System.Drawing.Size(620, 159);
            this.rtbWSOutput.TabIndex = 93;
            this.rtbWSOutput.Text = "";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(23, 64);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(61, 13);
            this.lblStatus.TabIndex = 95;
            this.lblStatus.Text = "Order State";
            // 
            // cmbState
            // 
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Location = new System.Drawing.Point(107, 64);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(187, 21);
            this.cmbState.TabIndex = 96;
            // 
            // btnOrdState
            // 
            this.btnOrdState.Location = new System.Drawing.Point(309, 64);
            this.btnOrdState.Name = "btnOrdState";
            this.btnOrdState.Size = new System.Drawing.Size(110, 23);
            this.btnOrdState.TabIndex = 97;
            this.btnOrdState.Text = "Update Order State";
            this.btnOrdState.UseVisualStyleBackColor = true;
            this.btnOrdState.Click += new System.EventHandler(this.btnOrdState_Click);
            // 
            // frmOrdUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 578);
            this.Controls.Add(this.btnOrdState);
            this.Controls.Add(this.cmbState);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblMessages);
            this.Controls.Add(this.rtbWSOutput);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.btnGetOrder);
            this.Controls.Add(this.txtOrderName);
            this.Controls.Add(this.lblOrderName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOrdUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Update Order";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrderName;
        private System.Windows.Forms.TextBox txtOrderName;
        private System.Windows.Forms.Button btnGetOrder;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblMessages;
        private System.Windows.Forms.RichTextBox rtbWSOutput;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.Button btnOrdState;
    }
}