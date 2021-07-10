using System;

using System.Windows.Forms;

namespace BankManagementSystemProject.Presentation_Layer
{
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            EmpDetails emp = new EmpDetails();
            this.Visible = false;
            emp.Visible = true;
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            AccDetails acc = new AccDetails();
            this.Visible = false;
            acc.Visible = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Visible = false;
            log.Visible = true;
        }
    }
}
