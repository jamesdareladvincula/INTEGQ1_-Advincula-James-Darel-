using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2.DL;

namespace ClassLibrary1.BL
{
    public class TimeStamp
    {
        public List<Time> TimeInAndOut = new List<Time>()
        {
            new Time("8:00am", "5:00pm")
        };

        public void timeEntered()
        {
            DateTime timeInEntered;
            DateTime timeOutEntered;

            Console.Write("Enter Time-In:\t");
            string timeIn = Console.ReadLine();

            Console.Write("Enter Time-Out:\t");
            string timeOut = Console.ReadLine();

            Console.WriteLine("");

            var validTimeIn = DateTime.TryParse(timeIn, out timeInEntered);
            var validTimeOut = DateTime.TryParse(timeOut, out timeOutEntered);

            if (validTimeIn && validTimeOut)
            {
                Console.WriteLine("Time-In:\t" + timeInEntered.ToShortTimeString());
                Console.WriteLine("Time-Out:\t" + timeOutEntered.ToShortTimeString());
            }

            else
            {
                Console.WriteLine("ERROR! Invalid Time Format.");
            }

            DateTime dateSubmitted = DateTime.Now;
            Console.Write("Date Submitted:\t");
            Console.WriteLine(dateSubmitted.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
        }
    }
}
