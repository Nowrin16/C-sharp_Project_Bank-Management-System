using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using BankManagementSystemProject.DataAccess_Layer;
using BankManagementSystemProject.Entity_Layer;
using BankManagementSystemProject.BussinessLogic_Layer;

namespace BankManagementSystemProject.Presentation_Layer
{
    public partial class EmpDetails : Form
    {
        public EmpDetailsBll bl = new EmpDetailsBll();
        public EmpDetailsDal da = new EmpDetailsDal();
        public EmpDetailsEl el = new EmpDetailsEl();
        public LoginDal dal = new LoginDal();
        public LoginBll dat = new LoginBll();

        DataTable dt = new DataTable();
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public int i { get; set; }
        // private EmpDetailsDal da;
        private EmpDetailsBll EmpBl { get; set; }
        public EmpDetails()
        {
           InitializeComponent();
           this.EmpBl = new EmpDetailsBll();
            //this.da = new EmpDetailsDal();
            string query2 = "select * from [dbo].[user] where role='Cashier';";
             this.PopulatGridView(query2);

          //  this.PopulateGridView();
        }

         private void PopulateGridView()
         {

             this.dgvEmp.AutoGenerateColumns = false;
             this.dgvEmp.DataSource = EmpBl.GetAll().ToString();
             this.dgvEmp.ClearSelection();
             this.dgvEmp.Refresh();
         }

       private void PopulatGridView(string sql)
        {
            DataSet ds = EmpDetailsDal.ExecuteQuery(sql);
            this.dgvEmp.AutoGenerateColumns = false;
            this.dgvEmp.DataSource = ds.Tables[0];

        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminHome admin = new AdminHome();
            this.Visible = false;
            admin.Visible = true;
        }

        private void EmpDetails_Load(object sender, EventArgs e)
        {
             this.PopulateGridView();
            string query2 = "select * from [dbo].[user] where role='Cashier';";
            this.PopulatGridView(query2);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            bl.name = txtName.Text;
            bl.password = txtPassword.Text;
            bl.address = txtAddress.Text;
            bl.phone = txtPhone.Text;
            bl.email = txtEmail.Text;
            bl.gender = cmbGender.Text;

       int i = da.CreateAccount(bl, dal);
            if (i > 0)
            {
                MessageBox.Show("account successfully Created");
            }
            else
            {
                MessageBox.Show("Error");
            }
     
            EmpDetails man = new EmpDetails();
            this.Visible = false;
            man.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvEmp.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please Select A Row First");
                return;
            }

            if (MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            string userid = this.dgvEmp.CurrentRow.Cells["userid"].Value.ToString();
            bool decision = bl.Delete(userid);

            if (decision)
            {
                MessageBox.Show("Delete Confirmed.");
                this.PopulateGridView();
            }
            else
            {
                MessageBox.Show("Invalid Id.");
            }

            EmpDetails man = new EmpDetails();
            this.Visible = false;
            man.Visible = true;

        }

        private void dgvEmp_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            i = Convert.ToInt32(dgvEmp.SelectedRows[0].Cells[0].Value);
            txtName.Text = dgvEmp.SelectedRows[0].Cells[1].Value.ToString();
            txtPassword.Text = dgvEmp.SelectedRows[0].Cells[2].Value.ToString();
            txtAddress.Text = dgvEmp.SelectedRows[0].Cells[3].Value.ToString();
          
            txtPhone.Text = dgvEmp.SelectedRows[0].Cells[4].Value.ToString();
            txtEmail.Text = dgvEmp.SelectedRows[0].Cells[5].Value.ToString();

            cmbGender.Text = dgvEmp.SelectedRows[0].Cells[6].Value.ToString();
            dtpJoin.Text = dgvEmp.SelectedRows[0].Cells[7].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection scon = new SqlConnection(cs);
            string query = "UPDATE [dbo].[user] SET name = @name, password = @password, address = @address, phone = @phone, email = @email, gender = @gender, joiningdate = @joiningdate where userid = @id ;";

            SqlCommand cmd = new SqlCommand(query, scon);
            cmd.Parameters.AddWithValue("@id", i);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@password", txtPassword.Text);
           
            cmd.Parameters.AddWithValue("@address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
           
            cmd.Parameters.AddWithValue("@gender", cmbGender.Text);
            cmd.Parameters.AddWithValue("@joiningdate", dtpJoin.Text);
            scon.Open();

            int j = cmd.ExecuteNonQuery();
            if (j > 0)
            {
                MessageBox.Show("Account successfully Updated");
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
            EmpDetails man = new EmpDetails();
            this.Visible = false;
            man.Visible = true;
        }

     
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            string query = "select * from [dbo].[user] where role='Cashier' and name like'"+ this.txtSearch.Text +"%';";
            this.PopulatGridView(query);
        }
    }
}
