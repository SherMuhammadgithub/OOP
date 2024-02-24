using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore_challenege02_
{
    internal class MUserDL
    {
        public List<MUser> mUsers;
       public  MUserDL()
        {
            mUsers = new List<MUser>();
        }   
        public bool SignUp(MUser mUser)
        {
            if (mUser != null)
            {
                if(mUsers.Exists(s => s.Name == mUser.Name))
                {
                    return false;
                }
                else
                {
                    mUsers.Add(mUser);
                    return true;
                }
            }
            return false;
        }
        public MUser Login(string name, string password)
        {
            foreach (MUser mUser in mUsers)
            {
                if (mUser.Name.Equals(name) && mUser.Password.Equals(password))
                {
                    return mUser;
                }
            }
            return null;
        } 
        public void ViewProfile(MUser mUser)
        {
            Console.WriteLine("Name: " + mUser.Name);
            Console.WriteLine("Password: " + mUser.Password);
        }


    }
}
