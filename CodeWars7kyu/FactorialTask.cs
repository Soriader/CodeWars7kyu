using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class FactorialTask
    {
        public static int Factorial(int n)
        {
            if (n < 0 || n > 12)
            {
                throw new ArgumentOutOfRangeException(nameof(n));
            }
            if (n == 0)
            {
                return 1;
            }
            else
            {
                int result = 1;
                for (int i = 1; i <= n; i++)
                {
                    result *= i;
                }
                return result;
            }
        }
    }
}
//https://www.codewars.com/kata/54ff0d1f355cfd20e60001fc/train/csharp