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
                Console.WriteLine("Select an option to execute the program 1.Flip Coin\n2.LeapYearCheck\n3.PowerOf2\n4.Harmonic Number\n5.PrimeFactor\n6.QuotientAndRemainder\n7.Swap\n8.EvenOrOdd\n9.CheckAlphabet\n10.Exit");
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
                        Console.WriteLine("Enter the Nth number");
                        int H = Convert.ToInt32(Console.ReadLine());
                        HarmonicNumber harmonicNumber = new HarmonicNumber();
                        harmonicNumber.CalculateHarmonicValue(H);
                        break;
                    case 5:
                        Console.WriteLine("Enter the number");
                        int P = Convert.ToInt32(Console.ReadLine());
                        PrimeFactor primeFactor = new PrimeFactor();
                        primeFactor.PrimeFactorization(P);
                        break;
                    case 6:
                        Console.WriteLine("Enter the Dividend");
                        int Dividend = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Divisor");
                        int Divisor = Convert.ToInt32(Console.ReadLine());
                        QuotientAndRemainder quotientAndRemainder = new QuotientAndRemainder();
                        quotientAndRemainder.QueAndRem(Divisor, Dividend);
                        break;
                    case 7:
                        Console.WriteLine("Enter the number1");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the number2");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Swap swap = new Swap();
                        swap.SwapOfTwo(a, b);
                        break;
                    case 8:
                        Console.WriteLine("Enter the Nth number");
                        int value = Convert.ToInt32(Console.ReadLine());
                        EvenOrAdd evenOrAdd = new EvenOrAdd();
                        evenOrAdd.CheckEvenOrOdd(value);
                        break;
                    case 9:
                        Console.WriteLine("Enter the Alphabet");
                        char M = Convert.ToChar(Console.ReadLine());
                        CheckAlphabet checkAlphabet = new CheckAlphabet();
                        checkAlphabet.Check(M);
                        break;
                    case 10:
                        flag = false;
                        break;
                        
                }
                Console.ReadLine();
            }
        }
    }
}
