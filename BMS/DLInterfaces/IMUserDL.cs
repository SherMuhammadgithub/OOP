using BMS.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.DLInterfaces
{
    internal interface IMUserDL
    {
        bool SignIn(MUser user);
        bool SignUp(MUser user);
        void LoadData();
        void StoreCurrentUser(MUser user);
        MUser GetCurrentUser();
        void UpdateUserInfo(MUser user, string prevUserName);
         void SaveUserInfo(MUser user);
    }
}
