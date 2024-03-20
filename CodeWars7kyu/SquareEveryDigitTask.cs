using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class SquareEveryDigitTask
    {
        public static int SquareDigits(int n)
        {
            int result = 0;
            string squaredDigits = "";

            var number = n.ToString();

            foreach (char c in number)
            {
                int digit = int.Parse(c.ToString());
                var exponentiation = Math.Pow(digit, 2);
                squaredDigits += exponentiation.ToString();
            }

            result = int.Parse(squaredDigits);

            return result;

        }
    }
}
//https://www.codewars.com/kata/546e2562b03326a88e000020/train/csharp