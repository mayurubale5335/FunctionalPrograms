using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Functional Programs");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Select an option to execute the program 1.Flip Coin\n2.LeapYearCheck\n3.PowerOf2\n4.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        Console.WriteLine("Enter the no of flips");
                        int n = Convert.ToInt32(Console.ReadLine());
                        FlipCoin flipCoin = new FlipCoin();
                        flipCoin.Flip(n);
                        break;
                    case 2:
                        Console.WriteLine("Enter the year");
                        int year = Convert.ToInt32(Console.ReadLine());
                        LeapYear leapYear = new LeapYear();
                        leapYear.LeapYearCheck(year);
                        break;
                    case 3:
                        Console.WriteLine("Enter the power number");
                        int N = Convert.ToInt32(Console.ReadLine());
                        PowerOf2 powerof2 = new PowerOf2();
                        powerof2.CalculatePower(N);
                        break;
                    case 4:
                        flag = false;
                        break;
                        
                }
                Console.ReadLine();
            }
        }
    }
}
