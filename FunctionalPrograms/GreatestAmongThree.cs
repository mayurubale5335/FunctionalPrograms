using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class GreatestAmongThree
    {
        public void FindGreatest(int a, int b, int c)
        {
            if (a>b && a>c)
            {
                Console.WriteLine("{0} is Greatest ", a);
            }
            if (b>a && b>c)
            {
                Console.WriteLine("{0} is Greatest", b);
            }
            else
            {
                Console.WriteLine("{0} is Greatest", c);
            }
        }
    }
}
