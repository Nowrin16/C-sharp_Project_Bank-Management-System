
using System.Drawing;
using BankManagementSystemProject.BussinessLogic_Layer;
using BankManagementSystemProject.DataAccess_Layer;
using BankManagementSystemProject.Presentation_Layer;


namespace BankManagementSystemProject.Entity_Layer
{
   public class AccDetailsEl
    {
        public AccDetailsDal da = new AccDetailsDal();
        public int userid { get; set; }

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
