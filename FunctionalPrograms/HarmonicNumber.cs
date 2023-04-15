using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class HarmonicNumber
    {
        public void CalculateHarmonicValue(int H)
        {
            double sum = 0;
            for(double i=1; i <= H; i++)
            {
                sum += (1 / i);
            }
            Console.WriteLine("The Sum of Series 1/1 + 1/2 + ...+1/{0}" + "=" + sum, H);
        }
    }
}
