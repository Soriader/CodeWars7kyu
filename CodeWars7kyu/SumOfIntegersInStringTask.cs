using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class SumOfIntegersInStringTask
    {
        public static int SumOfIntegersInString(string s)
        {
            int sum = 0;
            string currentNumber = "";

            foreach (char c in s)
            {
                if (char.IsDigit(c))
                {
                    currentNumber += c;
                }
                else
                {
                    if (currentNumber.Length > 0)
                    {
                        sum += int.Parse(currentNumber);
                        currentNumber = ""; 
                    }
                }
            }

            if (currentNumber.Length > 0)
            {
                sum += int.Parse(currentNumber);
            }

            return sum;
        }
    }
}
//https://www.codewars.com/kata/598f76a44f613e0e0b000026/train/csharp