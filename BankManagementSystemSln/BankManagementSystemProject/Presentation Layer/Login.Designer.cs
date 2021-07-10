namespace BankManagementSystemProject
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLog = new System.Windows.Forms.Button();
            this.txtUserid = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUserid = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.BackgroundImage = global::BankManagementSystemProject.Properties.Resources._1;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(884, 447);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.btnLog);
            this.panel1.Controls.Add(this.txtUserid);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.lblUserid);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Location = new System.Drawing.Point(75, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 302);
            this.panel1.TabIndex = 0;
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.Ivory;
            this.btnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnLog.Location = new System.Drawing.Point(256, 223);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(157, 52);
            this.btnLog.TabIndex = 5;
            this.btnLog.Text = "Login";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // txtUserid
            // 
            this.txtUserid.Location = new System.Drawing.Point(226, 52);
            this.txtUserid.Name = "txtUserid";
            this.txtUserid.Size = new System.Drawing.Size(248, 26);
            this.txtUserid.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(226, 149);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(248, 26);
            this.txtPassword.TabIndex = 4;
            // 
            // lblUserid
            // 
            this.lblUserid.AutoSize = true;
            this.lblUserid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserid.Location = new System.Drawing.Point(74, 53);
            this.lblUserid.Name = "lblUserid";
            this.lblUserid.Size = new System.Drawing.Size(84, 25);
            this.lblUserid.TabIndex = 2;
            this.lblUserid.Text = "User ID\r\n";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(74, 148);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(106, 25);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(374, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "SignIn\r\n";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(890, 455);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignIn";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtUserid;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUserid;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLog;
    }
}