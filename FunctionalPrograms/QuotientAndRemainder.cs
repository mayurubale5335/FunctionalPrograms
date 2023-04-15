using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class QuotientAndRemainder
    {
        public void QueAndRem(int Divisor, int Dividend)
        {
            int Quotient = Dividend / Divisor;
            int Remainder = Dividend % Divisor;
            Console.WriteLine("Remainder =" + Remainder);
            Console.WriteLine("Quotient =" + Quotient);
        }
    }
}
