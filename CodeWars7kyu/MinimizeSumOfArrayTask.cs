using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class MinimizeSumOfArrayTask
    {
        public static int MinSum(int[] a)
        {
            Array.Sort(a);

            int sum = 0;
            int length = a.Length;

            for (int i = 0; i < length / 2; i++)
            {
                sum += a[i] * a[length - 1 - i];
            }

            return sum;
        }
    }
}
//https://www.codewars.com/kata/5a523566b3bfa84c2e00010b/train/csharp