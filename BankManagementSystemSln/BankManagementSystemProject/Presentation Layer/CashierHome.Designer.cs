namespace BankManagementSystemProject.Presentation_Layer
{
    partial class CashierHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierHome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.userid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accounttype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deposited = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.withdrawn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAmountWith = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.txtAccNoWith = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnShowTrans = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.lblBalanceFrm = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblBalanceTo = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTransTo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAmountTrans = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTrans = new System.Windows.Forms.Button();
            this.txtTransFrom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.lblShowBalance = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAmountDepo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDepo = new System.Windows.Forms.Button();
            this.txtAccNoDepo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.dgvCustomer);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1246, 696);
            this.panel1.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Menu;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(84, 412);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(166, 25);
            this.label11.TabIndex = 9;
            this.label11.Text = "Search Account";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(626, 398);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(193, 42);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(299, 411);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(243, 26);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userid,
            this.name,
            this.accounttype,
            this.address,
            this.phone,
            this.email,
            this.nid,
            this.gender,
            this.balance,
            this.deposited,
            this.withdrawn});
            this.dgvCustomer.Location = new System.Drawing.Point(11, 452);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.RowTemplate.Height = 28;
            this.dgvCustomer.Size = new System.Drawing.Size(1223, 241);
            this.dgvCustomer.TabIndex = 2;
            // 
            // userid
            // 
            this.userid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userid.DataPropertyName = "userid";
            this.userid.HeaderText = "Customer ID";
            this.userid.Name = "userid";
            this.userid.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // accounttype
            // 
            this.accounttype.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.accounttype.DataPropertyName = "accounttype";
            this.accounttype.HeaderText = "Account Type";
            this.accounttype.Name = "accounttype";
            this.accounttype.ReadOnly = true;
            // 
            // address
            // 
            this.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "Phone Number";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // nid
            // 
            this.nid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nid.DataPropertyName = "nid";
            this.nid.HeaderText = "NID";
            this.nid.Name = "nid";
            this.nid.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // balance
            // 
            this.balance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.balance.DataPropertyName = "balance";
            this.balance.HeaderText = "Balance";
            this.balance.Name = "balance";
            this.balance.ReadOnly = true;
            // 
            // deposited
            // 
            this.deposited.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.deposited.DataPropertyName = "deposited";
            this.deposited.HeaderText = "Last Deposited";
            this.deposited.Name = "deposited";
            this.deposited.ReadOnly = true;
            // 
            // withdrawn
            // 
            this.withdrawn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.withdrawn.DataPropertyName = "withdrawn";
            this.withdrawn.HeaderText = "Last Withdrawn";
            this.withdrawn.Name = "withdrawn";
            this.withdrawn.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.btnShow);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.lblBalance);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtAmountWith);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.btnWithdraw);
            this.panel3.Controls.Add(this.txtAccNoWith);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(425, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(394, 371);
            this.panel3.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BankManagementSystemProject.Properties.Resources.withdrawal;
            this.pictureBox3.Location = new System.Drawing.Point(234, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 46);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShow.Location = new System.Drawing.Point(127, 218);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(131, 44);
            this.btnShow.TabIndex = 17;
            this.btnShow.Text = "Show Balance";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(14, 141);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 25);
            this.label14.TabIndex = 16;
            this.label14.Text = "Balance";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(238, 142);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(20, 25);
            this.lblBalance.TabIndex = 15;
            this.lblBalance.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(54, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Amount";
            // 
            // txtAmountWith
            // 
            this.txtAmountWith.Location = new System.Drawing.Point(234, 287);
            this.txtAmountWith.Name = "txtAmountWith";
            this.txtAmountWith.Size = new System.Drawing.Size(146, 26);
            this.txtAmountWith.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Customer ID";
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnWithdraw.Location = new System.Drawing.Point(127, 327);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(131, 44);
            this.btnWithdraw.TabIndex = 10;
            this.btnWithdraw.Text = "OK";
            this.btnWithdraw.UseVisualStyleBackColor = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // txtAccNoWith
            // 
            this.txtAccNoWith.Location = new System.Drawing.Point(234, 73);
            this.txtAccNoWith.Name = "txtAccNoWith";
            this.txtAccNoWith.Size = new System.Drawing.Size(146, 26);
            this.txtAccNoWith.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Menu;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Withdraw Money";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.btnShowTrans);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.lblBalanceFrm);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.lblBalanceTo);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.txtTransTo);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.txtAmountTrans);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.btnTrans);
            this.panel4.Controls.Add(this.txtTransFrom);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(840, 11);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(394, 435);
            this.panel4.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BankManagementSystemProject.Properties.Resources.back_sorting;
            this.pictureBox2.Location = new System.Drawing.Point(235, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // btnShowTrans
            // 
            this.btnShowTrans.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShowTrans.Location = new System.Drawing.Point(129, 304);
            this.btnShowTrans.Name = "btnShowTrans";
            this.btnShowTrans.Size = new System.Drawing.Size(131, 44);
            this.btnShowTrans.TabIndex = 26;
            this.btnShowTrans.Text = "Show Balance";
            this.btnShowTrans.UseVisualStyleBackColor = false;
            this.btnShowTrans.Click += new System.EventHandler(this.btnShowTrans_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(61, 128);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 25);
            this.label16.TabIndex = 25;
            this.label16.Text = "Balance";
            // 
            // lblBalanceFrm
            // 
            this.lblBalanceFrm.AutoSize = true;
            this.lblBalanceFrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceFrm.Location = new System.Drawing.Point(230, 128);
            this.lblBalanceFrm.Name = "lblBalanceFrm";
            this.lblBalanceFrm.Size = new System.Drawing.Size(20, 25);
            this.lblBalanceFrm.TabIndex = 24;
            this.lblBalanceFrm.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(61, 254);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 25);
            this.label12.TabIndex = 23;
            this.label12.Text = "Balance";
            // 
            // lblBalanceTo
            // 
            this.lblBalanceTo.AutoSize = true;
            this.lblBalanceTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceTo.Location = new System.Drawing.Point(230, 254);
            this.lblBalanceTo.Name = "lblBalanceTo";
            this.lblBalanceTo.Size = new System.Drawing.Size(20, 25);
            this.lblBalanceTo.TabIndex = 22;
            this.lblBalanceTo.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 25);
            this.label10.TabIndex = 21;
            this.label10.Text = "Transfer To";
            // 
            // txtTransTo
            // 
            this.txtTransTo.Location = new System.Drawing.Point(223, 193);
            this.txtTransTo.Name = "txtTransTo";
            this.txtTransTo.Size = new System.Drawing.Size(159, 26);
            this.txtTransTo.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(44, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "Amount";
            // 
            // txtAmountTrans
            // 
            this.txtAmountTrans.Location = new System.Drawing.Point(223, 354);
            this.txtAmountTrans.Name = "txtAmountTrans";
            this.txtAmountTrans.Size = new System.Drawing.Size(159, 26);
            this.txtAmountTrans.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Transfer From";
            // 
            // btnTrans
            // 
            this.btnTrans.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTrans.Location = new System.Drawing.Point(129, 391);
            this.btnTrans.Name = "btnTrans";
            this.btnTrans.Size = new System.Drawing.Size(131, 44);
            this.btnTrans.TabIndex = 15;
            this.btnTrans.Text = "OK";
            this.btnTrans.UseVisualStyleBackColor = false;
            this.btnTrans.Click += new System.EventHandler(this.btnTrans_Click);
            // 
            // txtTransFrom
            // 
            this.txtTransFrom.Location = new System.Drawing.Point(223, 74);
            this.txtTransFrom.Name = "txtTransFrom";
            this.txtTransFrom.Size = new System.Drawing.Size(159, 26);
            this.txtTransFrom.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Menu;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Transfer Money";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.lblShowBalance);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtAmountDepo);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnDepo);
            this.panel2.Controls.Add(this.txtAccNoDepo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(11, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 371);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BankManagementSystemProject.Properties.Resources.deposit;
            this.pictureBox1.Location = new System.Drawing.Point(209, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(108, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 44);
            this.button1.TabIndex = 11;
            this.button1.Text = "Show Balance";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(39, 156);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 25);
            this.label13.TabIndex = 10;
            this.label13.Text = "Balance";
            // 
            // lblShowBalance
            // 
            this.lblShowBalance.AutoSize = true;
            this.lblShowBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowBalance.Location = new System.Drawing.Point(204, 155);
            this.lblShowBalance.Name = "lblShowBalance";
            this.lblShowBalance.Size = new System.Drawing.Size(20, 25);
            this.lblShowBalance.TabIndex = 9;
            this.lblShowBalance.Text = "-\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Amount";
            // 
            // txtAmountDepo
            // 
            this.txtAmountDepo.Location = new System.Drawing.Point(209, 287);
            this.txtAmountDepo.Name = "txtAmountDepo";
            this.txtAmountDepo.Size = new System.Drawing.Size(143, 26);
            this.txtAmountDepo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Customer ID";
            // 
            // btnDepo
            // 
            this.btnDepo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDepo.Location = new System.Drawing.Point(108, 327);
            this.btnDepo.Name = "btnDepo";
            this.btnDepo.Size = new System.Drawing.Size(131, 44);
            this.btnDepo.TabIndex = 5;
            this.btnDepo.Text = "OK";
            this.btnDepo.UseVisualStyleBackColor = false;
            this.btnDepo.Click += new System.EventHandler(this.btnDepo_Click);
            // 
            // txtAccNoDepo
            // 
            this.txtAccNoDepo.Location = new System.Drawing.Point(209, 93);
            this.txtAccNoDepo.Name = "txtAccNoDepo";
            this.txtAccNoDepo.Size = new System.Drawing.Size(143, 26);
            this.txtAccNoDepo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Menu;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Deposit Money";
            // 
            // CashierHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 697);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CashierHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashierHome";
            this.Load += new System.EventHandler(this.CashierHome_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAmountWith;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.TextBox txtAccNoWith;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTransTo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAmountTrans;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnTrans;
        private System.Windows.Forms.TextBox txtTransFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAmountDepo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDepo;
        private System.Windows.Forms.TextBox txtAccNoDepo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userid;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn accounttype;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn nid;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn deposited;
        private System.Windows.Forms.DataGridViewTextBoxColumn withdrawn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblShowBalance;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button btnShowTrans;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblBalanceFrm;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblBalanceTo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}