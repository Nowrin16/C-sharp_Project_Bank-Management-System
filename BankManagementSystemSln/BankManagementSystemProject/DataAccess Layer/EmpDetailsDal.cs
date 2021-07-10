
using System.Data;
using System.Data.SqlClient;
using BankManagementSystemProject.BussinessLogic_Layer;
using BankManagementSystemProject.DataAccess_Layer;
using BankManagementSystemProject.Presentation_Layer;
using BankManagementSystemProject.Entity_Layer;
using System.IO;

namespace BankManagementSystemProject.DataAccess_Layer
{
   public class EmpDetailsDal
    {

        /* private static SqlConnection sqlCon;

         public static SqlConnection SqlCon
         {
             get
             {
                 if (sqlCon == null)
                 {
                     sqlCon = new SqlConnection(@"Data Source=DESKTOP-B8VRR0I;Initial Catalog=BankProject;Persist Security Info=True;User ID=sa;Password=nms1651997");
                 }
                 else if (sqlCon.State != ConnectionState.Open)
                 {
                     sqlCon.Open();
                 }
                 return sqlCon;
             }
         }

         private static DataSet GetDataSet(string query)
         {
             SqlCommand sqcom = new SqlCommand(query, SqlCon);
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

         public static int ExecuteUpdateQuery(string query)
         {
             SqlCommand sqcom = new SqlCommand(query, SqlCon);
             return sqcom.ExecuteNonQuery();
         }*/


        /* private  SqlConnection sqlcon;
         public  SqlConnection Sqlcon
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

         public EmpDetailsDal()
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
         }

       private  DataSet GetDataSet(string query)
       {
           SqlCommand sqcom = new SqlCommand(query, this.Sqlcon);
           SqlDataAdapter sda = new SqlDataAdapter(sqcom);
           DataSet ds = new DataSet();
           sda.Fill(ds);
           return ds;
       }

       public  DataTable GetDataTable(string query)
       {
           var ds = GetDataSet(query);
           if (ds.Tables.Count > 0)
           {
               return ds.Tables[0];
           }
           return null;
       }*/

       // private SqlCommand sqlcom;
        public static SqlCommand Sqlcom
        {
            get; set;
           // get { return sqlcom; }
           // set { sqlcom = value; }
        }

       // private SqlDataAdapter sda;
        public static SqlDataAdapter Sda
        {
            get; set;
           // get { return sda; }
           // set { sda = value; }
        }

        //private DataSet ds;
        public static DataSet Ds
        {
            get; set;
           // get { return ds; }
            //set { ds = value; }
        }


        public static SqlConnection con
        { get; set; }


        public EmpDetailsDal()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-B8VRR0I;Initial Catalog=BankProject;Persist Security Info=True;User ID=sa;Password=nms1651997");
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
       public int CreateAccount(EmpDetailsBll bl, LoginDal dal)
        {
            int i = 0;
            string query = "INSERT INTO [dbo].[user] (name,password,role,address,phone,email,gender,joiningdate) VALUES ('"+bl.name+"','"+bl.password+ "','Cashier','" + bl.address + "','" + bl.phone + "','" + bl.email + "','" + bl.gender + "','" + bl.joiningdate + "');";
            SqlCommand cmd = new SqlCommand(query, con);
            MemoryStream stream1 = new MemoryStream();
            MemoryStream stream2 = new MemoryStream();
           // bl.signeture.Save(stream1, System.Drawing.Imaging.ImageFormat.Jpeg);
           // bl.image.Save(stream2, System.Drawing.Imaging.ImageFormat.Jpeg);
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
            SqlCommand sqcom = new SqlCommand(query,con);
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

    }
}
