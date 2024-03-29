using BMS.BL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.DL
{
    internal class MUserDL
    {
        public static List<MUser> users = new List<MUser>();
        public static void AddUser(MUser user)
        {
            users.Add(user);
        }
        public static bool SignIn(MUser user)
        {
            // check if the user is in the list
            foreach (MUser u in users)
            {
                if (u.GetUsername() == user.GetUsername() && u.GetPassword() == user.GetPassword())
                {
                    return true;
                }
            }
            return false;
        }
        public static bool SignUp(MUser user)
        {
            // check if the user is in the list
            foreach (MUser u in users)
            {
                if (u.GetUsername() == user.GetUsername())
                {
                    return false;
                }
            }
            AddUser(user); 
            
            return true;
        }

        public static bool LoadData()
        {
            string Query = "SELECT * FROM BMSUsers";
            DataTable dt = Function.GetData(Query);
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    MUser user = new MUser(row["Name"].ToString(), row["Password"].ToString(), row["Role"].ToString());
                    AddUser(user);
                }
                return true;
            }
            return false;

        }
    }
}
