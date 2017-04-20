using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenKata
{
    class Odd_Even_Kata
    {
        public static string GetOddEvenKata(int x)
        {

            if (x % 2 == 0)
                return "even";
            if (x == 1 || x == 3)
                return "odd";
            
            for (int a = 2; a <= x / 2; a++)
            {
                if (x % a == 0)
                {
                    
                    return "odd";

                }
               
            }
            return "prime";

        }

    }
}

    


