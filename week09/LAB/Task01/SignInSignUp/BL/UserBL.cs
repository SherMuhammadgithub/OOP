using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignInSignUp.BL
{
    internal class UserBL
    {
        private string userName;
        private string password;
        private string role;

        public UserBL(string userName, string password, string role)
        {
            this.userName = userName;
            this.password = password;
            this.role = role;
        }
        public UserBL(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
            this.role = "N/A";
        }
        public string getUserName()
        {
            return userName;
        }
        public string getPassword()
        {
            return password;
        }
        public string getRole()
        {
            return role;
        }
        public bool isAdmin()
        {
            if (role == "Admin")
            {
                return true;
            }
            return false;
        }
    }
}
