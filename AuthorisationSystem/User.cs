using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorisationSystem
{
    public class User
    {
        public string Name { get; set; }
        public int PermissionLevel { get; set; }

        public User(string name, int permissionLevel)
        {
            Name = name;
            PermissionLevel = permissionLevel;
        }
    }
}
