using BMS.BL;
using BMS.DLInterfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BMS.DL.FH
{
    internal class MUserFH : IMUserDL
    {
        public static List<MUser> users = new List<MUser>();
        public MUser currentUser;
        public void SaveUserInfo(MUser user)
        {
            users.Add(user);
            // saving to file
            SaveDataToFile(user);
        }
        public bool SignIn(MUser user)
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
        public bool SignUp(MUser user)
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
       // loading from file
        public  void LoadData()
        {
           try
            {
                using (StreamReader reader = new StreamReader("user.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');
                        MUser user = new MUser(data[0], data[1], data[2]);
                        // add to list
                       users.Add(user);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void StoreCurrentUser(MUser user)
        {
            currentUser = user;
        }
        public MUser GetCurrentUser()
        {
            return currentUser;
        }
         // updating in file
        public void UpdateUserInfoInFile(MUser user, string prevUserName)
        {
            string usersFile = "user.txt";

            try
            {
                List<string> updatedLines = new List<string>();

                 // Read all lines from the file
                using (StreamReader reader = new StreamReader(usersFile))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');
                        if (data[0] == prevUserName)
                        {
                            string updatedLine = string.Join(",", user.GetUsername(), user.GetPassword(), user.GetRole());
                            // Add updated line
                            updatedLines.Add(updatedLine);
                            break;
                        }
                        else
                        {
                            // Add original line if not updated
                            updatedLines.Add(line);  
                        }
                    }
                }

                // Write all lines back to the file
                using (StreamWriter writer = new StreamWriter(usersFile))
                {
                    foreach (string line in updatedLines)
                    {
                        writer.WriteLine(line);
                    }
                }

                MessageBox.Show("User information updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating user information: " + ex.Message);
            }
        }

        public void UpdateUserInfo(MUser user, string prevUserName)
        {
            foreach (MUser u in users)
            {
                if (u.GetUsername() == prevUserName)
                {
                    MessageBox.Show("Matchings");
                    MessageBox.Show(u.GetUsername());
                    u.SetUsername(user.GetUsername());
                    u.SetPassword(user.GetPassword());
                    u.SetRole(user.GetRole());
                    StoreCurrentUser(user);
                    // updating in file
                    UpdateUserInfoInFile(user, prevUserName);
                    break;
                }
            }
        }
        // saving to file
     public void SaveDataToFile(MUser user)
        {
            try
            {
                using(StreamWriter writer = new StreamWriter("user.txt", true)) // true to append
                {
                    writer.WriteLine($"{user.GetUsername()},{user.GetPassword()},{user.GetRole()}");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
