using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the Username: ");
            string username = Convert.ToString(Console.ReadLine());
            Console.Write("Enter the Password: ");
            string password = Convert.ToString(Console.ReadLine());

            Console.WriteLine("~~~~~~~~~~~~~~~~");
            Console.WriteLine("Admin or SuperAdmin side");

            Console.WriteLine("~~~~~~~~~~~~~~~~");

            Admin admin = new Admin("Adminstrator authority", username, password, true);
            admin.adminInfo();

        }
    }
}
