
using System.Data;
using System.Data.SqlClient;
using BankManagementSystemProject.BussinessLogic_Layer;
using BankManagementSystemProject.DataAccess_Layer;
using BankManagementSystemProject.Presentation_Layer;
using System.IO;

namespace BankManagementSystemProject.DataAccess_Layer
{
   public class AccDetailsDal
    {
        /*SqlConnection con;
        public AccDetailsDal()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-B8VRR0I;Initial Catalog=BankProject;Persist Security Info=True;User ID=sa;Password=nms1651997");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public DataTable UserDetails(AccDetailsBll u)
        {
            string query = string.Format("select * from [dbo].[user] where accountno ='{0}'", u.accountno);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sa = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            con.Close();
            return dt;
        }*/

        /* private SqlConnection sqlcon;
         public SqlConnection Sqlcon
         {
             get { return sqlcon; }
             set { sqlcon = value; }
         }

         private SqlCommand sqlcom;
         public SqlCommand Sqlcom
         {
             get { return sqlcom; }
             set { sqlcom = value; }
         }

         private SqlDataAdapter sda;
         public SqlDataAdapter Sda
         {
             get { return sda; }
             set { sda = value; }
         }

         private DataSet ds;
         public DataSet Ds
         {
             get { return ds; }
             set { ds = value; }
         }

         //internal DataTable dt;

         public AccDetailsDal()
         {
             //this.sqcon = new SqlConnection(WFAExer.Properties.Settings.Default.conStr);
             this.Sqlcon = new SqlConnection(@"Data Source=DESKTOP-B8VRR0I;Initial Catalog=BankProject;Persist Security Info=True;User ID=sa;Password=nms1651997");
             Sqlcon.Open();
         }

         private void QueryText(string query)
         {
             this.Sqlcom = new SqlCommand(query, this.Sqlcon);
         }

         public DataSet ExecuteQuery(string sql)
         {
             this.QueryText(sql);
             this.Sda = new SqlDataAdapter(this.Sqlcom);
             this.Ds = new DataSet();
             this.Sda.Fill(this.Ds);
             return Ds;
         }

         public int ExecuteUpdateQuery(string sql)
         {
             this.QueryText(sql);
             int u = this.Sqlcom.ExecuteNonQuery();
             return u;
         }*/


        
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

        public AccDetailsDal()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-B8VRR0I;Initial Catalog=BankProject;Persist Security Info=True;User ID=sa;Password=nms1651997");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public int CreateAccount(AccDetailsBll bl, LoginDal dal)
        {
            int i = 0;
   string query = "INSERT INTO [dbo].[user] (name,password,role,accounttype,address,phone,email,nid,gender,dob,balance,deposited,withdrawn,signeture,image) VALUES ('"+bl.name +"','"+bl.password+"','Customer','"+bl.accounttype+"','"+bl.address +"','"+bl.phone +"','"+bl.email+"','"+bl.nid+"','"+bl.gender+"','"+bl.dob+"','"+bl.balance+"','"+bl.deposited+"','"+bl.withdrawn +"',@Sig,@Pict);";
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

        }

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

       
        /*public DataTable UserDetailsAcc(AccDetailsBll u)
         {
             string query = string.Format("SELECT TOP(1000) [Account Number] FROM[Bank1].[dbo].[Users] where[Phone Number] = ' " + u.PhoneNumber + " ' and Address= ' " + u.Address + " ' and [Account Type]=' " + u.AccountType + " ' and [National Id]=' " + u.NationalId + " ' and DOB=' " + u.DOB + " ' and Email=' " + u.Email + " ' and Gender=' " + u.Gender + " ' and [Full Name]=' " + u.UserName + " '");
             SELECT TOP 1000 [userid]
       ,[password]
       ,[role]
       ,[name]
       ,[accounttype]
       ,[address]
       ,[phone]
       ,[email]
       ,[nid]
       ,[gender]
       ,[dob]
       ,[joiningdate]
       ,[balance]
       ,[deposited]
       ,[withdrawn]
       ,[signeture]
       ,[image]
         FROM[BankProject].[dbo].[user]
         SqlCommand cmd = new SqlCommand(query, con);
             SqlDataAdapter sa = new SqlDataAdapter(cmd);
             DataTable dt = new DataTable();
             sa.Fill(dt);
             // con.Close();
             return dt;
         }*/
    }
}
