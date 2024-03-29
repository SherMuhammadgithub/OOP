using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.BL
{
    internal class MUser
    {
        private string username;
        private string password;
        private string role;

        // for sign up
        public MUser(string username, string password, string role)
        {
            this.username = username;
            this.password = password;
            this.role = role;
        }
        // for sign in
        public MUser(string uesr, string password)
        {
             username = uesr;
            this.password = password;
        }
        public string GetUsername()
        {
            return username;
        }
        public string GetPassword()
        {
            return password;
        }
        public string GetRole()
        {
            return role;
        }

        // checking if the user is admin or not

        public bool IsAdmin()
        {
            // ignore the upper and lower case
            if (role.ToLower() == "admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
