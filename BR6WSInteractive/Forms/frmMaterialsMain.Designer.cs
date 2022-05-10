namespace BR6WSInteractive
{
    partial class frmMaterialsMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaterialsMain));
            this.lblAllSampleTypes = new System.Windows.Forms.Label();
            this.cmbSampTypes = new System.Windows.Forms.ComboBox();
            this.grpFormLoad = new System.Windows.Forms.GroupBox();
            this.cmbLayoutLoad = new System.Windows.Forms.ComboBox();
            this.cmbTypeLoad = new System.Windows.Forms.ComboBox();
            this.txtListDesciption = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpMatClone = new System.Windows.Forms.GroupBox();
            this.btnMatEdit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblMatDest = new System.Windows.Forms.Label();
            this.txtMatDest = new System.Windows.Forms.TextBox();
            this.lblMatSource = new System.Windows.Forms.Label();
            this.txtMatSource = new System.Windows.Forms.TextBox();
            this.btnMatClone = new System.Windows.Forms.Button();
            this.rtbWSOutput = new System.Windows.Forms.RichTextBox();
            this.dgvMat = new System.Windows.Forms.DataGridView();
            this.PropName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PropVal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpRecList = new System.Windows.Forms.GroupBox();
            this.lblRecipes = new System.Windows.Forms.Label();
            this.cmbRecipes = new System.Windows.Forms.ComboBox();
            this.lblMType = new System.Windows.Forms.Label();
            this.cmbMTypes = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.grpFormFromRec = new System.Windows.Forms.GroupBox();
            this.txtRecipe = new System.Windows.Forms.TextBox();
            this.lblRecLab = new System.Windows.Forms.Label();
            this.btnFormulationCreate = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.grpRecipe = new System.Windows.Forms.GroupBox();
            this.lblRecMType = new System.Windows.Forms.Label();
            this.cmbRecMType = new System.Windows.Forms.ComboBox();
            this.btnRecipeCreate = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.grpFormLoad.SuspendLayout();
            this.grpMatClone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMat)).BeginInit();
            this.grpRecList.SuspendLayout();
            this.grpFormFromRec.SuspendLayout();
            this.grpRecipe.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAllSampleTypes
            // 
            this.lblAllSampleTypes.AutoSize = true;
            this.lblAllSampleTypes.Location = new System.Drawing.Point(402, 26);
            this.lblAllSampleTypes.Name = "lblAllSampleTypes";
            this.lblAllSampleTypes.Size = new System.Drawing.Size(88, 13);
            this.lblAllSampleTypes.TabIndex = 0;
            this.lblAllSampleTypes.Text = "All Sample Types";
            // 
            // cmbSampTypes
            // 
            this.cmbSampTypes.FormattingEnabled = true;
            this.cmbSampTypes.Location = new System.Drawing.Point(371, 42);
            this.cmbSampTypes.Name = "cmbSampTypes";
            this.cmbSampTypes.Size = new System.Drawing.Size(157, 21);
            this.cmbSampTypes.TabIndex = 1;
            // 
            // grpFormLoad
            // 
            this.grpFormLoad.Controls.Add(this.cmbLayoutLoad);
            this.grpFormLoad.Controls.Add(this.lblAllSampleTypes);
            this.grpFormLoad.Controls.Add(this.cmbSampTypes);
            this.grpFormLoad.Controls.Add(this.cmbTypeLoad);
            this.grpFormLoad.Controls.Add(this.txtListDesciption);
            this.grpFormLoad.Controls.Add(this.label2);
            this.grpFormLoad.Controls.Add(this.label3);
            this.grpFormLoad.Location = new System.Drawing.Point(12, 17);
            this.grpFormLoad.Name = "grpFormLoad";
            this.grpFormLoad.Size = new System.Drawing.Size(844, 75);
            this.grpFormLoad.TabIndex = 13;
            this.grpFormLoad.TabStop = false;
            this.grpFormLoad.Text = "Form Load";
            // 
            // cmbLayoutLoad
            // 
            this.cmbLayoutLoad.FormattingEnabled = true;
            this.cmbLayoutLoad.Location = new System.Drawing.Point(191, 42);
            this.cmbLayoutLoad.Name = "cmbLayoutLoad";
            this.cmbLayoutLoad.Size = new System.Drawing.Size(157, 21);
            this.cmbLayoutLoad.TabIndex = 21;
            // 
            // cmbTypeLoad
            // 
            this.cmbTypeLoad.FormattingEnabled = true;
            this.cmbTypeLoad.Location = new System.Drawing.Point(14, 42);
            this.cmbTypeLoad.Name = "cmbTypeLoad";
            this.cmbTypeLoad.Size = new System.Drawing.Size(157, 21);
            this.cmbTypeLoad.TabIndex = 20;
            // 
            // txtListDesciption
            // 
            this.txtListDesciption.Enabled = false;
            this.txtListDesciption.Location = new System.Drawing.Point(540, 23);
            this.txtListDesciption.Multiline = true;
            this.txtListDesciption.Name = "txtListDesciption";
            this.txtListDesciption.Size = new System.Drawing.Size(298, 46);
            this.txtListDesciption.TabIndex = 11;
            this.txtListDesciption.Text = "When the form loads. The list sample types,  layout and container type methods ar" +
    "e called to populate these comboboxes. If they are populated then it passes.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "ContainerLayout";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ContainerType";
            // 
            // grpMatClone
            // 
            this.grpMatClone.Controls.Add(this.btnMatEdit);
            this.grpMatClone.Controls.Add(this.textBox1);
            this.grpMatClone.Controls.Add(this.lblMatDest);
            this.grpMatClone.Controls.Add(this.txtMatDest);
            this.grpMatClone.Controls.Add(this.lblMatSource);
            this.grpMatClone.Controls.Add(this.txtMatSource);
            this.grpMatClone.Controls.Add(this.btnMatClone);
            this.grpMatClone.Location = new System.Drawing.Point(13, 100);
            this.grpMatClone.Name = "grpMatClone";
            this.grpMatClone.Size = new System.Drawing.Size(844, 75);
            this.grpMatClone.TabIndex = 25;
            this.grpMatClone.TabStop = false;
            this.grpMatClone.Text = "Clone Material";
            // 
            // btnMatEdit
            // 
            this.btnMatEdit.Location = new System.Drawing.Point(245, 39);
            this.btnMatEdit.Name = "btnMatEdit";
            this.btnMatEdit.Size = new System.Drawing.Size(126, 23);
            this.btnMatEdit.TabIndex = 12;
            this.btnMatEdit.Text = "Edit Material";
            this.btnMatEdit.UseVisualStyleBackColor = true;
            this.btnMatEdit.Click += new System.EventHandler(this.btnMatEdit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(540, 26);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(298, 40);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "This will test the material_get and material_upload methods with the material nam" +
    "es provided";
            // 
            // lblMatDest
            // 
            this.lblMatDest.AutoSize = true;
            this.lblMatDest.Location = new System.Drawing.Point(134, 26);
            this.lblMatDest.Name = "lblMatDest";
            this.lblMatDest.Size = new System.Drawing.Size(69, 13);
            this.lblMatDest.TabIndex = 9;
            this.lblMatDest.Text = "New Material";
            // 
            // txtMatDest
            // 
            this.txtMatDest.Location = new System.Drawing.Point(122, 42);
            this.txtMatDest.Name = "txtMatDest";
            this.txtMatDest.Size = new System.Drawing.Size(100, 20);
            this.txtMatDest.TabIndex = 8;
            this.txtMatDest.Text = "bio_00000486_clone";
            // 
            // lblMatSource
            // 
            this.lblMatSource.AutoSize = true;
            this.lblMatSource.Location = new System.Drawing.Point(23, 26);
            this.lblMatSource.Name = "lblMatSource";
            this.lblMatSource.Size = new System.Drawing.Size(87, 13);
            this.lblMatSource.TabIndex = 7;
            this.lblMatSource.Text = "Material To Copy";
            // 
            // txtMatSource
            // 
            this.txtMatSource.Location = new System.Drawing.Point(16, 42);
            this.txtMatSource.Name = "txtMatSource";
            this.txtMatSource.Size = new System.Drawing.Size(100, 20);
            this.txtMatSource.TabIndex = 5;
            this.txtMatSource.Text = "bio_00000486";
            // 
            // btnMatClone
            // 
            this.btnMatClone.Location = new System.Drawing.Point(392, 39);
            this.btnMatClone.Name = "btnMatClone";
            this.btnMatClone.Size = new System.Drawing.Size(126, 23);
            this.btnMatClone.TabIndex = 0;
            this.btnMatClone.Text = "Clone Material";
            this.btnMatClone.UseVisualStyleBackColor = true;
            this.btnMatClone.Click += new System.EventHandler(this.btnMatClone_Click);
            // 
            // rtbWSOutput
            // 
            this.rtbWSOutput.Location = new System.Drawing.Point(878, 26);
            this.rtbWSOutput.Name = "rtbWSOutput";
            this.rtbWSOutput.Size = new System.Drawing.Size(503, 397);
            this.rtbWSOutput.TabIndex = 26;
            this.rtbWSOutput.Text = "";
            // 
            // dgvMat
            // 
            this.dgvMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PropName,
            this.PropVal});
            this.dgvMat.Location = new System.Drawing.Point(878, 429);
            this.dgvMat.Name = "dgvMat";
            this.dgvMat.Size = new System.Drawing.Size(318, 77);
            this.dgvMat.TabIndex = 29;
            this.dgvMat.Visible = false;
            // 
            // PropName
            // 
            this.PropName.HeaderText = "Property Name";
            this.PropName.Name = "PropName";
            this.PropName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PropVal
            // 
            this.PropVal.HeaderText = "PropertyValue";
            this.PropVal.Name = "PropVal";
            this.PropVal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // grpRecList
            // 
            this.grpRecList.Controls.Add(this.lblRecipes);
            this.grpRecList.Controls.Add(this.cmbRecipes);
            this.grpRecList.Controls.Add(this.lblMType);
            this.grpRecList.Controls.Add(this.cmbMTypes);
            this.grpRecList.Controls.Add(this.textBox2);
            this.grpRecList.Location = new System.Drawing.Point(12, 189);
            this.grpRecList.Name = "grpRecList";
            this.grpRecList.Size = new System.Drawing.Size(844, 75);
            this.grpRecList.TabIndex = 30;
            this.grpRecList.TabStop = false;
            this.grpRecList.Text = "Recipe List";
            // 
            // lblRecipes
            // 
            this.lblRecipes.AutoSize = true;
            this.lblRecipes.Location = new System.Drawing.Point(325, 24);
            this.lblRecipes.Name = "lblRecipes";
            this.lblRecipes.Size = new System.Drawing.Size(147, 13);
            this.lblRecipes.TabIndex = 30;
            this.lblRecipes.Text = "Recipes for this Material Type";
            // 
            // cmbRecipes
            // 
            this.cmbRecipes.FormattingEnabled = true;
            this.cmbRecipes.Location = new System.Drawing.Point(275, 40);
            this.cmbRecipes.Name = "cmbRecipes";
            this.cmbRecipes.Size = new System.Drawing.Size(243, 21);
            this.cmbRecipes.TabIndex = 31;
            this.cmbRecipes.SelectedIndexChanged += new System.EventHandler(this.cmbRecipes_SelectedIndexChanged);
            // 
            // lblMType
            // 
            this.lblMType.AutoSize = true;
            this.lblMType.Location = new System.Drawing.Point(54, 24);
            this.lblMType.Name = "lblMType";
            this.lblMType.Size = new System.Drawing.Size(128, 13);
            this.lblMType.TabIndex = 13;
            this.lblMType.Text = "Material Type for Recipes";
            // 
            // cmbMTypes
            // 
            this.cmbMTypes.FormattingEnabled = true;
            this.cmbMTypes.Location = new System.Drawing.Point(16, 40);
            this.cmbMTypes.Name = "cmbMTypes";
            this.cmbMTypes.Size = new System.Drawing.Size(206, 21);
            this.cmbMTypes.TabIndex = 29;
            this.cmbMTypes.SelectedIndexChanged += new System.EventHandler(this.cmbMTypes_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(540, 12);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(298, 57);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "This will test the material_type_list and material_recipe list methods. The mater" +
    "ial types will list on form load. Select one and it will populate the second com" +
    "bo.";
            // 
            // grpFormFromRec
            // 
            this.grpFormFromRec.Controls.Add(this.txtRecipe);
            this.grpFormFromRec.Controls.Add(this.lblRecLab);
            this.grpFormFromRec.Controls.Add(this.btnFormulationCreate);
            this.grpFormFromRec.Controls.Add(this.textBox3);
            this.grpFormFromRec.Location = new System.Drawing.Point(13, 279);
            this.grpFormFromRec.Name = "grpFormFromRec";
            this.grpFormFromRec.Size = new System.Drawing.Size(844, 114);
            this.grpFormFromRec.TabIndex = 33;
            this.grpFormFromRec.TabStop = false;
            this.grpFormFromRec.Text = "Formulation from Recipe";
            // 
            // txtRecipe
            // 
            this.txtRecipe.Enabled = false;
            this.txtRecipe.Location = new System.Drawing.Point(100, 19);
            this.txtRecipe.Name = "txtRecipe";
            this.txtRecipe.Size = new System.Drawing.Size(283, 20);
            this.txtRecipe.TabIndex = 13;
            // 
            // lblRecLab
            // 
            this.lblRecLab.AutoSize = true;
            this.lblRecLab.Location = new System.Drawing.Point(10, 24);
            this.lblRecLab.Name = "lblRecLab";
            this.lblRecLab.Size = new System.Drawing.Size(78, 13);
            this.lblRecLab.TabIndex = 32;
            this.lblRecLab.Text = "Recipe to Use:";
            // 
            // btnFormulationCreate
            // 
            this.btnFormulationCreate.Location = new System.Drawing.Point(389, 18);
            this.btnFormulationCreate.Name = "btnFormulationCreate";
            this.btnFormulationCreate.Size = new System.Drawing.Size(126, 23);
            this.btnFormulationCreate.TabIndex = 32;
            this.btnFormulationCreate.Text = "Create Formulation";
            this.btnFormulationCreate.UseVisualStyleBackColor = true;
            this.btnFormulationCreate.Click += new System.EventHandler(this.btnFormulationCreate_Click);
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(540, 12);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(298, 57);
            this.textBox3.TabIndex = 11;
            this.textBox3.Text = "This will test the material_create method. Note it uses the recipe value from the" +
    " group of controls above.";
            // 
            // grpRecipe
            // 
            this.grpRecipe.Controls.Add(this.lblRecMType);
            this.grpRecipe.Controls.Add(this.cmbRecMType);
            this.grpRecipe.Controls.Add(this.btnRecipeCreate);
            this.grpRecipe.Controls.Add(this.textBox5);
            this.grpRecipe.Location = new System.Drawing.Point(12, 399);
            this.grpRecipe.Name = "grpRecipe";
            this.grpRecipe.Size = new System.Drawing.Size(844, 75);
            this.grpRecipe.TabIndex = 35;
            this.grpRecipe.TabStop = false;
            this.grpRecipe.Text = "Create Recipe";
            // 
            // lblRecMType
            // 
            this.lblRecMType.AutoSize = true;
            this.lblRecMType.Location = new System.Drawing.Point(51, 25);
            this.lblRecMType.Name = "lblRecMType";
            this.lblRecMType.Size = new System.Drawing.Size(128, 13);
            this.lblRecMType.TabIndex = 30;
            this.lblRecMType.Text = "Material Type for Recipes";
            // 
            // cmbRecMType
            // 
            this.cmbRecMType.FormattingEnabled = true;
            this.cmbRecMType.Location = new System.Drawing.Point(13, 41);
            this.cmbRecMType.Name = "cmbRecMType";
            this.cmbRecMType.Size = new System.Drawing.Size(206, 21);
            this.cmbRecMType.TabIndex = 31;
            // 
            // btnRecipeCreate
            // 
            this.btnRecipeCreate.Location = new System.Drawing.Point(245, 39);
            this.btnRecipeCreate.Name = "btnRecipeCreate";
            this.btnRecipeCreate.Size = new System.Drawing.Size(270, 23);
            this.btnRecipeCreate.TabIndex = 12;
            this.btnRecipeCreate.Text = "Create Recipe";
            this.btnRecipeCreate.UseVisualStyleBackColor = true;
            this.btnRecipeCreate.Click += new System.EventHandler(this.btnRecipeCreate_Click);
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(540, 26);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(298, 40);
            this.textBox5.TabIndex = 11;
            this.textBox5.Text = "This will test material_recipe_create";
            // 
            // frmMaterialsMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 518);
            this.Controls.Add(this.grpRecipe);
            this.Controls.Add(this.grpFormFromRec);
            this.Controls.Add(this.grpRecList);
            this.Controls.Add(this.dgvMat);
            this.Controls.Add(this.rtbWSOutput);
            this.Controls.Add(this.grpMatClone);
            this.Controls.Add(this.grpFormLoad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMaterialsMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Main Materials Test Page";
            this.grpFormLoad.ResumeLayout(false);
            this.grpFormLoad.PerformLayout();
            this.grpMatClone.ResumeLayout(false);
            this.grpMatClone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMat)).EndInit();
            this.grpRecList.ResumeLayout(false);
            this.grpRecList.PerformLayout();
            this.grpFormFromRec.ResumeLayout(false);
            this.grpFormFromRec.PerformLayout();
            this.grpRecipe.ResumeLayout(false);
            this.grpRecipe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAllSampleTypes;
        private System.Windows.Forms.ComboBox cmbSampTypes;
        private System.Windows.Forms.GroupBox grpFormLoad;
        private System.Windows.Forms.ComboBox cmbLayoutLoad;
        private System.Windows.Forms.ComboBox cmbTypeLoad;
        private System.Windows.Forms.TextBox txtListDesciption;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpMatClone;
        private System.Windows.Forms.Button btnMatEdit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblMatDest;
        private System.Windows.Forms.TextBox txtMatDest;
        private System.Windows.Forms.Label lblMatSource;
        private System.Windows.Forms.TextBox txtMatSource;
        private System.Windows.Forms.Button btnMatClone;
        private System.Windows.Forms.RichTextBox rtbWSOutput;
        private System.Windows.Forms.DataGridView dgvMat;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropVal;
        private System.Windows.Forms.GroupBox grpRecList;
        private System.Windows.Forms.Label lblRecipes;
        private System.Windows.Forms.ComboBox cmbRecipes;
        private System.Windows.Forms.Label lblMType;
        private System.Windows.Forms.ComboBox cmbMTypes;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox grpFormFromRec;
        private System.Windows.Forms.TextBox txtRecipe;
        private System.Windows.Forms.Label lblRecLab;
        private System.Windows.Forms.Button btnFormulationCreate;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox grpRecipe;
        private System.Windows.Forms.Label lblRecMType;
        private System.Windows.Forms.ComboBox cmbRecMType;
        private System.Windows.Forms.Button btnRecipeCreate;
        private System.Windows.Forms.TextBox textBox5;
    }
}