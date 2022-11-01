using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class LeapYear
    {
        public void Leap()
        {
            int year = 2012;
            if (year % 4 == 0)
            {
                if ((year % 100 == 0) && (year % 400 != 0))
                    Console.WriteLine(" It is not a leap year", year);
                else
                    Console.WriteLine(" It is a leap year", year);
            }
            else
                Console.WriteLine(" It is not a leap year", year);
        }
    }
}
