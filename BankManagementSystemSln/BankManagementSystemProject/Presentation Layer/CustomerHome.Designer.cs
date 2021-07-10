namespace BankManagementSystemProject.Presentation_Layer
{
    partial class CustomerHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerHome));
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtChngPass = new System.Windows.Forms.TextBox();
            this.btnChngPass = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblwithdraw = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblDepo = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picBoxSign = new System.Windows.Forms.PictureBox();
            this.picBoxImg = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(901, 462);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(196, 52);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1172, 100);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Details";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.BackgroundImage = global::BankManagementSystemProject.Properties.Resources._65811774_moraine_lake_panorama_in_banff_national_park_alberta_canada;
            this.panel2.Controls.Add(this.txtChngPass);
            this.panel2.Controls.Add(this.btnChngPass);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.picBoxSign);
            this.panel2.Controls.Add(this.picBoxImg);
            this.panel2.Controls.Add(this.lblwithdraw);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Controls.Add(this.lblID);
            this.panel2.Controls.Add(this.lblBalance);
            this.panel2.Controls.Add(this.lblDepo);
            this.panel2.Controls.Add(this.lbl1);
            this.panel2.Controls.Add(this.lbl2);
            this.panel2.Controls.Add(this.lbl3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Location = new System.Drawing.Point(12, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1172, 517);
            this.panel2.TabIndex = 2;
            // 
            // txtChngPass
            // 
            this.txtChngPass.Location = new System.Drawing.Point(52, 443);
            this.txtChngPass.Name = "txtChngPass";
            this.txtChngPass.Size = new System.Drawing.Size(320, 26);
            this.txtChngPass.TabIndex = 19;
            // 
            // btnChngPass
            // 
            this.btnChngPass.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChngPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChngPass.Location = new System.Drawing.Point(392, 428);
            this.btnChngPass.Name = "btnChngPass";
            this.btnChngPass.Size = new System.Drawing.Size(196, 65);
            this.btnChngPass.TabIndex = 18;
            this.btnChngPass.Text = "Change Password";
            this.btnChngPass.UseVisualStyleBackColor = false;
            this.btnChngPass.Click += new System.EventHandler(this.btnChngPass_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightCyan;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(750, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Image";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightCyan;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(999, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Signeture";
            // 
            // lblwithdraw
            // 
            this.lblwithdraw.AutoSize = true;
            this.lblwithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwithdraw.Location = new System.Drawing.Point(266, 327);
            this.lblwithdraw.Name = "lblwithdraw";
            this.lblwithdraw.Size = new System.Drawing.Size(0, 25);
            this.lblwithdraw.TabIndex = 10;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(266, 48);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 25);
            this.lblName.TabIndex = 9;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(266, 109);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 25);
            this.lblID.TabIndex = 8;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(266, 175);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(0, 25);
            this.lblBalance.TabIndex = 7;
            // 
            // lblDepo
            // 
            this.lblDepo.AutoSize = true;
            this.lblDepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepo.Location = new System.Drawing.Point(266, 251);
            this.lblDepo.Name = "lblDepo";
            this.lblDepo.Size = new System.Drawing.Size(0, 25);
            this.lblDepo.TabIndex = 6;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.LightCyan;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(47, 48);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(180, 25);
            this.lbl1.TabIndex = 5;
            this.lbl1.Text = "Customer Name :";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.LightCyan;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(47, 109);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(181, 25);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = " Customer ID      :";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.Color.LightCyan;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(47, 175);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(181, 25);
            this.lbl3.TabIndex = 3;
            this.lbl3.Text = "Balance              :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightCyan;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Deposit       :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightCyan;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Withdraw    :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::BankManagementSystemProject.Properties.Resources.logout_rounded_down;
            this.pictureBox2.Location = new System.Drawing.Point(1103, 461);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // picBoxSign
            // 
            this.picBoxSign.BackColor = System.Drawing.Color.LightCyan;
            this.picBoxSign.Location = new System.Drawing.Point(939, 76);
            this.picBoxSign.Name = "picBoxSign";
            this.picBoxSign.Size = new System.Drawing.Size(224, 255);
            this.picBoxSign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxSign.TabIndex = 11;
            this.picBoxSign.TabStop = false;
            // 
            // picBoxImg
            // 
            this.picBoxImg.BackColor = System.Drawing.Color.LightCyan;
            this.picBoxImg.Location = new System.Drawing.Point(677, 76);
            this.picBoxImg.Name = "picBoxImg";
            this.picBoxImg.Size = new System.Drawing.Size(224, 255);
            this.picBoxImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxImg.TabIndex = 3;
            this.picBoxImg.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BankManagementSystemProject.Properties.Resources.bank;
            this.pictureBox1.Location = new System.Drawing.Point(271, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // CustomerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 653);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerHome";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblwithdraw;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblDepo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picBoxSign;
        private System.Windows.Forms.PictureBox picBoxImg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnChngPass;
        private System.Windows.Forms.TextBox txtChngPass;
    }
}