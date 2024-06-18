using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class ARuleOfDivisibilityBySevenTask
    {
        public static long[] Seven(long m)
        {
            int steps = 0;

            while (m >= 100)
            {
                long lastDigit = m % 10;   
                m = m / 10 - 2 * lastDigit; 
                steps++;
            }

            return new long[] { m, steps };
        }
    }
}
//https://www.codewars.com/kata/55e6f5e58f7817808e00002e/train/csharp