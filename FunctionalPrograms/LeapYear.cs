using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class LeapYear
    {
        public void LeapYearCheck(int year)
        {
            if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine("{0} is Leap year", year);
            }
            else
            {
                Console.WriteLine("{0} is not Leap year", year);
            }
        }
    }
}
