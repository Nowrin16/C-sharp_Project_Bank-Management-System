using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using BankManagementSystemProject.Entity_Layer;
using BankManagementSystemProject.DataAccess_Layer;
using BankManagementSystemProject.Presentation_Layer;


namespace BankManagementSystemProject.BussinessLogic_Layer
{
   public class AccDetailsBll
    {



        public bool Delete(string id)
        {
            string query = "select * from [dbo].[user] where userid = '" + id + "'";
            var dt = AccDetailsDal.GetDataTable(query);

            if (dt == null || dt.Rows.Count == 0)
            {
                return false;
            }

            query = "delete from [dbo].[user] where userid = '" + id + "'";
            int count = AccDetailsDal.ExecuteUpdateQuery(query);
            if (count == 1)
                return true;
            else
                return false;
        }




        public List<AccDetailsEl> GetAll()
        {
            var accEl = new List<AccDetailsEl>();
            var sql = "select * from [dbo].[user] where role='Customer';";
            var dt = EmpDetailsDal.GetDataTable(sql);
            for (int index = 0; index < dt.Rows.Count; index++)
            {
                AccDetailsEl e = ConvertToEntity(dt.Rows[index]);
                accEl.Add(e);
            }
            return accEl;
        }
        private AccDetailsEl ConvertToEntity(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            var e = new AccDetailsEl()
            {
                userid = Convert.ToInt32(row["userid"].ToString()),
                password = row["password"].ToString(),
                name = row["name"].ToString(),
                role = row["role"].ToString(),
                address = row["address"].ToString(),
                phone = row["phone"].ToString(),
                email = row["email"].ToString(),
                gender = row["gender"].ToString(),
                dob= row["dob"].ToString(),

            };

            return e;
        }

        public int CreateAccount(AccDetailsEl bl, LoginDal dal)
        {

            int i = 0;
            string query = "INSERT INTO [dbo].[user] (name,password,role,address,phone,email,gender,dob) VALUES (' " + bl.name + " ',' " + bl.password + " ','Customer',' " + bl.address + " ',' " + bl.phone + " ',' " + bl.email + " ',' " + bl.gender + "',' " + bl.dob + " ');";
            // SqlCommand cmd = new SqlCommand(query,con);
            MemoryStream stream1 = new MemoryStream();
            MemoryStream stream2 = new MemoryStream();

            byte[] p1 = stream1.ToArray();
            byte[] p2 = stream2.ToArray();

            return i;

        }















        public AccDetailsDal da = new AccDetailsDal();
        public string name { get; set; }
        public string password { get; set; }
        public string role { get; set; }
        public string accountno { get; set; }
        public string accounttype { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string nid { get; set; }
        public string gender { get; set; }
        public string dob { get; set; }
        public float balance { get; set; }
        public float deposited { get; set; }
        public float withdrawn { get; set; }
        public Image image { get; set; }
        public Image signeture { get; set; }



 }
}
