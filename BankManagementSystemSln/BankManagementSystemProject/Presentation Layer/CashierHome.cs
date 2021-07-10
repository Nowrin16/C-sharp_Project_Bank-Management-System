using System;
using System.Data;
using System.Configuration;
using System.Windows.Forms;
using BankManagementSystemProject.BussinessLogic_Layer;
using BankManagementSystemProject.DataAccess_Layer;
using BankManagementSystemProject.Presentation_Layer;

namespace BankManagementSystemProject.Presentation_Layer
{
    public partial class CashierHome : Form
    {
        public CashierBll bl = new CashierBll();
        public CashierDal da = new CashierDal();
        public LoginDal dal = new LoginDal();
        public LoginBll dat = new LoginBll();
        public DataTable dt = new DataTable();
        public DataTable dt1 = new DataTable();
        public DataTable dt2 = new DataTable();

        Boolean dep = false;
        Boolean wid = false;
        Boolean tar = false;

        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;


        float Balance1;
        float Balance;

        public CashierHome()
        {
            InitializeComponent();
            string query2 = "select * from [dbo].[user] where role='Customer';";
            this.PopulatGridView(query2);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Visible = false;
            log.Visible = true;
        }


        private void PopulatGridView(string sql)
        {
            DataSet ds = CashierDal.ExecuteQuery(sql);
            this.dgvCustomer.AutoGenerateColumns = false;
            this.dgvCustomer.DataSource = ds.Tables[0];

        }

        private void CashierHome_Load(object sender, EventArgs e)
        {

            string query2 = "select * from [dbo].[user] where role='Customer';";
            this.PopulatGridView(query2);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string query = "select * from [dbo].[user] where role='Customer' and name like'" + this.txtSearch.Text + "%';";
            this.PopulatGridView(query);
        }





