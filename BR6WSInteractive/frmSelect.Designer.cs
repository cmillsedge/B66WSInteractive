
namespace BR6WSInteractive
{
    partial class frmSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelect));
            this.btnCatalog = new System.Windows.Forms.Button();
            this.lblCatalog = new System.Windows.Forms.Label();
            this.lblTasks = new System.Windows.Forms.Label();
            this.btnTasks = new System.Windows.Forms.Button();
            this.btnQueries = new System.Windows.Forms.Button();
            this.lblQueries = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCatalog
            // 
            this.btnCatalog.Image = ((System.Drawing.Image)(resources.GetObject("btnCatalog.Image")));
            this.btnCatalog.Location = new System.Drawing.Point(42, 36);
            this.btnCatalog.Name = "btnCatalog";
            this.btnCatalog.Size = new System.Drawing.Size(63, 57);
            this.btnCatalog.TabIndex = 0;
            this.btnCatalog.UseVisualStyleBackColor = true;
            this.btnCatalog.Click += new System.EventHandler(this.btnCatalog_Click);
            // 
            // lblCatalog
            // 
            this.lblCatalog.AutoSize = true;
            this.lblCatalog.Location = new System.Drawing.Point(21, 16);
            this.lblCatalog.Name = "lblCatalog";
            this.lblCatalog.Size = new System.Drawing.Size(105, 13);
            this.lblCatalog.TabIndex = 1;
            this.lblCatalog.Text = "Catalog and Outlines";
            // 
            // lblTasks
            // 
            this.lblTasks.AutoSize = true;
            this.lblTasks.Location = new System.Drawing.Point(184, 16);
            this.lblTasks.Name = "lblTasks";
            this.lblTasks.Size = new System.Drawing.Size(36, 13);
            this.lblTasks.TabIndex = 3;
            this.lblTasks.Text = "Tasks";
            // 
            // btnTasks
            // 
            this.btnTasks.Image = ((System.Drawing.Image)(resources.GetObject("btnTasks.Image")));
            this.btnTasks.Location = new System.Drawing.Point(170, 36);
            this.btnTasks.Name = "btnTasks";
            this.btnTasks.Size = new System.Drawing.Size(63, 57);
            this.btnTasks.TabIndex = 2;
            this.btnTasks.UseVisualStyleBackColor = true;
            this.btnTasks.Click += new System.EventHandler(this.btnTasks_Click);
            // 
            // btnQueries
            // 
            this.btnQueries.Image = ((System.Drawing.Image)(resources.GetObject("btnQueries.Image")));
            this.btnQueries.Location = new System.Drawing.Point(290, 36);
            this.btnQueries.Name = "btnQueries";
            this.btnQueries.Size = new System.Drawing.Size(63, 57);
            this.btnQueries.TabIndex = 4;
            this.btnQueries.UseVisualStyleBackColor = true;
            this.btnQueries.Click += new System.EventHandler(this.btnQueries_Click);
            // 
            // lblQueries
            // 
            this.lblQueries.AutoSize = true;
            this.lblQueries.Location = new System.Drawing.Point(303, 16);
            this.lblQueries.Name = "lblQueries";
            this.lblQueries.Size = new System.Drawing.Size(43, 13);
            this.lblQueries.TabIndex = 5;
            this.lblQueries.Text = "Queries";
            // 
            // frmSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 120);
            this.Controls.Add(this.lblQueries);
            this.Controls.Add(this.btnQueries);
            this.Controls.Add(this.lblTasks);
            this.Controls.Add(this.btnTasks);
            this.Controls.Add(this.lblCatalog);
            this.Controls.Add(this.btnCatalog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Functionality Selector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCatalog;
        private System.Windows.Forms.Label lblCatalog;
        private System.Windows.Forms.Label lblTasks;
        private System.Windows.Forms.Button btnTasks;
        private System.Windows.Forms.Button btnQueries;
        private System.Windows.Forms.Label lblQueries;
    }
}