using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Credentials01
{
    internal class UserManager
    {
        private List<User> users;
        public UserManager()
        {
            users = new List<User>();
        }
        public bool SignUp(string user_name, string pass, string role)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].name.Contains(user_name))
                {
                    return false;
                }
            }
            User user = new User(user_name, pass, role);
            users.Add(user);
            return true;
        }
        public bool login(string user_name, string pass)
        {
            if (users.Exists(member => member.name == user_name && member.password == pass))
            {
                return true;
            }
            return false;
        }
        public void readData(string path)
        {
            if (File.Exists(path))
            {
                StreamReader fileVar = new StreamReader(path);
                string record;
                while ((record = fileVar.ReadLine()) != null)
                {
                    User user;
                    string name = parseData(record, 1);
                    string password = parseData(record, 2);
                    string role = parseData(record, 3);
                    user = new User(name, password, role);
                    users.Add(user);
                }
                fileVar.Close();

            }
            else
            {
                Console.WriteLine("File Not Exists");
            }
        }
        public string parseData(string record, int field)
        {
            int count = 0;
            string result = "";
            for (int i = 0; i < record.Length; i++)
            {
                if (record[i] != ',')
                {
                    result += record[i];
                }
                else
                {
                    count++;
                    if (count == field)
                    {
                        return result;
                    }
                    result = "";
                }
            }
            return result; // Extra
        }
        public void saveData(string path)
        {
            StreamWriter file = new StreamWriter(path);
            foreach (var user in users)
            {
                file.WriteLine(user.name + "," + user.password + "," + user.role);
                file.Flush();
            }
            file.Close();
        }
        public bool IsAdmin(string user_name)
        {
            if (users.Exists(u => u.name == user_name && u.role == "admin"))
            {
                return true;
            }

            return false;
        }
        public void ViewUser()
        {
            Console.WriteLine(".................Users..........................");
            foreach (var user in users)
            {
                if (user.role == "user")
                {
                    Console.WriteLine($"{user.name}\t{user.role}");
                }
            }
        }
        public bool DeleteUser(string user_name)
        {
            User user_to_delete = users.Find(user => user.name.Equals(user_name, StringComparison.OrdinalIgnoreCase));
            if (user_to_delete != null)
            {
                users.Remove(user_to_delete);
                return true;
            }
            return false;
        }
    }
}
