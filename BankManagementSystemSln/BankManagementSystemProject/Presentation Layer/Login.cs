using System;
using System.Data;
using System.Windows.Forms;
using BankManagementSystemProject.BussinessLogic_Layer;
using BankManagementSystemProject.DataAccess_Layer;
using BankManagementSystemProject.Presentation_Layer;


namespace BankManagementSystemProject
{
    public partial class Login : Form
    {
        LoginBll lda = new LoginBll();
        LoginDal lbl = new LoginDal();
        DataTable dt = new DataTable();
        public string user;

        public Login()
        {
            InitializeComponent();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            lda.UserId = txtUserid.Text;
            lda.password = txtPassword.Text;
        

            dt = lbl.login(lda);

            if (lda.UserId != null && lda.password != null)
            {
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (dt.Rows[i]["role"].ToString() == "Admin")
                        {
                           AdminHome admin = new AdminHome();
                            this.Visible = false;
                            admin.Visible = true;
                        }

                        else if (dt.Rows[i]["role"].ToString() == "Cashier")
                        {
                            CashierHome cashier = new CashierHome();
                            this.Visible = false;
                            cashier.Visible = true;

                        }

                        else if (dt.Rows[i]["role"].ToString() == "Customer")
                        {
                       

                            CustomerHome customer = new CustomerHome(this.txtUserid.Text);
                            this.Visible = false;
                            customer.Visible = true;


                        }
                       
                    }



                }
                else if (lda.UserId != "userid" || lda.password != "password")
                {
                    MessageBox.Show("Wrong Input");
                }


            }





        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
