using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Credentials01
{
    internal class Credentials
    {
        public List <Credentials> users = new List <Credentials> ();    
        public string path = "C:\\Users\\dell\\Pictures\\MyBank_data\\my.txt";
        public string name;
        public string password;
        public string role;


        public bool SignUp(string user_name, string pass, string role)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[ i ].name.Contains(user_name))
                {
                    return false;
                }
            }
            Credentials add_user = new Credentials();
            add_user.name = user_name;
            add_user.password = pass;
            add_user.role = role;
            users.Add(add_user);
            return true;
        }

        public  bool login(string user_name, string pass)
        {
            if (users.Exists(member =>  member.name == user_name && member.password == pass))
            {
                return true;
            }
            return false;
        }

        public void readData()
        {
            if (File.Exists(path))
            {
                StreamReader fileVar = new StreamReader(path);
                string record;
                while ((record = fileVar.ReadLine()) != null)
                {
                    Credentials info = new Credentials();
                    info.name = parseData(record, 1);
                    info.password = parseData(record, 2);
                    info.role = parseData(record, 3);
                    users.Add(info);
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
        public void saveData()
        {
                StreamWriter file = new StreamWriter(path);
            foreach(var user in users)
            {
                file.WriteLine(user.name + "," + user.password + "," + user.role);
                file.Flush();
            }
                file.Close();
        }
        public bool DeleteUser(string user_to_delete)
        {
          try
            {
                users.RemoveAll(user => user.name == user_to_delete);
                return true;
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
            }
            
            return false;
            
        }
        public void ViewUsers()
        {
            Console.WriteLine(".................Users..........................");
            foreach(var user in users)
            {
                if(user.role == "user")
                {
                Console.WriteLine($"{user.name}\t{user.role}");
                }
            }
        }
        public bool UpdateUser(string user_to_update)
        {
            Console.WriteLine("Enter new name: ");
            string new_name = Console.ReadLine();
            Console.WriteLine("Enter new password: ");
            string new_password = Console.ReadLine();
            foreach(var user in users)
            {
                if(user.name == user_to_update)
                {
                    user.name = new_name;
                    user.password = new_password;
                    return true;
                }
            }
            return false;
        }
        public bool UserExists(string user_name)
        {
            if(users.Exists(user => user.name == user_name))
            {
                return true;
            }
            return false;
        }
        public bool IsAdmin(string user_name)
        {
            if(users.Exists(u => u.name == user_name && u.role == "admin"))
            {
                return true;
            }

            return false;
        }
    }
}
