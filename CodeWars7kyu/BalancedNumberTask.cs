using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class BalancedNumberTask
    {
        public static string BalancedNumber(int number)
        {
            var digits = number.ToString().ToCharArray();
            int length = digits.Length;
            int middle = length / 2;

            int start = 0;
            int end = 0;

            if (length % 2 == 0)
            {
                for (int i = 0; i < middle - 1; i++)
                {
                    start += digits[i] - '0';
                }
                for (int i = middle + 1; i < length; i++)
                {
                    end += digits[i] - '0';
                }
            }
            else
            {
                for (int i = 0; i < middle; i++)
                {
                    start += digits[i] - '0';
                }
                for (int i = middle + 1; i < length; i++)
                {
                    end += digits[i] - '0';
                }
            }

            if (start == end)
            {
                return "Balanced";
            }
            else
            {
                return "Not Balanced";
            }
        }
    }
}
//https://www.codewars.com/kata/5a4e3782880385ba68000018/train/csharp