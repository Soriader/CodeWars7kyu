using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class SumOfCubesTask
    {
        public static long SumCubes(int n)
        {
            long result = 0;
            for (int i = 1; i <= n; i++)
            {
                result += (long)Math.Pow(i, 3);
            }
            return result;
        }
    }
}
//https://www.codewars.com/kata/59a8570b570190d313000037/train/csharp