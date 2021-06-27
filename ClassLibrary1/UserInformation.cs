using ClassLibrary2.DL;
using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public class UserInformation
    {
        public List<Users> UserValidation = new List<Users>()
        {
            new Users("Admin","Admin")
        };

        public void LogIn()
        {
            bool successful = false;

            Console.Write("Enter username:\t");
            string userName = Console.ReadLine();
            Console.Write("Enter Password:\t");
            string passWord = Console.ReadLine();

            foreach (Users user in UserValidation)
            {
                if (userName == user.UserName && passWord == user.PassWord)
                {
                    Console.WriteLine("Log In Successful!");
                    successful = true;
                }
            }
            if (!successful)
            {
                Console.WriteLine("Operation Cease...");
            }
        }
    }
}
