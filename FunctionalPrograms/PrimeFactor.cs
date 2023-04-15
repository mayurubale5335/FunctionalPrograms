using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class PrimeFactor
    {
        public void PrimeFactorization(int P)
        {
            bool flag = false;
            for (int i = 2; i <= P; i++)
            {
                if(P % i == 0)
                {
                    for (int j = 2; j <= i / 2; j++)
                    {
                        if(i % j == 0)
                        {
                            flag = true;
                            break;
                        }
                        flag = false;
                    }
                    if (flag == false)
                    {
                        Console.WriteLine("Prime Factor =" + i);
                    }
                }


            }
        }
    }
}
