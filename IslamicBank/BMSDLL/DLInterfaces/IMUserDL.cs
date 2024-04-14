using BMS.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.DLInterfaces
{
    public interface IMUserDL
    {
        bool SignIn(MUser user);
        bool SignUp(MUser user);
        void LoadData();
        void StoreCurrentUser(MUser user);
        MUser GetCurrentUser();
        bool UpdateUserInfo(MUser user, string prevUserName);
         bool SaveUserInfo(MUser user);
    }
}
