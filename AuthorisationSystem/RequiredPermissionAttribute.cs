using System;

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
