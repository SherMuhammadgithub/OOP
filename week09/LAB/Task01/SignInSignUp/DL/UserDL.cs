using SignInSignUp.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SignInSignUp.DL
{
    internal class UserDL
    {
        private static List<UserBL> userList = new List<UserBL>();
        public static void AddUser(UserBL user)
        {
            userList.Add(user);
            userList.Add(user);
        }
        public static UserBL SignIn(UserBL userToCheck)
        {
            foreach(UserBL user in userList)
            {
                if(user.getUserName() == userToCheck.getUserName()&& user.getPassword() == userToCheck.getPassword())
                {
                    return user;
                }
            }
            return null;

        }
        public static string ParseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int i = 0; i < record.Length; i++)
            {
                if (record[i] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item += record[i];
                }
            }
            return item;
        }
        public static bool readDataFromFile(string path)
        {
            try
            {
                string[] lines = System.IO.File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    string userName = ParseData(line, 1);
                    string password = ParseData(line, 2);
                    string role = ParseData(line, 3);
                    UserBL user = new UserBL(userName, password, role);
                    AddUser(user);
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public static bool StoreUserToFile(UserBL user, string path)
        {
            StreamWriter file = new StreamWriter(path, true);
            try
            {
                file.WriteLine(user.getUserName() + "," + user.getPassword() + "," + user.getRole());
                file.Flush();
                file.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        
    }
}
