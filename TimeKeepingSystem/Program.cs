using ClassLibrary1;
using ClassLibrary1.BL;
using System;

namespace TimeKeepingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInformation user = new UserInformation();
            TimeStamp workTime = new TimeStamp();

            Console.WriteLine("EMPLOYEE TIME KEEPING SYSTEM");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Press 1 to LOG IN");
            
            int userInput = int.Parse(Console.ReadLine());

            if (userInput.Equals(1))
            {
                user.LogIn();
                
                Console.WriteLine("");

                workTime.timeEntered();
            }
                
            else
            {
                Console.WriteLine("Invalid Input!");
            }
        }
    }
}
