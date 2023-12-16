using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; } = string.Empty;
        public UserType UserType { get; set; }

        public OfficeAddress OfficeAddress { get; set; }

        public User(int id,
            string name,
            string email,
            string password,
            string userName,
            UserType userType,
            OfficeAddress officeAddress)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            UserName = userName;
            UserType = userType;
            OfficeAddress = officeAddress;
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
