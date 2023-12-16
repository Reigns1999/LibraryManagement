using LibraryManagement.Entities;
using LibraryManagement.LocalStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Services
{
    public class UserService : IUserService
    {
        public User CreateUser(User user)
        {
           UserStore.AddUser(user);
           return user;
        }

        public User DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public User GetUser(int id)
        {
            throw new NotImplementedException();
        }

        public User UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
