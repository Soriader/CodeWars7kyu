using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class NumberOfOccurrencesTask
    {
        public static int NumberOfOccurrences(int x, int[] xs)
        {
            int result = 0;

            for (int i = 0; i < xs.Length; i++)
            {
                if (xs[i] == x)
                {
                    result++;
                }
            }

            return result;
        }
    }
}
//https://www.codewars.com/kata/52829c5fe08baf7edc00122b/train/csharp