using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class SumTwoSmallestNumbersTask
    {
        public static int SumTwoSmallestNumbers(int[] numbers)
        {
            int minNumber = numbers.Min();
            int nextMinNumber = numbers.OrderBy(n => n).Skip(1).First();

            return minNumber + nextMinNumber;
        }
    }
}
//https://www.codewars.com/kata/558fc85d8fd1938afb000014/train/csharp