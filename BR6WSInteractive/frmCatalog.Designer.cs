
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
            this.imgTree = new System.Windows.Forms.ImageList(this.components);
            this.lblOutline = new System.Windows.Forms.Label();
            this.cmbOutlines = new System.Windows.Forms.ComboBox();
            this.lblInstruc2 = new System.Windows.Forms.Label();
            this.grpInstructions = new System.Windows.Forms.GroupBox();
            this.grpParams = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblFilter = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvParams = new System.Windows.Forms.DataGridView();
            this.ParameterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lookup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblParams = new System.Windows.Forms.Label();
            this.lblCatalog = new System.Windows.Forms.Label();
            this.trvCatalog = new System.Windows.Forms.TreeView();
            this.grpInstructions.SuspendLayout();
            this.grpParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParams)).BeginInit();
            this.SuspendLayout();
            // 
            // imgTree
            // 
            this.imgTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgTree.ImageStream")));
            this.imgTree.TransparentColor = System.Drawing.Color.Transparent;
            this.imgTree.Images.SetKeyName(0, "folder-icon.png");
            this.imgTree.Images.SetKeyName(1, "Field_16x.png");
            this.imgTree.Images.SetKeyName(2, "Dictionary_16x.png");
            // 
            // lblOutline
            // 
            this.lblOutline.AutoSize = true;
            this.lblOutline.Location = new System.Drawing.Point(6, 30);
            this.lblOutline.Name = "lblOutline";
            this.lblOutline.Size = new System.Drawing.Size(100, 13);
            this.lblOutline.TabIndex = 4;
            this.lblOutline.Text = "1. Select an Outline";
            // 
            // cmbOutlines
            // 
            this.cmbOutlines.FormattingEnabled = true;
            this.cmbOutlines.Location = new System.Drawing.Point(122, 23);
            this.cmbOutlines.Name = "cmbOutlines";
            this.cmbOutlines.Size = new System.Drawing.Size(213, 21);
            this.cmbOutlines.TabIndex = 5;
            this.cmbOutlines.SelectedIndexChanged += new System.EventHandler(this.cmbOutlines_SelectedIndexChanged);
            // 
            // lblInstruc2
            // 
            this.lblInstruc2.AutoSize = true;
            this.lblInstruc2.Location = new System.Drawing.Point(6, 60);
            this.lblInstruc2.Name = "lblInstruc2";
            this.lblInstruc2.Size = new System.Drawing.Size(312, 13);
            this.lblInstruc2.TabIndex = 7;
            this.lblInstruc2.Text = "2. To add a parameter to an outline drag from the tree to the grid.";
            // 
            // grpInstructions
            // 
            this.grpInstructions.Controls.Add(this.lblInstruc2);
            this.grpInstructions.Controls.Add(this.lblOutline);
            this.grpInstructions.Controls.Add(this.cmbOutlines);
            this.grpInstructions.Location = new System.Drawing.Point(15, 13);
            this.grpInstructions.Name = "grpInstructions";
            this.grpInstructions.Size = new System.Drawing.Size(1204, 100);
            this.grpInstructions.TabIndex = 11;
            this.grpInstructions.TabStop = false;
            this.grpInstructions.Text = "Instructions";
            // 
            // grpParams
            // 
            this.grpParams.Controls.Add(this.btnFilter);
            this.grpParams.Controls.Add(this.lblFilter);
            this.grpParams.Controls.Add(this.textBox1);
            this.grpParams.Controls.Add(this.dgvParams);
            this.grpParams.Controls.Add(this.lblParams);
            this.grpParams.Controls.Add(this.lblCatalog);
            this.grpParams.Controls.Add(this.trvCatalog);
            this.grpParams.Location = new System.Drawing.Point(15, 119);
            this.grpParams.Name = "grpParams";
            this.grpParams.Size = new System.Drawing.Size(1204, 623);
            this.grpParams.TabIndex = 12;
            this.grpParams.TabStop = false;
            this.grpParams.Text = "Add Outline Parameters";
            // 
            // btnFilter
            // 
            this.btnFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnFilter.Image")));
            this.btnFilter.Location = new System.Drawing.Point(249, 40);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(38, 20);
            this.btnFilter.TabIndex = 17;
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(34, 21);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(84, 13);
            this.lblFilter.TabIndex = 16;
            this.lblFilter.Text = "Tree Filter Value";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 20);
            this.textBox1.TabIndex = 15;
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
            this.dgvParams.Location = new System.Drawing.Point(310, 95);
            this.dgvParams.Name = "dgvParams";
            this.dgvParams.Size = new System.Drawing.Size(863, 506);
            this.dgvParams.TabIndex = 14;
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
            // lblParams
            // 
            this.lblParams.AutoSize = true;
            this.lblParams.Location = new System.Drawing.Point(307, 79);
            this.lblParams.Name = "lblParams";
            this.lblParams.Size = new System.Drawing.Size(96, 13);
            this.lblParams.TabIndex = 13;
            this.lblParams.Text = "Outline Parameters";
            // 
            // lblCatalog
            // 
            this.lblCatalog.AutoSize = true;
            this.lblCatalog.Location = new System.Drawing.Point(31, 79);
            this.lblCatalog.Name = "lblCatalog";
            this.lblCatalog.Size = new System.Drawing.Size(43, 13);
            this.lblCatalog.TabIndex = 12;
            this.lblCatalog.Text = "Catalog";
            // 
            // trvCatalog
            // 
            this.trvCatalog.ImageIndex = 0;
            this.trvCatalog.ImageList = this.imgTree;
            this.trvCatalog.Location = new System.Drawing.Point(31, 95);
            this.trvCatalog.Name = "trvCatalog";
            this.trvCatalog.SelectedImageIndex = 0;
            this.trvCatalog.Size = new System.Drawing.Size(256, 506);
            this.trvCatalog.TabIndex = 11;
            this.trvCatalog.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.trvCatalog_ItemDrag);
            // 
            // frmCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 760);
            this.Controls.Add(this.grpParams);
            this.Controls.Add(this.grpInstructions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCatalog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Catalog and Outlines";
            this.grpInstructions.ResumeLayout(false);
            this.grpInstructions.PerformLayout();
            this.grpParams.ResumeLayout(false);
            this.grpParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParams)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imgTree;
        private System.Windows.Forms.Label lblOutline;
        private System.Windows.Forms.ComboBox cmbOutlines;
        private System.Windows.Forms.Label lblInstruc2;
        private System.Windows.Forms.GroupBox grpInstructions;
        private System.Windows.Forms.GroupBox grpParams;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvParams;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParameterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lookup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.Label lblParams;
        private System.Windows.Forms.Label lblCatalog;
        private System.Windows.Forms.TreeView trvCatalog;
    }
}