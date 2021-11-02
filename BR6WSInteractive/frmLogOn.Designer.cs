
namespace BR6WSInteractive
{
    partial class frmLogOn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogOn));
            this.lblURL = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(25, 27);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(86, 13);
            this.lblURL.TabIndex = 0;
            this.lblURL.Text = "Connection URL";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(25, 62);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(29, 13);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "User";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(25, 95);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(53, 13);
            this.lblPass.TabIndex = 2;
            this.lblPass.Text = "Password";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(131, 27);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(280, 20);
            this.txtURL.TabIndex = 3;
            this.txtURL.Text = "https://biorails.dev.1910genetics.com/";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(131, 59);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(280, 20);
            this.txtUser.TabIndex = 4;
            this.txtUser.Text = "admin";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(131, 92);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(280, 20);
            this.txtPass.TabIndex = 5;
            this.txtPass.Text = "biorails2021";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(336, 129);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // frmLogOn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 165);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblURL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogOn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log On";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnConnect;
    }
}

