using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class SumDigitsTask
    {
        public static int SumDigits(int number)
        {
            int absoluteNumber = Math.Abs(number);
            char[] digits = absoluteNumber.ToString().ToCharArray();
            int sum = 0;
            foreach (char digit in digits)
            {
                sum += int.Parse(digit.ToString());
            }

            return sum;
        }
    }
}
//https://www.codewars.com/kata/52f3149496de55aded000410/train/csharp