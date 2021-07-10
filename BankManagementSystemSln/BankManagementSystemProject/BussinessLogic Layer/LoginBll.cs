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


namespace BankManagementSystemProject.BussinessLogic_Layer
{
   public class LoginBll
    {
        public string UserId { get; set; }
       // public string user { get
           // { return this.UserId; } set { this.UserId = value; } }

        public  string password { get; set; }
        public  string name { get; set; }
        public  string balace { get; set; }
        public  string deposited { get; set; }
        public  string withdrawn { get; set; }
        public Image image { get; set; }

        public byte[]  signeture = null;

    }
}
