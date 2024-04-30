using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodeWars7kyu
{
    public class LargestPairSumInArrayTask
    {
        public static int LargestPairSum(int[] numbers)
        {
            int firstBigNumber = numbers.Max(); 
            int indexToRemove = Array.IndexOf(numbers, firstBigNumber);
            if (indexToRemove != -1)
            {
                numbers = numbers.Take(indexToRemove).Concat(numbers.Skip(indexToRemove + 1)).ToArray();
            }
            int secondBigNumber = numbers.Max();
            return firstBigNumber + secondBigNumber;
        }
    }
}
//https://www.codewars.com/kata/556196a6091a7e7f58000018/train/csharp