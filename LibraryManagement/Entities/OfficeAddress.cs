using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Entities
{
    public class OfficeAddress : Address
    {
        private string officeName;

        public string OfficeName { get => officeName; set => officeName = value; }

        public override bool Equals(object? obj)
        {
            return obj is OfficeAddress address &&
                   OfficeName == address.OfficeName;
        }
    }
}
