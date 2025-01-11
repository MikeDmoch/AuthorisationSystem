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
