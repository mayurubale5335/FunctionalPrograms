using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class CheckAlphabet
    {
        public void Check(char M)
        {
            if (M == 'a' || M == 'e' || M == 'i' || M == 'o' || M == 'u' )
            {
                Console.WriteLine("{0} is Vowel", M);
            }
            else
            {
                Console.WriteLine("{0} is Consonant", M);
            }

        }
    }
}
