using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class TheOldSwitcheroTask
    {
        public static string Vowel2Index(string str)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

            string result = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (vowels.Contains(str[i]))
                {
                    result += (i + 1).ToString();
                }
                else
                {
                    result += str[i];
                }
            }

            return result;
        }
    }
}
//https://www.codewars.com/kata/55d410c492e6ed767000004f/train/csharp