using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;
using BankManagementSystemProject.Entity_Layer;
using BankManagementSystemProject.DataAccess_Layer;
using BankManagementSystemProject.BussinessLogic_Layer;



namespace BankManagementSystemProject.Presentation_Layer
{

    public partial class CustomerHome : Form
    {
        private string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        LoginBll lda = new LoginBll();
        Login log = new Login();
        DataTable dt = new DataTable();
        LoginDal dat = new LoginDal();
        private string Id { get; set; }
        private object a;


        public CustomerHome()
         {

            InitializeComponent();

        }


        public CustomerHome(string id)
        {
            InitializeComponent();
            this.Id = id;
            this.lblID.Text += id;


            lda.UserId= this.lblID.Text;
            dt = dat.UserDetails(lda);

            byte[] img = (byte[])dt.Rows[0][15];
            byte[] img2 = (byte[])dt.Rows[0][16];
            MemoryStream ms = new MemoryStream(img);
            MemoryStream ms2 = new MemoryStream(img2);
            picBoxImg.Image = Image.FromStream(ms);
            picBoxSign.Image = Image.FromStream(ms2);


            if (dt.Rows.Count == 1)
            {
                lblName.Text = dt.Rows[0][3].ToString();
               //lblPass.Text = dt.Rows[0][1].ToString();
                lblBalance.Text = dt.Rows[0][12].ToString();
                lblDepo.Text = dt.Rows[0][13].ToString();
                lblwithdraw.Text = dt.Rows[0][14].ToString();
               

            }
            else
            {
                MessageBox.Show("Error");
            } 

        }



        private void btnLogout_Click(object sender, EventArgs e)
            {
                Login log = new Login();
                this.Visible = false;
                log.Visible = true;

            }

        private void btnChngPass_Click(object sender, EventArgs e)
        {

            SqlConnection scon = new SqlConnection(cs);
            string query = "UPDATE [dbo].[user] SET password = @password where userid = @id ;";

            SqlCommand cmd = new SqlCommand(query, scon);
            cmd.Parameters.AddWithValue("@id", lblID.Text);
          
            cmd.Parameters.AddWithValue("@password", txtChngPass.Text);
           
            scon.Open();

            int j = cmd.ExecuteNonQuery();
            if (j > 0)
            {
                MessageBox.Show("Password successfully Updated");
            }
            else
            {
                MessageBox.Show("Error");
            }
            scon.Close();
            /* dt = da.UserDetailsAcc(bl);
             if (dt.Rows.Count == 1)
             {
                 accnum = dt.Rows[0][0].ToString();
                 MessageBox.Show("Your Account Number Is : " + accnum);

             }
             else
             {
                 MessageBox.Show("Error in acc num");
             }*/
            
        }
    }
    }
