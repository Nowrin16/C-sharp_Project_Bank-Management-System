using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BankManagementSystemProject.BussinessLogic_Layer;
using BankManagementSystemProject.DataAccess_Layer;

namespace BankManagementSystemProject.DataAccess_Layer
{
    public class LoginDal
    {
        SqlConnection con;
        public LoginDal()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-B8VRR0I;Initial Catalog=BankProject;Persist Security Info=True;User ID=sa;Password=nms1651997");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public DataTable login(LoginBll da)
        {

            DataTable dt = new DataTable();

            String query = ("select * from [dbo].[user] where userid= '" + da.UserId + "' and password='" + da.password + "'");
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            sda.Fill(dt);
            con.Close();
            return dt;




        }


        public DataTable UserDetails(LoginBll bl)
        {
            string query = string.Format("Select * from [dbo].[user] where userid='{0}'", bl.UserId);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            con.Close();
            return dt;
        }


    }
}