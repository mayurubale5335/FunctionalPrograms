using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class FlipCoin
    {
        const double Validation_Check = 0.5;
        public void Flip(int n)
        {
            int tail = 0;
            int head = 0;
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                double value = random.NextDouble();
                if (value < Validation_Check)
                {
                    tail++;
                }
                else
                {
                    head++;
                }
            }
            double Head_Percentage = (head * 100) / n;
            double Tail_Percentage = (tail * 100) / n;
            Console.WriteLine("Head Percentage = " + Head_Percentage);
            Console.WriteLine("Tail Percentage = " + Tail_Percentage);
        }
    }
}
