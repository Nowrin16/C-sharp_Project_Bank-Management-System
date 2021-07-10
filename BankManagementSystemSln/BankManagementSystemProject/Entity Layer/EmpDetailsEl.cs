
using BankManagementSystemProject.BussinessLogic_Layer;
using BankManagementSystemProject.DataAccess_Layer;
using BankManagementSystemProject.Presentation_Layer;

namespace BankManagementSystemProject.Entity_Layer
{
   public class EmpDetailsEl
    {
        EmpDetailsDal da = new EmpDetailsDal();
        public int userid { get; set; }
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
