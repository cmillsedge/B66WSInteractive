
namespace BR6WSInteractive
{
    partial class frmQueries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQueries));
            this.lblFilter = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnGetQueries = new System.Windows.Forms.Button();
            this.lblMatchQueries = new System.Windows.Forms.Label();
            this.cmbQueries = new System.Windows.Forms.ComboBox();
            this.btnRunQuery = new System.Windows.Forms.Button();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.lblPage = new System.Windows.Forms.Label();
            this.cmbPage = new System.Windows.Forms.ComboBox();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnPrevPage = new System.Windows.Forms.Button();
            this.lblPageNumLab = new System.Windows.Forms.Label();
            this.lblPageNumVal = new System.Windows.Forms.Label();
            this.lblFilterCol1 = new System.Windows.Forms.Label();
            this.lblFilterCol2 = new System.Windows.Forms.Label();
            this.cmbCols1 = new System.Windows.Forms.ComboBox();
            this.cmbCols2 = new System.Windows.Forms.ComboBox();
            this.cmbOps1 = new System.Windows.Forms.ComboBox();
            this.lblOp1 = new System.Windows.Forms.Label();
            this.cmbOps2 = new System.Windows.Forms.ComboBox();
            this.lblOp2 = new System.Windows.Forms.Label();
            this.rtbVals1 = new System.Windows.Forms.RichTextBox();
            this.lblVals1 = new System.Windows.Forms.Label();
            this.lblVals2 = new System.Windows.Forms.Label();
            this.rtbVals2 = new System.Windows.Forms.RichTextBox();
            this.btnFilterQuery = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(12, 24);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(110, 13);
            this.lblFilter.TabIndex = 0;
            this.lblFilter.Text = "Query Name Contains";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(124, 21);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(215, 20);
            this.txtFilter.TabIndex = 1;
            this.txtFilter.Text = "container";
            // 
            // btnGetQueries
            // 
            this.btnGetQueries.Location = new System.Drawing.Point(358, 19);
            this.btnGetQueries.Name = "btnGetQueries";
            this.btnGetQueries.Size = new System.Drawing.Size(149, 23);
            this.btnGetQueries.TabIndex = 2;
            this.btnGetQueries.Text = "Get Matching Queries";
            this.btnGetQueries.UseVisualStyleBackColor = true;
            this.btnGetQueries.Click += new System.EventHandler(this.btnGetQueries_Click);
            // 
            // lblMatchQueries
            // 
            this.lblMatchQueries.AutoSize = true;
            this.lblMatchQueries.Location = new System.Drawing.Point(12, 61);
            this.lblMatchQueries.Name = "lblMatchQueries";
            this.lblMatchQueries.Size = new System.Drawing.Size(90, 13);
            this.lblMatchQueries.TabIndex = 3;
            this.lblMatchQueries.Text = "Matching Queries";
            // 
            // cmbQueries
            // 
            this.cmbQueries.FormattingEnabled = true;
            this.cmbQueries.Location = new System.Drawing.Point(124, 61);
            this.cmbQueries.Name = "cmbQueries";
            this.cmbQueries.Size = new System.Drawing.Size(215, 21);
            this.cmbQueries.TabIndex = 4;
            // 
            // btnRunQuery
            // 
            this.btnRunQuery.Location = new System.Drawing.Point(971, 120);
            this.btnRunQuery.Name = "btnRunQuery";
            this.btnRunQuery.Size = new System.Drawing.Size(149, 23);
            this.btnRunQuery.TabIndex = 5;
            this.btnRunQuery.Text = "Run Selected Query";
            this.btnRunQuery.UseVisualStyleBackColor = true;
            this.btnRunQuery.Click += new System.EventHandler(this.btnRunQuery_Click);
            // 
            // dgvResults
            // 
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(15, 149);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.Size = new System.Drawing.Size(1105, 345);
            this.dgvResults.TabIndex = 6;
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Location = new System.Drawing.Point(12, 98);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(55, 13);
            this.lblPage.TabIndex = 7;
            this.lblPage.Text = "Page Size";
            // 
            // cmbPage
            // 
            this.cmbPage.FormattingEnabled = true;
            this.cmbPage.Items.AddRange(new object[] {
            "25",
            "50",
            "100",
            "200",
            "500",
            "1000"});
            this.cmbPage.Location = new System.Drawing.Point(124, 95);
            this.cmbPage.Name = "cmbPage";
            this.cmbPage.Size = new System.Drawing.Size(215, 21);
            this.cmbPage.TabIndex = 8;
            this.cmbPage.Text = "50";
            // 
            // btnNextPage
            // 
            this.btnNextPage.Location = new System.Drawing.Point(971, 500);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(149, 23);
            this.btnNextPage.TabIndex = 9;
            this.btnNextPage.Text = "Next Page";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.Location = new System.Drawing.Point(15, 500);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(149, 23);
            this.btnPrevPage.TabIndex = 10;
            this.btnPrevPage.Text = "Previous Page";
            this.btnPrevPage.UseVisualStyleBackColor = true;
            this.btnPrevPage.Click += new System.EventHandler(this.btnPrevPage_Click);
            // 
            // lblPageNumLab
            // 
            this.lblPageNumLab.AutoSize = true;
            this.lblPageNumLab.Location = new System.Drawing.Point(518, 510);
            this.lblPageNumLab.Name = "lblPageNumLab";
            this.lblPageNumLab.Size = new System.Drawing.Size(75, 13);
            this.lblPageNumLab.TabIndex = 11;
            this.lblPageNumLab.Text = "Page Number:";
            // 
            // lblPageNumVal
            // 
            this.lblPageNumVal.AutoSize = true;
            this.lblPageNumVal.Location = new System.Drawing.Point(596, 510);
            this.lblPageNumVal.Name = "lblPageNumVal";
            this.lblPageNumVal.Size = new System.Drawing.Size(13, 13);
            this.lblPageNumVal.TabIndex = 12;
            this.lblPageNumVal.Text = "1";
            // 
            // lblFilterCol1
            // 
            this.lblFilterCol1.AutoSize = true;
            this.lblFilterCol1.Location = new System.Drawing.Point(26, 563);
            this.lblFilterCol1.Name = "lblFilterCol1";
            this.lblFilterCol1.Size = new System.Drawing.Size(76, 13);
            this.lblFilterCol1.TabIndex = 13;
            this.lblFilterCol1.Text = "Filter Column 1";
            // 
            // lblFilterCol2
            // 
            this.lblFilterCol2.AutoSize = true;
            this.lblFilterCol2.Location = new System.Drawing.Point(26, 600);
            this.lblFilterCol2.Name = "lblFilterCol2";
            this.lblFilterCol2.Size = new System.Drawing.Size(76, 13);
            this.lblFilterCol2.TabIndex = 14;
            this.lblFilterCol2.Text = "Filter Column 2";
            // 
            // cmbCols1
            // 
            this.cmbCols1.FormattingEnabled = true;
            this.cmbCols1.Location = new System.Drawing.Point(119, 559);
            this.cmbCols1.Name = "cmbCols1";
            this.cmbCols1.Size = new System.Drawing.Size(156, 21);
            this.cmbCols1.TabIndex = 15;
            // 
            // cmbCols2
            // 
            this.cmbCols2.FormattingEnabled = true;
            this.cmbCols2.Location = new System.Drawing.Point(119, 597);
            this.cmbCols2.Name = "cmbCols2";
            this.cmbCols2.Size = new System.Drawing.Size(156, 21);
            this.cmbCols2.TabIndex = 16;
            // 
            // cmbOps1
            // 
            this.cmbOps1.FormattingEnabled = true;
            this.cmbOps1.Items.AddRange(new object[] {
            "LIKE",
            "IN",
            ">"});
            this.cmbOps1.Location = new System.Drawing.Point(389, 559);
            this.cmbOps1.Name = "cmbOps1";
            this.cmbOps1.Size = new System.Drawing.Size(156, 21);
            this.cmbOps1.TabIndex = 18;
            // 
            // lblOp1
            // 
            this.lblOp1.AutoSize = true;
            this.lblOp1.Location = new System.Drawing.Point(296, 563);
            this.lblOp1.Name = "lblOp1";
            this.lblOp1.Size = new System.Drawing.Size(48, 13);
            this.lblOp1.TabIndex = 17;
            this.lblOp1.Text = "Operator";
            // 
            // cmbOps2
            // 
            this.cmbOps2.FormattingEnabled = true;
            this.cmbOps2.Items.AddRange(new object[] {
            "LIKE",
            "IN",
            ">"});
            this.cmbOps2.Location = new System.Drawing.Point(389, 596);
            this.cmbOps2.Name = "cmbOps2";
            this.cmbOps2.Size = new System.Drawing.Size(156, 21);
            this.cmbOps2.TabIndex = 20;
            // 
            // lblOp2
            // 
            this.lblOp2.AutoSize = true;
            this.lblOp2.Location = new System.Drawing.Point(296, 600);
            this.lblOp2.Name = "lblOp2";
            this.lblOp2.Size = new System.Drawing.Size(48, 13);
            this.lblOp2.TabIndex = 19;
            this.lblOp2.Text = "Operator";
            // 
            // rtbVals1
            // 
            this.rtbVals1.Location = new System.Drawing.Point(659, 555);
            this.rtbVals1.Name = "rtbVals1";
            this.rtbVals1.Size = new System.Drawing.Size(100, 35);
            this.rtbVals1.TabIndex = 21;
            this.rtbVals1.Text = "";
            // 
            // lblVals1
            // 
            this.lblVals1.AutoSize = true;
            this.lblVals1.Location = new System.Drawing.Point(571, 559);
            this.lblVals1.Name = "lblVals1";
            this.lblVals1.Size = new System.Drawing.Size(64, 13);
            this.lblVals1.TabIndex = 22;
            this.lblVals1.Text = "Filter Values";
            // 
            // lblVals2
            // 
            this.lblVals2.AutoSize = true;
            this.lblVals2.Location = new System.Drawing.Point(571, 600);
            this.lblVals2.Name = "lblVals2";
            this.lblVals2.Size = new System.Drawing.Size(61, 13);
            this.lblVals2.TabIndex = 24;
            this.lblVals2.Text = "FilterValues";
            // 
            // rtbVals2
            // 
            this.rtbVals2.Location = new System.Drawing.Point(659, 596);
            this.rtbVals2.Name = "rtbVals2";
            this.rtbVals2.Size = new System.Drawing.Size(100, 35);
            this.rtbVals2.TabIndex = 23;
            this.rtbVals2.Text = "";
            // 
            // btnFilterQuery
            // 
            this.btnFilterQuery.Location = new System.Drawing.Point(819, 608);
            this.btnFilterQuery.Name = "btnFilterQuery";
            this.btnFilterQuery.Size = new System.Drawing.Size(149, 23);
            this.btnFilterQuery.TabIndex = 25;
            this.btnFilterQuery.Text = "Run Query With Filters";
            this.btnFilterQuery.UseVisualStyleBackColor = true;
            this.btnFilterQuery.Click += new System.EventHandler(this.btnFilterQuery_Click);
            // 
            // frmQueries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 674);
            this.Controls.Add(this.btnFilterQuery);
            this.Controls.Add(this.lblVals2);
            this.Controls.Add(this.rtbVals2);
            this.Controls.Add(this.lblVals1);
            this.Controls.Add(this.rtbVals1);
            this.Controls.Add(this.cmbOps2);
            this.Controls.Add(this.lblOp2);
            this.Controls.Add(this.cmbOps1);
            this.Controls.Add(this.lblOp1);
            this.Controls.Add(this.cmbCols2);
            this.Controls.Add(this.cmbCols1);
            this.Controls.Add(this.lblFilterCol2);
            this.Controls.Add(this.lblFilterCol1);
            this.Controls.Add(this.lblPageNumVal);
            this.Controls.Add(this.lblPageNumLab);
            this.Controls.Add(this.btnPrevPage);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.cmbPage);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.btnRunQuery);
            this.Controls.Add(this.cmbQueries);
            this.Controls.Add(this.lblMatchQueries);
            this.Controls.Add(this.btnGetQueries);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.lblFilter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQueries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Query Functionality";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnGetQueries;
        private System.Windows.Forms.Label lblMatchQueries;
        private System.Windows.Forms.ComboBox cmbQueries;
        private System.Windows.Forms.Button btnRunQuery;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.ComboBox cmbPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnPrevPage;
        private System.Windows.Forms.Label lblPageNumLab;
        private System.Windows.Forms.Label lblPageNumVal;
        private System.Windows.Forms.Label lblFilterCol1;
        private System.Windows.Forms.Label lblFilterCol2;
        private System.Windows.Forms.ComboBox cmbCols1;
        private System.Windows.Forms.ComboBox cmbCols2;
        private System.Windows.Forms.ComboBox cmbOps1;
        private System.Windows.Forms.Label lblOp1;
        private System.Windows.Forms.ComboBox cmbOps2;
        private System.Windows.Forms.Label lblOp2;
        private System.Windows.Forms.RichTextBox rtbVals1;
        private System.Windows.Forms.Label lblVals1;
        private System.Windows.Forms.Label lblVals2;
        private System.Windows.Forms.RichTextBox rtbVals2;
        private System.Windows.Forms.Button btnFilterQuery;
    }
}