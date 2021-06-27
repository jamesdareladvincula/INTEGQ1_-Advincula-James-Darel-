using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeKeepingSystem
{
    class Menu
    {
        public static void ShowMenu()
        {
            Console.WriteLine("Please press:");
            Console.WriteLine("'v' - To View Previous Attendance");
            Console.WriteLine("'e' - To Exit Program");

            char menu = Convert.ToChar(Console.ReadLine());
            menu = char.ToLower(menu);

            switch (menu)
            {
                case 'v':
                    ViewAttendance();
                    break;

                case 'e':
                    ExitProgram();
                    break;

                default:
                    Console.WriteLine("Invalid Option!");
                    break;
            }
        }

        public static void ViewAttendance()
        {
            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("         Attendance Log         ");

            var attendanceLogs = new List<string>()
                {"05/03/21 - In: 9:00am - Out: 5:00pm", "05/02/21 - In: 8:45am - Out: 5:00pm",
                 "05/01/21 -         Holiday         ", "04/30/21 - In: 9:05am - Out: 5:06pm",
                 "04/29/21 - In: 8:55am - Out: 5:04pm", "04/28/21 - In: 9:00am - Out: 6:00pm",
                 "04/27/21 - In: 9:07am - Out: 5:00pm"};

            foreach (var attendance in attendanceLogs)
            {
                Console.WriteLine($"{attendance}");
            }
        }
        public static void ExitProgram()
        {
            Console.WriteLine("|----------------------------------------------|");
            Console.WriteLine("|                  Thank You!                  |");
            Console.WriteLine("|----------------------------------------------|");

            System.Environment.Exit(0);
        }
    }
}
