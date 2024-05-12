using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class AlphabetSymmetryTask
    {
        public static List<int> Solve(List<string> arr)
        {
            List<int> result = new List<int>();

            foreach (string word in arr)
            {
                int count = 0;
                for (int i = 0; i < word.Length; i++)
                {
                    char letter = char.ToUpper(word[i]);

                    if (letter - 'A' + 1 == i + 1)
                    {
                        count++;
                    }
                }
                result.Add(count);
            }

            return result;
        }
    }
}
//https://www.codewars.com/kata/59d9ff9f7905dfeed50000b0/train/csharp