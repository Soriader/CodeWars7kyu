using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class SumOfASequenceTask
    {
        public static int SequenceSum(int start, int end, int step)
        {
            if (start > end)
            {
                return 0;
            }

            int sum = 0;
            for (int i = start; i <= end; i += step)
            {
                sum += i;
            }

            return sum;
        }
    }
}
//https://www.codewars.com/kata/586f6741c66d18c22800010a/train/csharp