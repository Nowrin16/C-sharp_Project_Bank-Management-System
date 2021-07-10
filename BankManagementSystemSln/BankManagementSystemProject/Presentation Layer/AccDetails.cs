using System;
using System.Data;
using System.Drawing;
using System.Configuration;
using System.Windows.Forms;
using System.Data.SqlClient;
using BankManagementSystemProject.BussinessLogic_Layer;
using BankManagementSystemProject.DataAccess_Layer;
using BankManagementSystemProject.Entity_Layer;


namespace BankManagementSystemProject.Presentation_Layer
{
    public partial class AccDetails : Form
    {
        public AccDetailsBll bl = new AccDetailsBll();
        public AccDetailsEl el = new AccDetailsEl();
        public AccDetailsDal da = new AccDetailsDal();
        public LoginDal dal = new LoginDal();
        public LoginBll dat = new LoginBll();
        public DataTable dt = new DataTable();
        
        string accnum;
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public int i { get;  set; }
        public AccDetails()
        {
            InitializeComponent();
            string query2 = "select * from [dbo].[user] where role='Customer';";
            this.PopulatGridView(query2);
        }
       

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminHome admin = new AdminHome();
            this.Visible = false;
            admin.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bl.name = txtName.Text;
         
            bl.deposited = 0;
            bl.withdrawn = 0;
            bl.balance = int.Parse(txtBalance.Text);
            

            bl.password = txtPass.Text;
            bl.address = txtAddress.Text;
            bl.phone = txtPhone.Text;
            bl.dob = dtpDOB.Text;
            bl.nid = txtNid.Text;
            bl.email = txtEmail.Text;
            bl.gender =cmbGender.Text;

            bl.accounttype = cmbAccType.Text;
            int i = da.CreateAccount(bl, dal);
            if (i > 0)
            {
                MessageBox.Show("account successfully Created");
            }
            else
            {
                MessageBox.Show("Error");
            }
       
            AccDetails man = new AccDetails();
            this.Visible = false;
            man.Visible = true;

        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            f.Title = "Select User's Picture";
            if (f.ShowDialog() == DialogResult.OK)
            {
                /*string picPath = f.FileName.ToString();
                textBox8.Text = picPath;
                pictureBox2.ImageLocation = picPath;*/
                bl.signeture = Image.FromFile(f.FileName);
                picBoxImage.ImageLocation = f.FileName.ToString();
            }
        }

        private void btnSigneture_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            f.Title = "Select User's Picture";
            if (f.ShowDialog() == DialogResult.OK)
            {
                /*string picPath = f.FileName.ToString();
                textBox8.Text = picPath;
                pictureBox2.ImageLocation = picPath;*/
                bl.image = Image.FromFile(f.FileName);
                picBoxSigneture.ImageLocation = f.FileName.ToString();
            }

        }
        private void PopulatGridView(string sql)
        {
            DataSet ds = AccDetailsDal.ExecuteQuery(sql);
            this.dgvAcc.AutoGenerateColumns = false;
            this.dgvAcc.DataSource = ds.Tables[0];

        }

        private void AccDetails_Load(object sender, EventArgs e)
        {
            string query2 = "select * from [dbo].[user] where role='Customer';";
            this.PopulatGridView(query2);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgvAcc.SelectedRows.Count != 1)
            {
                MessageBox.Show("Please Select A Row First");
                return;
            }

            if (MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            string userid = this.dgvAcc.CurrentRow.Cells["userid"].Value.ToString();
            bool decision = bl.Delete(userid);

            if (decision)
            {

                MessageBox.Show("Delete Confirmed.");
                
            }
            else
            {
                MessageBox.Show("Invalid Id.");
            }

            AccDetails man = new AccDetails();
            this.Visible = false;
            man.Visible = true;

        }

        private void dgvAcc_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            i = Convert.ToInt32(dgvAcc.SelectedRows[0].Cells[0].Value);
            txtName.Text = dgvAcc.SelectedRows[0].Cells[1].Value.ToString();
            txtPass.Text = dgvAcc.SelectedRows[0].Cells[2].Value.ToString();
            txtAddress.Text = dgvAcc.SelectedRows[0].Cells[4].Value.ToString();
            cmbAccType.Text = dgvAcc.SelectedRows[0].Cells[3].Value.ToString();
            txtPhone.Text = dgvAcc.SelectedRows[0].Cells[5].Value.ToString();
            txtEmail.Text = dgvAcc.SelectedRows[0].Cells[6].Value.ToString();
            txtNid.Text = dgvAcc.SelectedRows[0].Cells[7].Value.ToString();
            cmbGender.Text = dgvAcc.SelectedRows[0].Cells[8].Value.ToString();
            dtpDOB.Text = dgvAcc.SelectedRows[0].Cells[9].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            SqlConnection scon = new SqlConnection(cs);
            string query = "UPDATE [dbo].[user] SET name = @name, password = @password, accounttype = @accounttype, address = @address, phone = @phone, email = @email, nid = @nid, gender = @gender, dob = @dob where userid = @id ;";

            SqlCommand cmd = new SqlCommand(query,scon);
            cmd.Parameters.AddWithValue("@id",i);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@password", txtPass.Text);
            cmd.Parameters.AddWithValue("@accounttype", cmbAccType.Text);
            cmd.Parameters.AddWithValue("@address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@nid", txtNid.Text);
            cmd.Parameters.AddWithValue("@gender", cmbGender.Text);
            cmd.Parameters.AddWithValue("@dob", dtpDOB.Text);
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
         
            AccDetails man = new AccDetails();
            this.Visible = false;
            man.Visible = true;

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            string query = "select * from [dbo].[user] where role='Customer' and name like'" + this.txtSearch.Text + "%';";
            this.PopulatGridView(query);
        }

    
    }
}
