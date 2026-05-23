using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplication
{
    public class UserAccount
    {
        private string full_name;
        protected string user_name;
        protected string user_password;

        public UserAccount(string name, string userName, string password) { 
            full_name = name;
            user_name = userName;
            user_password = password;
        }

        public virtual bool validateLogin(string userName, string password)
        {
            return (user_name == userName && user_password == password);
        }

        public string getFullName()
        {
            return full_name;
        }
    }
}
