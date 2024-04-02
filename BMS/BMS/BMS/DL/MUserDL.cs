using BMS.BL;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BMS.DL
{
    internal class MUserDL
    {
        public static List<MUser> users = new List<MUser>();
        public static MUser currentUser;
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
       public static void StoreCurrentUser(MUser user)
        {
             currentUser = user; //  store the current user
        }
        // get the current user
        public static MUser GetCurrentUser()
        {
            return MUserDL.currentUser;
        }
        public static void UpdateUserInfo(MUser user, string prevUserName)
        {
            string Query = $"UPDATE BMSUsers SET Name = '{user.GetUsername()}', Password = '{user.GetPassword()}' WHERE Name = '{prevUserName}'";
            int rowsAffected = Function.SetData(Query);
            if (rowsAffected > 0)
            {
                Console.WriteLine("User updated");
            }
        }
        // perform updation on List of users
        public static void UpdateUserList(MUser user, string prevUserName)
        {
            foreach (MUser u in users)
            {
                if (u.GetUsername() == prevUserName)
                {
                    MessageBox.Show("Matchings");
                    MessageBox.Show(u.GetUsername());
                    u.SetUsername(user.GetUsername());
                    u.SetPassword(user.GetPassword());
                    StoreCurrentUser(user);
                    break;
                }
            }
        }
    }
}
