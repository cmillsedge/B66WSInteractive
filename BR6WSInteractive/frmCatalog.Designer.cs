
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
            this.lblCatalog = new System.Windows.Forms.Label();
            this.lblParams = new System.Windows.Forms.Label();
            this.lblOutline = new System.Windows.Forms.Label();
            this.cmbOutlines = new System.Windows.Forms.ComboBox();
            this.dgvParams = new System.Windows.Forms.DataGridView();
            this.ParameterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lookup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParams)).BeginInit();
            this.SuspendLayout();
            // 
            // trvCatalog
            // 
            this.trvCatalog.ImageIndex = 0;
            this.trvCatalog.ImageList = this.imgTree;
            this.trvCatalog.Location = new System.Drawing.Point(12, 74);
            this.trvCatalog.Name = "trvCatalog";
            this.trvCatalog.SelectedImageIndex = 0;
            this.trvCatalog.Size = new System.Drawing.Size(256, 622);
            this.trvCatalog.TabIndex = 0;
            this.trvCatalog.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.trvCatalog_ItemDrag);
            // 
            // imgTree
            // 
            this.imgTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgTree.ImageStream")));
            this.imgTree.TransparentColor = System.Drawing.Color.Transparent;
            this.imgTree.Images.SetKeyName(0, "folder-icon.png");
            this.imgTree.Images.SetKeyName(1, "Field_16x.png");
            this.imgTree.Images.SetKeyName(2, "Dictionary_16x.png");
            // 
            // lblCatalog
            // 
            this.lblCatalog.AutoSize = true;
            this.lblCatalog.Location = new System.Drawing.Point(12, 58);
            this.lblCatalog.Name = "lblCatalog";
            this.lblCatalog.Size = new System.Drawing.Size(43, 13);
            this.lblCatalog.TabIndex = 2;
            this.lblCatalog.Text = "Catalog";
            // 
            // lblParams
            // 
            this.lblParams.AutoSize = true;
            this.lblParams.Location = new System.Drawing.Point(340, 58);
            this.lblParams.Name = "lblParams";
            this.lblParams.Size = new System.Drawing.Size(96, 13);
            this.lblParams.TabIndex = 3;
            this.lblParams.Text = "Outline Parameters";
            // 
            // lblOutline
            // 
            this.lblOutline.AutoSize = true;
            this.lblOutline.Location = new System.Drawing.Point(340, 27);
            this.lblOutline.Name = "lblOutline";
            this.lblOutline.Size = new System.Drawing.Size(88, 13);
            this.lblOutline.TabIndex = 4;
            this.lblOutline.Text = "Select an Outline";
            // 
            // cmbOutlines
            // 
            this.cmbOutlines.FormattingEnabled = true;
            this.cmbOutlines.Location = new System.Drawing.Point(448, 19);
            this.cmbOutlines.Name = "cmbOutlines";
            this.cmbOutlines.Size = new System.Drawing.Size(240, 21);
            this.cmbOutlines.TabIndex = 5;
            this.cmbOutlines.SelectedIndexChanged += new System.EventHandler(this.cmbOutlines_SelectedIndexChanged);
            // 
            // dgvParams
            // 
            this.dgvParams.AllowDrop = true;
            this.dgvParams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ParameterName,
            this.Description,
            this.Role,
            this.DataType,
            this.Lookup,
            this.Unit});
            this.dgvParams.Location = new System.Drawing.Point(343, 74);
            this.dgvParams.Name = "dgvParams";
            this.dgvParams.Size = new System.Drawing.Size(863, 622);
            this.dgvParams.TabIndex = 6;
            this.dgvParams.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvParams_DragDrop);
            this.dgvParams.DragEnter += new System.Windows.Forms.DragEventHandler(this.dgvParams_DragEnter);
            // 
            // ParameterName
            // 
            this.ParameterName.HeaderText = "ParameterName";
            this.ParameterName.Name = "ParameterName";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // Role
            // 
            this.Role.HeaderText = "Role";
            this.Role.Name = "Role";
            // 
            // DataType
            // 
            this.DataType.HeaderText = "Data Type";
            this.DataType.Name = "DataType";
            // 
            // Lookup
            // 
            this.Lookup.HeaderText = "Lookup";
            this.Lookup.Name = "Lookup";
            // 
            // Unit
            // 
            this.Unit.HeaderText = "Unit";
            this.Unit.Name = "Unit";
            // 
            // frmCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 708);
            this.Controls.Add(this.dgvParams);
            this.Controls.Add(this.cmbOutlines);
            this.Controls.Add(this.lblOutline);
            this.Controls.Add(this.lblParams);
            this.Controls.Add(this.lblCatalog);
            this.Controls.Add(this.trvCatalog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCatalog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Catalog and Outlines";
            ((System.ComponentModel.ISupportInitialize)(this.dgvParams)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView trvCatalog;
        private System.Windows.Forms.ImageList imgTree;
        private System.Windows.Forms.Label lblCatalog;
        private System.Windows.Forms.Label lblParams;
        private System.Windows.Forms.Label lblOutline;
        private System.Windows.Forms.ComboBox cmbOutlines;
        private System.Windows.Forms.DataGridView dgvParams;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParameterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lookup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
    }
}