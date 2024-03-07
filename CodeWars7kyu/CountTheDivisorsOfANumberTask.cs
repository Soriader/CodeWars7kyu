using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class CountTheDivisorsOfANumberTask
    {
        public static int Divisors(int n)
        {
            int divisors = 1;
            int divisor = 1;


            while (divisor < n)
            {
                int action = n % divisor;

                if (n % divisor == 0)
                {
                    divisors++;
                }

                divisor++;

                if (divisor > n)
                {
                    break;
                }
            }

            return divisors;
        }
    }
}
//https://www.codewars.com/kata/542c0f198e077084c0000c2e/train/csharp