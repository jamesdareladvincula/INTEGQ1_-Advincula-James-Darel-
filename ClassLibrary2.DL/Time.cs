using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.DL
{
    public class Time
    {
        public string timeIn;
        public string timeOut;

        public Time(string timeIn, string timeOut)
        {
            this.timeIn = timeIn;
            this.timeOut = timeOut;
        }

        public string TimeIn
        {
            get { return timeIn; }
            set { timeIn = value; }
        }

        public string TimeOut
        {
            get { return timeOut; }
            set { timeOut = value; }
        }
    }
}
