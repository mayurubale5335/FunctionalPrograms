using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
   public class EvenOrAdd
    {
        public void CheckEvenOrOdd(int value)
        {
            if(value % 2 == 0)
            {
                Console.WriteLine("{0} is Even ", value);
            }
            else
            {
                Console.WriteLine("{0} is Odd ", value);
            }
        }
    }
}
