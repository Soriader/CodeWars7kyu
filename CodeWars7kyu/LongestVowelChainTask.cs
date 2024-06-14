using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class LongestVowelChainTask
    {
        public static int Solve(string str)
        {
            var vowels = "aeiou";
            int maxLength = 0;
            int currentLength = 0;

            foreach (var ch in str)
            {
                if (vowels.Contains(ch))
                {
                    currentLength++;

                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                    }
                }
                else
                {
                    currentLength = 0;
                }
            }

            return maxLength;
        }
    }
}
//https://www.codewars.com/kata/59c5f4e9d751df43cf000035/train/csharp