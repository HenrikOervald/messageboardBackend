using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MessageBoardBackend.Models;

namespace MessageBoardBackend.DataStorage
{
    public class UserAccesControl : Interfaces.IUserAccesInterface
    {
        UserStorage userStorage = UserStorage.Instance;
        public User LogIn(string userName, string password)
        {
            return userStorage.LogIn(userName, password);
        }

        public User LogOut(User user)
        {
            return userStorage.LogOut(user);
        }
    }
}
