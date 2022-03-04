
namespace BR6WSInteractive
{
    partial class frmTaskImport
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaskImport));
            this.trvOutlines = new System.Windows.Forms.TreeView();
            this.imgTreeImages = new System.Windows.Forms.ImageList(this.components);
            this.lblProcesses = new System.Windows.Forms.Label();
            this.btnDispParams = new System.Windows.Forms.Button();
            this.lblParams = new System.Windows.Forms.Label();
            this.lblFile = new System.Windows.Forms.Label();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.lstvParams = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstvFile = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // trvOutlines
            // 
            this.trvOutlines.ImageIndex = 0;
            this.trvOutlines.ImageList = this.imgTreeImages;
            this.trvOutlines.Location = new System.Drawing.Point(13, 33);
            this.trvOutlines.Name = "trvOutlines";
            this.trvOutlines.SelectedImageIndex = 2;
            this.trvOutlines.Size = new System.Drawing.Size(242, 472);
            this.trvOutlines.TabIndex = 0;
            // 
            // imgTreeImages
            // 
            this.imgTreeImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgTreeImages.ImageStream")));
            this.imgTreeImages.TransparentColor = System.Drawing.Color.Transparent;
            this.imgTreeImages.Images.SetKeyName(0, "outline.png");
            this.imgTreeImages.Images.SetKeyName(1, "process_version.png");
            this.imgTreeImages.Images.SetKeyName(2, "tick.png");
            // 
            // lblProcesses
            // 
            this.lblProcesses.AutoSize = true;
            this.lblProcesses.Location = new System.Drawing.Point(13, 14);
            this.lblProcesses.Name = "lblProcesses";
            this.lblProcesses.Size = new System.Drawing.Size(56, 13);
            this.lblProcesses.TabIndex = 1;
            this.lblProcesses.Text = "Processes";
            // 
            // btnDispParams
            // 
            this.btnDispParams.Location = new System.Drawing.Point(283, 511);
            this.btnDispParams.Name = "btnDispParams";
            this.btnDispParams.Size = new System.Drawing.Size(75, 36);
            this.btnDispParams.TabIndex = 2;
            this.btnDispParams.Text = "Display Params";
            this.btnDispParams.UseVisualStyleBackColor = true;
            this.btnDispParams.Click += new System.EventHandler(this.btnDispParams_Click);
            // 
            // lblParams
            // 
            this.lblParams.AutoSize = true;
            this.lblParams.Location = new System.Drawing.Point(280, 14);
            this.lblParams.Name = "lblParams";
            this.lblParams.Size = new System.Drawing.Size(106, 13);
            this.lblParams.TabIndex = 5;
            this.lblParams.Text = "Available Parameters";
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(485, 14);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(93, 13);
            this.lblFile.TabIndex = 7;
            this.lblFile.Text = "Available Headers";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(488, 511);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(75, 36);
            this.btnSelectFile.TabIndex = 8;
            this.btnSelectFile.Text = "Select File";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // lstvParams
            // 
            this.lstvParams.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstvParams.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstvParams.HideSelection = false;
            this.lstvParams.Location = new System.Drawing.Point(283, 33);
            this.lstvParams.Name = "lstvParams";
            this.lstvParams.Size = new System.Drawing.Size(185, 472);
            this.lstvParams.TabIndex = 9;
            this.lstvParams.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Parameter";
            // 
            // lstvFile
            // 
            this.lstvFile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.lstvFile.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstvFile.HideSelection = false;
            this.lstvFile.Location = new System.Drawing.Point(488, 30);
            this.lstvFile.Name = "lstvFile";
            this.lstvFile.Size = new System.Drawing.Size(185, 472);
            this.lstvFile.TabIndex = 10;
            this.lstvFile.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Headers";
            // 
            // frmTaskImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 573);
            this.Controls.Add(this.lstvFile);
            this.Controls.Add(this.lstvParams);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.lblParams);
            this.Controls.Add(this.btnDispParams);
            this.Controls.Add(this.lblProcesses);
            this.Controls.Add(this.trvOutlines);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTaskImport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Task Importer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView trvOutlines;
        private System.Windows.Forms.ImageList imgTreeImages;
        private System.Windows.Forms.Label lblProcesses;
        private System.Windows.Forms.Button btnDispParams;
        private System.Windows.Forms.Label lblParams;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.ListView lstvParams;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView lstvFile;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}