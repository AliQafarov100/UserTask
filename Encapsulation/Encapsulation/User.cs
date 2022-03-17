using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    class User
    {
        private string _username;
        private string _password;

        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
               if(value.Length > 6)
                {
                    _username = value;
                }
                else
                {
                    Console.WriteLine("The username length must large than 6");
                    Console.WriteLine("Enter Username: ");
                }
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                int Number = 0;
                int Later = 0;
                bool num = false;  

                for(int i = 0; i < value.Length; i++)
                {
                    Number = (int)value[i];

                    if (Number >= 65 && Number <= 90)
                    {
                        num = true;
                    }
                }

                bool bigLater = false;

                for(int i = 0; i < value.Length; i++)
                {
                    Later = (int)value[i];

                    if(Later >= 48 && Later <= 57)
                    {
                        bigLater = true;
                    }
                }

                if(bigLater == true && num == true)
                {
                    _password = value;
                }
                else
                {
                    Console.WriteLine("Password must have one Number and one big later");
                    Console.WriteLine("Enter your Password: ");
                }
               
            }
        }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
        
    }
}
