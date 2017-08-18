using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MessageBoardBackend.Models;

namespace MessageBoardBackend.DataStorage
{
    public class UserStorage: Interfaces.IUserControllerInterface, Interfaces.IUserAccesInterface
    {
        private static UserStorage instance;
        public List<Models.User> Users;

        private int UserIDCounter = 0;

        private UserStorage()
        {
            Users = new List<Models.User>();
        }

        //Singleton class
        public static UserStorage Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserStorage();
                }
                return instance;

            }
        }

        public User CreateNewUser(User user)
        {
            if (user.UserID == null && !Users.Any(u => u.UserName == user.UserName)) {
                UserIDCounter++;
                user.UserID = UserIDCounter;
                Users.Add(user);
                return user;
            }
            else if (!Users.Any(u => u.UserID == user.UserID)) {
                Users.Add(user);
                return user;
            }
            else
            {
                throw new Exceptions.UserAlreadyExistsException();
            }
        }

        public List<User> GetAllOnlineUsers()
        {
            List<Models.User> onlineUsers = new List<User>();
            foreach (User u in Users) {
                if (u.IsLoggedOn == true) {
                    onlineUsers.Add(u);
                }
            }

            return onlineUsers;
        }

        public List<User> GetAllUsers()
        {
            return Users;
        }

        public User LogIn(string userName, string password)
        {
            foreach(User u in Users) {
                if (u.UserName == userName && u.Password == password && u.IsLoggedOn == false)
                {
                    return u;
                }
            }
            throw new Exceptions.BadLogInException();
        }

        public User LogOut(User user)
        {
            foreach (User u in Users) {
                if (u.UserName == user.UserName && u.Password == user.Password && u.IsLoggedOn == true)
                {
                    u.IsLoggedOn = false;
                    return user;
                }
                else if(u.UserName == user.UserName && u.Password == user.Password && u.IsLoggedOn == false) {
                    Console.WriteLine("Internal Server error : user : (" + user.UserName + ")  is logged of while not being online");
                    return user;
                }
            }
            throw new Exceptions.BadLogInException();
        }
    }
}
