using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    class Admin : User
    {
        public bool isSuperAdmin;
        public string Section;


        public Admin(string section, string Username, string Password, bool issuperAdmin = false) : base(Username, Password)
        {
            Section = section;
            isSuperAdmin = issuperAdmin;
        }

        public void adminInfo()
        {
            if (isSuperAdmin == true)
            {
                Console.WriteLine($"Username: {Username}");
                Console.WriteLine($"Password: {Password}");
                Console.WriteLine($"Section: {Section}");
            }
            else
            {
                Console.WriteLine($"Username: {Username}");
            }
        }


    }
}
