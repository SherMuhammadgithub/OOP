using BMS.BL;
using BMS.DLInterfaces;
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
    internal class MUserDB : IMUserDL
    {
        public  static List<MUser> users = new List<MUser>();
        public  MUser currentUser;
        public  void AddUser(MUser user)
        {
            users.Add(user);
        }
        public  bool SignIn(MUser user)
        {
            foreach (MUser u in users)
            {
                if (u.GetUsername() == user.GetUsername() && u.GetPassword() == user.GetPassword())
                {
                    return true;
                }
            }
            return false;
        }
        public  bool SignUp(MUser user)
        {
            foreach (MUser u in users)
            {
                if (u.GetUsername() == user.GetUsername())
                {
                    return false;
                }
            }
            return true;
        }

        public  void LoadData()
        {
            string Query = "SELECT * FROM BMSUsers";
            DataTable dt = utills.GetData(Query);
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    MUser user = new MUser(row["Name"].ToString(), row["Password"].ToString(), row["Role"].ToString());
                    AddUser(user);
                }
            }

        }
       public  void StoreCurrentUser(MUser user)
        {
             currentUser = user; 
        }
        public  MUser GetCurrentUser()
        {
            return currentUser; // this was changed from static to instance
        }
        // updating in database
        public  bool UpdateUserInfo(MUser user, string prevUserName)
        {
            string Query = $"UPDATE BMSUsers SET Name = '{user.GetUsername()}', Password = '{user.GetPassword()}' WHERE Name = '{prevUserName}'";
            int rowsAffected = utills.SetData(Query);
            if (rowsAffected > 0)
            {
                return true;
            }
            return false;
        }
        public bool SaveUserInfo(MUser user)
        {
            string Query = "INSERT INTO BMSUsers (Name, Password, Role) VALUES ('{0}','{1}','{2}')";
            Query = string.Format(Query, user.GetUsername(), user.GetPassword(), user.GetRole());
            int isStored = utills.SetData(Query);
            if (isStored > 0) // rowsAffected
            {
                AddUser(user); // add user to the list
                return true;
            }
            return false;
        }   
    }
}
