using LibraryManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Services
{
    public interface IUserService
    { 
        User CreateUser(User user);
        User GetUser(int id);
        User UpdateUser(User user);
        User DeleteUser(int id);

    }
}
