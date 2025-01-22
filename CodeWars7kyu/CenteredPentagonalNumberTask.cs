using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class CenteredPentagonalNumberTask
    {
        public static long Pentagonal(long n)
        {
            if(n <= 0)
            {
                return -1;
            }

            return (5 * n * n - 5 * n + 2) / 2;

        }
    }
}
//https://www.codewars.com/kata/5fb856190d5230001d48d721/train/csharp