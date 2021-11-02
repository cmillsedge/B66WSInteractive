
namespace BR6WSInteractive
{
    partial class frmTasks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTasks));
            this.lblFilterValue = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.txtFilterVal = new System.Windows.Forms.TextBox();
            this.cmbOperator = new System.Windows.Forms.ComboBox();
            this.lstTasks = new System.Windows.Forms.ListBox();
            this.lblTasks = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblFieldName = new System.Windows.Forms.Label();
            this.cmbColumns = new System.Windows.Forms.ComboBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFilterValue
            // 
            this.lblFilterValue.AutoSize = true;
            this.lblFilterValue.Location = new System.Drawing.Point(21, 66);
            this.lblFilterValue.Name = "lblFilterValue";
            this.lblFilterValue.Size = new System.Drawing.Size(59, 13);
            this.lblFilterValue.TabIndex = 0;
            this.lblFilterValue.Text = "Filter Value";
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Location = new System.Drawing.Point(21, 142);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(73, 13);
            this.lblOperator.TabIndex = 1;
            this.lblOperator.Text = "Filter Operator";
            // 
            // txtFilterVal
            // 
            this.txtFilterVal.Location = new System.Drawing.Point(123, 63);
            this.txtFilterVal.Name = "txtFilterVal";
            this.txtFilterVal.Size = new System.Drawing.Size(191, 20);
            this.txtFilterVal.TabIndex = 2;
            // 
            // cmbOperator
            // 
            this.cmbOperator.FormattingEnabled = true;
            this.cmbOperator.Items.AddRange(new object[] {
            "=",
            ">",
            "<",
            ">=",
            "<=",
            "!=",
            "any",
            "none",
            "between",
            "outside",
            "like",
            "unlike",
            "contains",
            "starts",
            "ends",
            "search",
            "in",
            "not_in"});
            this.cmbOperator.Location = new System.Drawing.Point(123, 139);
            this.cmbOperator.Name = "cmbOperator";
            this.cmbOperator.Size = new System.Drawing.Size(191, 21);
            this.cmbOperator.TabIndex = 5;
            // 
            // lstTasks
            // 
            this.lstTasks.FormattingEnabled = true;
            this.lstTasks.Location = new System.Drawing.Point(402, 51);
            this.lstTasks.Name = "lstTasks";
            this.lstTasks.Size = new System.Drawing.Size(361, 368);
            this.lstTasks.TabIndex = 6;
            // 
            // lblTasks
            // 
            this.lblTasks.AutoSize = true;
            this.lblTasks.Location = new System.Drawing.Point(399, 35);
            this.lblTasks.Name = "lblTasks";
            this.lblTasks.Size = new System.Drawing.Size(69, 13);
            this.lblTasks.TabIndex = 7;
            this.lblTasks.Text = "Tasks Found";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(239, 183);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblFieldName
            // 
            this.lblFieldName.AutoSize = true;
            this.lblFieldName.Location = new System.Drawing.Point(21, 106);
            this.lblFieldName.Name = "lblFieldName";
            this.lblFieldName.Size = new System.Drawing.Size(54, 13);
            this.lblFieldName.TabIndex = 9;
            this.lblFieldName.Text = "Filter Field";
            // 
            // cmbColumns
            // 
            this.cmbColumns.FormattingEnabled = true;
            this.cmbColumns.Location = new System.Drawing.Point(123, 103);
            this.cmbColumns.Name = "cmbColumns";
            this.cmbColumns.Size = new System.Drawing.Size(191, 21);
            this.cmbColumns.TabIndex = 10;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(21, 9);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(451, 13);
            this.lblMessage.TabIndex = 11;
            this.lblMessage.Text = "This was a quick tester form. It currently only works for single field operators " +
    "e.g. > ,  = ,  !=  etc";
            // 
            // frmTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.cmbColumns);
            this.Controls.Add(this.lblFieldName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblTasks);
            this.Controls.Add(this.lstTasks);
            this.Controls.Add(this.cmbOperator);
            this.Controls.Add(this.txtFilterVal);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.lblFilterValue);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTasks";
            this.Text = "Task Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFilterValue;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.TextBox txtFilterVal;
        private System.Windows.Forms.ComboBox cmbOperator;
        private System.Windows.Forms.ListBox lstTasks;
        private System.Windows.Forms.Label lblTasks;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblFieldName;
        private System.Windows.Forms.ComboBox cmbColumns;
        private System.Windows.Forms.Label lblMessage;
    }
}