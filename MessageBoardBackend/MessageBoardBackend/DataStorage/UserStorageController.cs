using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MessageBoardBackend.Models;

namespace MessageBoardBackend.DataStorage
{
    public class UserStorageController : Interfaces.IUserAccesInterface , Interfaces.IUserControllerInterface
    {
        private UserStorage UserStorage = UserStorage.Instance;

        public User CreateNewUser(User user)
        {
            return UserStorage.CreateNewUser(user);
        }

        public List<User> GetAllOnlineUsers()
        {
            return UserStorage.GetAllOnlineUsers();
        }

        public List<User> GetAllUsers()
        {
            return UserStorage.GetAllUsers();
        }

        public User LogIn(string userName, string password)
        {
            return UserStorage.LogIn(userName, password);
        }

        public User LogOut(User user)
        {
            return UserStorage.LogOut(user);
        }
    }
}
