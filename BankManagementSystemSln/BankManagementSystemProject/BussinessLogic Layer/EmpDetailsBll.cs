using System;
using System.Collections.Generic;
using System.IO;
using System.Data;
using BankManagementSystemProject.DataAccess_Layer;
using BankManagementSystemProject.Entity_Layer;
using BankManagementSystemProject.BussinessLogic_Layer;
using BankManagementSystemProject.Presentation_Layer;


namespace BankManagementSystemProject.BussinessLogic_Layer
{
  public class EmpDetailsBll
    {
        public EmpDetailsDal da = new EmpDetailsDal();


        // EmpDetailsDal emdal = new EmpDetailsDal();

        public List<EmpDetailsEl> GetAll()
        {
            var empEl = new List<EmpDetailsEl>();
            var sql = "select * from [dbo].[user] where role='Cashier';";
            var dt = EmpDetailsDal.GetDataTable(sql);
            for (int index = 0; index < dt.Rows.Count; index++)
            {
                EmpDetailsEl e = ConvertToEntity(dt.Rows[index]);
                empEl.Add(e);
            }
            return empEl;
        }
        private EmpDetailsEl ConvertToEntity(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            var e = new EmpDetailsEl()
            {
                userid = Convert.ToInt32(row["userid"].ToString()),
                password = row["password"].ToString(),
                name = row["name"].ToString(),
                role = row["role"].ToString(),
                address = row["address"].ToString(),
                phone = row["phone"].ToString(),
                email = row["email"].ToString(),
                gender = row["gender"].ToString(),
                joiningdate = row["joiningdate"].ToString(),
               
            };
           
            return e;
        }

        public int CreateAccount(EmpDetailsEl bl, LoginDal dal)
        {
            
            int i = 0;
            string query = "INSERT INTO [dbo].[user] (name,password,role,address,phone,email,gender,joiningdate) VALUES (' " + bl.name + " ',' " + bl.password + " ','Cashier',' " + bl.address + " ',' " + bl.phone + " ',' " + bl.email + " ',' " + bl.gender + "',' " + bl.joiningdate + " ');";
           // SqlCommand cmd = new SqlCommand(query,con);
            MemoryStream stream1 = new MemoryStream();
            MemoryStream stream2 = new MemoryStream();
           
            byte[] p1 = stream1.ToArray();
            byte[] p2 = stream2.ToArray();
           
            return i;

        }
        public bool Delete(string id)
        {
            string query = "select * from [dbo].[user] where userid = '" + id + "'";
            var dt = EmpDetailsDal.GetDataTable(query);

            if (dt == null || dt.Rows.Count == 0)
            {
                return false;
            }

            query = "delete from [dbo].[user] where userid = '" + id + "'";
            int count = EmpDetailsDal.ExecuteUpdateQuery(query);
            if (count == 1)
                return true;
            else
                return false;
        }





  








        public string name { get; set; }
        public string password { get; set; }
        public string role { get; set; }
   
        public string address { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public string joiningdate { get; set; }
      
    }
}
