using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class StrongNumberTask
    {
        public static int Factorial(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        public static string StrongNumber(int number)
        {
            var digits = number.ToString().ToCharArray();
            int result = 0;

            foreach (char digit in digits)
            {
                int digitValue = digit - '0'; 
                result += Factorial(digitValue);
            }

            if (result == number)
                return "STRONG!!!!";
            else
                return "Not Strong !!";
        }
    }
}
//https://www.codewars.com/kata/5a4d303f880385399b000001/train/csharp