namespace BR6WSInteractive
{
    partial class frmWatson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWatson));
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblTubeName = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.rtbWSOutput = new System.Windows.Forms.RichTextBox();
            this.lblNames = new System.Windows.Forms.Label();
            this.lstWatson = new System.Windows.Forms.ListBox();
            this.btnWatson1 = new System.Windows.Forms.Button();
            this.btnWatsonMany = new System.Windows.Forms.Button();
            this.btnPaste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(131, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(226, 20);
            this.txtName.TabIndex = 12;
            // 
            // lblTubeName
            // 
            this.lblTubeName.AutoSize = true;
            this.lblTubeName.Location = new System.Drawing.Point(22, 28);
            this.lblTubeName.Name = "lblTubeName";
            this.lblTubeName.Size = new System.Drawing.Size(35, 13);
            this.lblTubeName.TabIndex = 12;
            this.lblTubeName.Text = "Name";
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
            // lblNames
            // 
            this.lblNames.AutoSize = true;
            this.lblNames.Location = new System.Drawing.Point(22, 158);
            this.lblNames.Name = "lblNames";
            this.lblNames.Size = new System.Drawing.Size(40, 13);
            this.lblNames.TabIndex = 45;
            this.lblNames.Text = "Names";
            // 
            // lstWatson
            // 
            this.lstWatson.FormattingEnabled = true;
            this.lstWatson.Location = new System.Drawing.Point(131, 158);
            this.lstWatson.Name = "lstWatson";
            this.lstWatson.Size = new System.Drawing.Size(226, 446);
            this.lstWatson.TabIndex = 46;
            // 
            // btnWatson1
            // 
            this.btnWatson1.Location = new System.Drawing.Point(382, 21);
            this.btnWatson1.Name = "btnWatson1";
            this.btnWatson1.Size = new System.Drawing.Size(75, 23);
            this.btnWatson1.TabIndex = 47;
            this.btnWatson1.Text = "Import 1";
            this.btnWatson1.UseVisualStyleBackColor = true;
            this.btnWatson1.Click += new System.EventHandler(this.BtnWatson1_Click);
            // 
            // btnWatsonMany
            // 
            this.btnWatsonMany.Location = new System.Drawing.Point(382, 187);
            this.btnWatsonMany.Name = "btnWatsonMany";
            this.btnWatsonMany.Size = new System.Drawing.Size(75, 23);
            this.btnWatsonMany.TabIndex = 48;
            this.btnWatsonMany.Text = "Import Many";
            this.btnWatsonMany.UseVisualStyleBackColor = true;
            this.btnWatsonMany.Click += new System.EventHandler(this.BtnWatsonMany_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.Location = new System.Drawing.Point(382, 158);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(75, 23);
            this.btnPaste.TabIndex = 49;
            this.btnPaste.Text = "Paste";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.BtnPaste_Click);
            // 
            // frmWatson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 779);
            this.Controls.Add(this.btnPaste);
            this.Controls.Add(this.btnWatsonMany);
            this.Controls.Add(this.btnWatson1);
            this.Controls.Add(this.lstWatson);
            this.Controls.Add(this.lblNames);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.rtbWSOutput);
            this.Controls.Add(this.lblTubeName);
            this.Controls.Add(this.txtName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmWatson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Watson Integration Tester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblTubeName;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.RichTextBox rtbWSOutput;
        private System.Windows.Forms.Label lblNames;
        private System.Windows.Forms.ListBox lstWatson;
        private System.Windows.Forms.Button btnWatson1;
        private System.Windows.Forms.Button btnWatsonMany;
        private System.Windows.Forms.Button btnPaste;
    }
}