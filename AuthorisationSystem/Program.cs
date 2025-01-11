using System;

namespace AuthorisationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var user1 = new User("Alice", 1);
            var user2 = new User("Bob", 2);
            var admin = new User("Charlie", 3);

            Console.WriteLine("=== Operations for Alice ===");
            var aliceOperations = new SecureOperations(user1);
            aliceOperations.ViewData();
            aliceOperations.ModifyData();
            aliceOperations.DeleteData();

            Console.WriteLine("\n=== Operations for Bob ===");
            var bobOperations = new SecureOperations(user2);
            bobOperations.ViewData();
            bobOperations.ModifyData();
            bobOperations.DeleteData();

            Console.WriteLine("\n=== Operations for Charlie ===");
            var charlieOperations = new SecureOperations(admin);
            charlieOperations.ViewData();
            charlieOperations.ModifyData();
            charlieOperations.DeleteData();
        }
    }
}
