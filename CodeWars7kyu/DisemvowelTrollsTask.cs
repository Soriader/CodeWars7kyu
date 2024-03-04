using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class DisemvowelTrollsTask
    {
        public static class Kata
        {
            public static string Disemvowel(string str)
            {
                string lettersToRemove = "aeiouAEIOU";

                foreach (char letter in lettersToRemove)
                {
                    str = str.Replace(letter.ToString(), string.Empty);
                }

                return str;
            }
        }
    }
}
//https://www.codewars.com/kata/52fba66badcd10859f00097e/train/csharp