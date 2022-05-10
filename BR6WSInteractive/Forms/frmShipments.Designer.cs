namespace BR6WSInteractive
{
    partial class frmShipments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShipments));
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnReceipt = new System.Windows.Forms.Button();
            this.lblMessages = new System.Windows.Forms.Label();
            this.rtbWSOutput = new System.Windows.Forms.RichTextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.cmbOrderSystem = new System.Windows.Forms.ComboBox();
            this.lblSystem = new System.Windows.Forms.Label();
            this.cmbLayout = new System.Windows.Forms.ComboBox();
            this.lblLayout = new System.Windows.Forms.Label();
            this.btnDispatch = new System.Windows.Forms.Button();
            this.btnReceive = new System.Windows.Forms.Button();
            this.lblItems = new System.Windows.Forms.Label();
            this.lstContainers = new System.Windows.Forms.ListBox();
            this.btnPaste = new System.Windows.Forms.Button();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(12, 12);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(105, 28);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Test Dispatch";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnReceipt
            // 
            this.btnReceipt.Location = new System.Drawing.Point(123, 12);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(105, 28);
            this.btnReceipt.TabIndex = 1;
            this.btnReceipt.Text = "Test Receipt";
            this.btnReceipt.UseVisualStyleBackColor = true;
            this.btnReceipt.Click += new System.EventHandler(this.btnReceipt_Click);
            // 
            // lblMessages
            // 
            this.lblMessages.AutoSize = true;
            this.lblMessages.Location = new System.Drawing.Point(557, 50);
            this.lblMessages.Name = "lblMessages";
            this.lblMessages.Size = new System.Drawing.Size(39, 13);
            this.lblMessages.TabIndex = 96;
            this.lblMessages.Text = "Output";
            // 
            // rtbWSOutput
            // 
            this.rtbWSOutput.Location = new System.Drawing.Point(427, 66);
            this.rtbWSOutput.Name = "rtbWSOutput";
            this.rtbWSOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbWSOutput.Size = new System.Drawing.Size(297, 493);
            this.rtbWSOutput.TabIndex = 95;
            this.rtbWSOutput.Text = "";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(21, 69);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(81, 13);
            this.lblName.TabIndex = 97;
            this.lblName.Text = "Transport Label";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(123, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(271, 20);
            this.txtName.TabIndex = 98;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(21, 103);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(48, 13);
            this.lblLocation.TabIndex = 99;
            this.lblLocation.Text = "Location";
            // 
            // cmbOrderSystem
            // 
            this.cmbOrderSystem.FormattingEnabled = true;
            this.cmbOrderSystem.Location = new System.Drawing.Point(123, 137);
            this.cmbOrderSystem.Name = "cmbOrderSystem";
            this.cmbOrderSystem.Size = new System.Drawing.Size(271, 21);
            this.cmbOrderSystem.TabIndex = 102;
            // 
            // lblSystem
            // 
            this.lblSystem.AutoSize = true;
            this.lblSystem.Location = new System.Drawing.Point(21, 140);
            this.lblSystem.Name = "lblSystem";
            this.lblSystem.Size = new System.Drawing.Size(67, 13);
            this.lblSystem.TabIndex = 101;
            this.lblSystem.Text = "OrderSystem";
            // 
            // cmbLayout
            // 
            this.cmbLayout.FormattingEnabled = true;
            this.cmbLayout.Location = new System.Drawing.Point(123, 174);
            this.cmbLayout.Name = "cmbLayout";
            this.cmbLayout.Size = new System.Drawing.Size(271, 21);
            this.cmbLayout.TabIndex = 104;
            // 
            // lblLayout
            // 
            this.lblLayout.AutoSize = true;
            this.lblLayout.Location = new System.Drawing.Point(21, 177);
            this.lblLayout.Name = "lblLayout";
            this.lblLayout.Size = new System.Drawing.Size(39, 13);
            this.lblLayout.TabIndex = 103;
            this.lblLayout.Text = "Layout";
            // 
            // btnDispatch
            // 
            this.btnDispatch.Location = new System.Drawing.Point(427, 567);
            this.btnDispatch.Name = "btnDispatch";
            this.btnDispatch.Size = new System.Drawing.Size(127, 28);
            this.btnDispatch.TabIndex = 105;
            this.btnDispatch.Text = "Create Shipment";
            this.btnDispatch.UseVisualStyleBackColor = true;
            this.btnDispatch.Click += new System.EventHandler(this.btnDispatch_Click);
            // 
            // btnReceive
            // 
            this.btnReceive.Location = new System.Drawing.Point(598, 567);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(126, 28);
            this.btnReceive.TabIndex = 106;
            this.btnReceive.Text = "Receive Containers";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Location = new System.Drawing.Point(21, 216);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(32, 13);
            this.lblItems.TabIndex = 107;
            this.lblItems.Text = "Items";
            // 
            // lstContainers
            // 
            this.lstContainers.FormattingEnabled = true;
            this.lstContainers.Location = new System.Drawing.Point(123, 216);
            this.lstContainers.Name = "lstContainers";
            this.lstContainers.Size = new System.Drawing.Size(271, 381);
            this.lstContainers.TabIndex = 108;
            // 
            // btnPaste
            // 
            this.btnPaste.Location = new System.Drawing.Point(24, 251);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(64, 28);
            this.btnPaste.TabIndex = 109;
            this.btnPaste.Text = "Paste";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(123, 100);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(271, 20);
            this.txtLocation.TabIndex = 110;
            // 
            // frmShipments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 622);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.btnPaste);
            this.Controls.Add(this.lstContainers);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.btnDispatch);
            this.Controls.Add(this.cmbLayout);
            this.Controls.Add(this.lblLayout);
            this.Controls.Add(this.cmbOrderSystem);
            this.Controls.Add(this.lblSystem);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblMessages);
            this.Controls.Add(this.rtbWSOutput);
            this.Controls.Add(this.btnReceipt);
            this.Controls.Add(this.btnCreate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmShipments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Shipments";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnReceipt;
        private System.Windows.Forms.Label lblMessages;
        private System.Windows.Forms.RichTextBox rtbWSOutput;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.ComboBox cmbOrderSystem;
        private System.Windows.Forms.Label lblSystem;
        private System.Windows.Forms.ComboBox cmbLayout;
        private System.Windows.Forms.Label lblLayout;
        private System.Windows.Forms.Button btnDispatch;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.ListBox lstContainers;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.TextBox txtLocation;
    }
}