        private void btnDepo_Click(object sender, EventArgs e)
        {


            if (lblShowBalance.Text == "-")
            { MessageBox.Show("please insert account number and press show details"); }
            else
            {
                if (txtAccNoDepo.Text == "" || txtAmountDepo.Text == "")
                {
                    MessageBox.Show("please insert all the value properly");
                }
                else
                {
                    // bl.userid = int.Parse(txtAccNoDepo.Text);

                    bl.userid = int.Parse(txtAccNoDepo.Text);
                    int i;
                    DialogResult res = MessageBox.Show("Do you want to deposit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (res.Equals(DialogResult.Yes))
                        if (txtAccNoDepo.Text == "" || txtAmountDepo.Text == "" || float.Parse(txtAmountDepo.Text) < 0)
                        {
                            MessageBox.Show("value cannot be null or 0 or negative");
                        }
                        else if (dep == false)
                        {
                            //log.D_Date = dateTimePicker1.Text;

                            bl.deposited = float.Parse(txtAmountDepo.Text);
                            Balance = float.Parse(lblShowBalance.Text);
                            bl.balance = Balance + bl.deposited;
                            i = da.Deposit(bl);
                            if (i >= 0)
                            {
                                MessageBox.Show("Deposited " + txtAmountDepo.Text);
                            }

                            else
                            {
                                MessageBox.Show("Error");
                            }
                            dep = false;
                        }
                }

            }




            CashierHome man = new CashierHome();
            this.Visible = false;
            man.Visible = true;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            bl.userid = int.Parse(txtAccNoDepo.Text);
            dt = da.UserDetails(bl);

            if (dt.Rows.Count == 1)
            {
                lblShowBalance.Text = dt.Rows[0][12].ToString();



            }
            else
            {
                MessageBox.Show("INVALID Account No");
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            bl.userid = int.Parse(txtAccNoWith.Text);
            dt = da.UserDetails(bl);

            if (dt.Rows.Count == 1)
            {
                lblBalance.Text = dt.Rows[0][12].ToString();



            }
            else
            {
                MessageBox.Show("INVALID Account No");
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (lblBalance.Text == "-")
            {
                MessageBox.Show("please insert account number and press show details");
            }
            else
            {
                if (txtAccNoWith.Text == "" || txtAmountWith.Text == "")
                {
                    MessageBox.Show("please insert all the value properly");
                }
                else
                {
                    if (float.Parse(lblBalance.Text) != 0 && float.Parse(lblBalance.Text) >= float.Parse(txtAmountWith.Text))
                    {
                        //log.W_Date = dateTimePicker1.Text;
                        bl.userid = int.Parse(txtAccNoWith.Text);
                        // log.AccountNumber = int.Parse(textBox1.Text);
                        int i;
                        // int j;
                        // int k;
                        DialogResult res = MessageBox.Show("Do you want to Withdraw?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (res.Equals(DialogResult.Yes))
                            if (txtAccNoWith.Text == "" || txtAmountWith.Text == "" || txtAccNoWith.Text == "0" || float.Parse(txtAmountWith.Text) < 0)
                            {
                                MessageBox.Show("value cannot be null or 0 or negative");
                            }
                            else if (wid == false)
                            {


                                bl.withdrawn = float.Parse(txtAmountWith.Text);
                                Balance = float.Parse(lblBalance.Text);
                                bl.balance = Balance - bl.withdrawn;
                                i = da.Withdraw(bl);
                                //  j = dat.Withdraw(log);
                                //  k = dat.Withdraw(log);
                                if (i >= 0)
                                {
                                    MessageBox.Show("Withdrawn " + txtAmountWith.Text);
                                    CashierHome man = new CashierHome();
                                    this.Visible = false;
                                    man.Visible = true;
                                }

                                else
                                {
                                    MessageBox.Show("Error");
                                }
                                wid = false;
                            }
                    }
                    else
                    {
                        MessageBox.Show("You don't have that much Balance!");
                    }
                }
            }




           
        }

        private void btnShowTrans_Click(object sender, EventArgs e)
        {

            bl.userid = int.Parse(txtTransFrom.Text);
            bl.userid1 = int.Parse(txtTransTo.Text);
            dt1 = da.UserDetails1(bl);
            dt2 = da.UserDetails2(bl);
            if (dt1.Rows.Count == 1 && dt2.Rows.Count == 1)
            {
                lblBalanceFrm.Text = dt1.Rows[0][12].ToString();
                lblBalanceTo.Text = dt2.Rows[0][12].ToString();


            }
            else
            {
                MessageBox.Show("INVALID Account No");
            }
        }

        private void btnTrans_Click(object sender, EventArgs e)
        {
            if (lblBalanceFrm.Text == "-")
            {
                MessageBox.Show("please insert Customer ID and press show details");
            }
            else
            {
                if (txtAmountTrans.Text == "")
                {
                    MessageBox.Show("please insert all the value properly");
                }

                else
                {
                    if (float.Parse(lblBalanceFrm.Text) != 0 && float.Parse(lblBalanceFrm.Text) >= float.Parse(txtAmountTrans.Text))
                    {
                        bl.userid = int.Parse(txtTransFrom.Text);
                        bl.userid1 = int.Parse(txtTransTo.Text);
                        Balance = float.Parse(lblBalanceFrm.Text);
                        Balance1 = float.Parse(lblBalanceTo.Text);
                        int i;
                        int j;

                        DialogResult res = MessageBox.Show("Do want to transfer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (res.Equals(DialogResult.Yes))
                            if (txtAmountTrans.Text == "" || txtTransTo.Text == "" || txtAmountTrans.Text == "0" || float.Parse(txtTransTo.Text) < 0)
                            {
                                MessageBox.Show("value cannot be null or 0 or negative");
                            }
                            else if (tar == false)
                            {
                                //lon.D_Date = lon.W_Date = dateTimePicker1.Text;

                                bl.withdrawn = float.Parse(txtAmountTrans.Text);
                                bl.deposited = float.Parse(txtAmountTrans.Text);
                                Balance = float.Parse(lblBalanceFrm.Text);
                                bl.balance = Balance - bl.withdrawn;
                                bl.balance1 = Balance1 + bl.deposited;
                                i = da.Transfer(bl);
                                j = da.Transfer(bl);

                                if (i >= 0 && j >= 0)
                                {
                                    MessageBox.Show("Transfer Succes " + txtAmountTrans.Text);
                                    CashierHome man = new CashierHome();
                                    this.Visible = false;
                                    man.Visible = true;
                                }

                                else
                                {
                                    MessageBox.Show("Error");
                                }
                                tar = false;
                            }
                    }
                    else
                    {
                        MessageBox.Show("You Don't Not That Much Balance!");
                    }
                }
            }
        }
    }
}
