using System;

namespace AuthorisationSystem
{
    public class SecureOperations
    {
        private User _currentUser;

        public SecureOperations(User currentUser)
        {
            _currentUser = currentUser;
        }

        [RequiredPermission(1)]
        public void ViewData()
        {
            if (Authorise(nameof(ViewData)))
            {
                Console.WriteLine($"{_currentUser.Name} is viewing data.");
            }
        }

        [RequiredPermission(2)]
        public void ModifyData()
        {
            if (Authorise(nameof(ModifyData)))
            {
                Console.WriteLine($"{_currentUser.Name} is modifying data.");
            }
        }

        [RequiredPermission(3)]
        public void DeleteData()
        {
            if (Authorise(nameof(DeleteData)))
            {
                Console.WriteLine($"{_currentUser.Name} is deleting data.");
            }
        }

        private bool Authorise(string methodName)
        {
            var method = GetType().GetMethod(methodName);
            var attribute = (RequiredPermissionAttribute)Attribute.GetCustomAttribute(method, typeof(RequiredPermissionAttribute));

            if (_currentUser.PermissionLevel >= attribute.PermissionLevel)
            {
                return true;
            }

            Console.WriteLine($"Access denied for {_currentUser.Name}. Required level: {attribute.PermissionLevel}, your level: {_currentUser.PermissionLevel}");
            return false;
        }
    }
}
