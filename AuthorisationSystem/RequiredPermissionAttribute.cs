using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorisationSystem
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class RequiredPermissionAttribute : Attribute
    {
        public int PermissionLevel { get; }

        public RequiredPermissionAttribute(int permissionLevel)
        {
            PermissionLevel = permissionLevel;
        }
    }
}
