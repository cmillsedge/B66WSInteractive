
namespace BR6WSInteractive
{
    partial class frmCatalog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatalog));
            this.trvCatalog = new System.Windows.Forms.TreeView();
            this.imgTree = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // trvCatalog
            // 
            this.trvCatalog.ImageIndex = 0;
            this.trvCatalog.ImageList = this.imgTree;
            this.trvCatalog.Location = new System.Drawing.Point(12, 48);
            this.trvCatalog.Name = "trvCatalog";
            this.trvCatalog.SelectedImageIndex = 0;
            this.trvCatalog.Size = new System.Drawing.Size(256, 624);
            this.trvCatalog.TabIndex = 0;
            // 
            // imgTree
            // 
            this.imgTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgTree.ImageStream")));
            this.imgTree.TransparentColor = System.Drawing.Color.Transparent;
            this.imgTree.Images.SetKeyName(0, "folder-icon.png");
            this.imgTree.Images.SetKeyName(1, "Field_16x.png");
            this.imgTree.Images.SetKeyName(2, "Dictionary_16x.png");
            // 
            // frmCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 708);
            this.Controls.Add(this.trvCatalog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCatalog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Catalog and Outlines";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView trvCatalog;
        private System.Windows.Forms.ImageList imgTree;
    }
}