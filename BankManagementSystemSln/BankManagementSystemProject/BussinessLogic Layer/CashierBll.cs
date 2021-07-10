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
using BankManagementSystemProject.Entity_Layer;
using BankManagementSystemProject.DataAccess_Layer;
using BankManagementSystemProject.Presentation_Layer;


namespace BankManagementSystemProject.BussinessLogic_Layer
{
   public class CashierBll
    {


        public List<CashierEl> GetAll()
        {
            var accEl = new List<CashierEl>();
            var sql = "select * from [dbo].[user] where role='Customer';";
            var dt = CashierDal.GetDataTable(sql);
            for (int index = 0; index < dt.Rows.Count; index++)
            {
                CashierEl e = ConvertToEntity(dt.Rows[index]);
                accEl.Add(e);
            }
            return accEl;
        }
        private CashierEl ConvertToEntity(DataRow row)
        {
            if (row == null)
            {
                return null;
            }
            var e = new CashierEl()
            {
                userid = Convert.ToInt32(row["userid"].ToString()),
                password = row["password"].ToString(),
                name = row["name"].ToString(),
                role = row["role"].ToString(),
                address = row["address"].ToString(),
                phone = row["phone"].ToString(),
                email = row["email"].ToString(),
                gender = row["gender"].ToString(),
                dob = row["dob"].ToString(),

            };

            return e;
        }




        public CashierDal da = new CashierDal();
        public int userid { get; set; }
        public int userid1 { get; set; }

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
        public float balance1 { get; set; }
        public float deposited { get; set; }
        public float withdrawn { get; set; }
        public Image image { get; set; }
        public Image signeture { get; set; }



    }
}
