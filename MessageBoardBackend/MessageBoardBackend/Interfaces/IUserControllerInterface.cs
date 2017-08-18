using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageBoardBackend.Interfaces
{
    interface IUserControllerInterface
    {
        List<Models.User> GetAllUsers();
        Models.User CreateNewUser(Models.User user);
        List<Models.User> GetAllOnlineUsers();
        
    }
}
