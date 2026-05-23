using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplication
{
    public class Cashier : UserAccount
    {
        private string department;

        public Cashier(string name, string department, string userName, string password) 
            : base(name, userName, password)
        { 
            this.department = department;
        }
        public override bool validateLogin(string userName, string password)
        {
            return (user_name == userName && user_password  == password);
        }
        public string getDepartmet() { return department; }
    }
}
