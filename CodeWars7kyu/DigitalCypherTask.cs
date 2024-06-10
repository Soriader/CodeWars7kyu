using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class DigitalCypherTask
    {
        public static int[] Encode(string str, int n)
        {
            var checkTheLetter = str.ToLower().ToCharArray();
            var checkTheNumber = n.ToString().ToCharArray();

            int[] result = new int[str.Length];

            for (int i = 0; i < checkTheLetter.Length; i++)
            {
                if (checkTheLetter[i] < 'a' || checkTheLetter[i] > 'z')
                {
                    throw new ArgumentException("Not a letter!");
                }

                var numberOfLetter = checkTheLetter[i] - 'a' + 1;

                int keyDigit = checkTheNumber[i % checkTheNumber.Length] - '0'; 

                result[i] = numberOfLetter + keyDigit;

            }

            return result;
        }
    }
}
//https://www.codewars.com/kata/592e830e043b99888600002d/train/csharp