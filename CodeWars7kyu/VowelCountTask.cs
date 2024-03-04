using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class VowelCountTask
    {
        public static int GetVowelCount(string str)
        {
            int vowelCount = 0;
            char[] letters = str.ToCharArray();

            foreach (char letter in letters)
            {

                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                {
                    vowelCount++;
                }
            }

            return vowelCount;
        }
    }
}
//https://www.codewars.com/kata/54ff3102c1bad923760001f3/train/csharp