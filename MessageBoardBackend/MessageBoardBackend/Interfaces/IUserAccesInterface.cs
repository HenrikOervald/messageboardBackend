using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageBoardBackend.Interfaces
{
    interface IUserAccesInterface
    {
        Models.User LogIn(string userName, string password);
        Models.User LogOut(Models.User user);
    }
}
