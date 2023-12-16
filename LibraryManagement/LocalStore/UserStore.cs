using LibraryManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.LocalStore
{
    public static class UserStore
    {
        static readonly List<User> _userStore = new();

        public static void AddUser(User user)
        {
            _userStore.Add(user);
        }

        //Save the List into File.
        //OpeN :-
            // Load the file into List.

    }
}
