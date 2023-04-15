using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class Swap
    {
        public void SwapOfTwo(int a,int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("After Swapping Numbers are {0},{1} ", a, b);
        }
    }
}
