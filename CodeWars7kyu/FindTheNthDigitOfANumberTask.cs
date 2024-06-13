using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class FindTheNthDigitOfANumberTask
    {
        public static int FindDigit(int num, int nth)
        {
            if (nth <= 0) return -1;

            num = Math.Abs(num);

            var digits = num.ToString().ToCharArray();

            if (nth > digits.Length) return 0;

            return digits[digits.Length - nth] - '0';
        }
    }
}
//https://www.codewars.com/kata/577b9960df78c19bca00007e/train/csharp