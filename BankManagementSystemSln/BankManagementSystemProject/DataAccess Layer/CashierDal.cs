
using System.Data;
using System.Data.SqlClient;
using BankManagementSystemProject.BussinessLogic_Layer;


namespace BankManagementSystemProject.DataAccess_Layer
{
   public class CashierDal
    {

       
        public static SqlCommand Sqlcom
        {
            get; set;
    
        }

      
        public static SqlDataAdapter Sda
        {
            get; set;
         
        }

        public static DataSet Ds
        {
            get; set;

        }


        public static SqlConnection con
        { get; set; }

        public CashierDal()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-B8VRR0I;Initial Catalog=BankProject;Persist Security Info=True;User ID=sa;Password=nms1651997");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
      /*  public int CreateAccount(AccDetailsBll bl, LoginDal dal)
        {
            int i = 0;
            string query = "INSERT INTO [dbo].[user] (name,password,role,accounttype,address,phone,email,nid,gender,dob,balance,deposited,withdrawn,signeture,image) VALUES ('" + bl.name + "','" + bl.password + "','Customer','" + bl.accounttype + "','" + bl.address + "','" + bl.phone + "','" + bl.email + "','" + bl.nid + "','" + bl.gender + "','" + bl.dob + "','" + bl.balance + "','" + bl.deposited + "','" + bl.withdrawn + "',@Sig,@Pict);";
            SqlCommand cmd = new SqlCommand(query, con);
            MemoryStream stream1 = new MemoryStream();
            MemoryStream stream2 = new MemoryStream();
            bl.signeture.Save(stream1, System.Drawing.Imaging.ImageFormat.Jpeg);
            bl.image.Save(stream2, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] p1 = stream1.ToArray();
            byte[] p2 = stream2.ToArray();
            cmd.Parameters.AddRange(new[]
                {
                     new SqlParameter("@Sig", p1),
                     new SqlParameter("@Pict", p2)
                });
            i = cmd.ExecuteNonQuery();
            con.Close();
            return i;

        }*/

        private static void QueryText(string query)
        {
            Sqlcom = new SqlCommand(query, con);
        }
        public static DataSet ExecuteQuery(string sql)
        {
            QueryText(sql);
            Sda = new SqlDataAdapter(Sqlcom);
            Ds = new DataSet();
            Sda.Fill(Ds);
            return Ds;
        }

        public static int ExecuteUpdateQuery(string sql)
        {
            QueryText(sql);
            int u = Sqlcom.ExecuteNonQuery();
            return u;
        }

        public static DataSet GetDataSet(string query)
        {
            SqlCommand sqcom = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(sqcom);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }

        public static DataTable GetDataTable(string query)
        {
            var ds = GetDataSet(query);
            if (ds.Tables.Count > 0)
            {
                return ds.Tables[0];
            }
            return null;
        }



        public int Deposit(CashierBll bl)
        {
            int i = 0;
          


            string query = string.Format("UPDATE [dbo].[user] SET deposited='{0}', balance='{1}' WHERE userid ='{2}' AND role='Customer'", bl.deposited, bl.balance, bl.userid);
           
            SqlCommand cmd = new SqlCommand(query, con);
           
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
     

            i = cmd.ExecuteNonQuery();


            //con.Close();

            return i;
          
        }

        public int Withdraw(CashierBll bl)
        {
            int i = 0;



            string query = string.Format("UPDATE [dbo].[user] SET withdrawn='{0}', balance='{1}' WHERE userid ='{2}' AND role='Customer'", bl.withdrawn, bl.balance, bl.userid);

            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataAdapter sa = new SqlDataAdapter(cmd);


            i = cmd.ExecuteNonQuery();


            //con.Close();

            return i;

        }

        public DataTable UserDetails(CashierBll u)
        {
            string query = string.Format("Select * from [dbo].[user] where userid='{0}' and role='Customer'", u.userid);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
           // con.Close();
            return dt;
        }

        public DataTable UserDetails1(CashierBll u)
        {
            string query = string.Format("Select * from [dbo].[user] where userid='{0}' and role='Customer'", u.userid);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
          //  con.Close();
            return dt;
        }
        public DataTable UserDetails2(CashierBll u)
        {
            string query = string.Format("Select * from [dbo].[user] where userid='{0}' and role='Customer'", u.userid1);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
           // con.Close();
            return dt;
        }
        public int Transfer(CashierBll bl)
        {
            int i = 0;
            int j = 0;


            string query = string.Format("UPDATE [dbo].[user] SET withdrawn='{0}', balance='{1}' WHERE userid ='{2}' AND role='Customer'" , bl.withdrawn, bl.balance, bl.userid);
            string query1 = string.Format("UPDATE [dbo].[user] SET deposited='{0}', balance='{1}' WHERE userid ='{2}' AND role='Customer'" , bl.deposited, bl.balance1, bl.userid1);

            SqlCommand cmd = new SqlCommand(query, con);
            SqlCommand cmd1 = new SqlCommand(query1, con);

            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            SqlDataAdapter sa1 = new SqlDataAdapter(cmd1);

            i = cmd.ExecuteNonQuery();
            j = cmd1.ExecuteNonQuery();



            return i;
            return j;
        }

    }
}
