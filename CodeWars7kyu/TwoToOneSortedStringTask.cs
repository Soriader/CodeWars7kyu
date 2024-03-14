using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CodeWars7kyu
{
    public class TwoToOneSortedStringTask
    {
        public static string Longest(string s1, string s2)
        {
            string result = "";
            string alphabet = "abcdefghijklmnopqrstuvwxyz";

            foreach (var letter in alphabet)
            {
                if (s1.Contains(letter) || s2.Contains(letter))
                {
                    result += letter;
                }
            }

            string sortedText = string.Concat(result.OrderBy(c => c));
            return sortedText;

        }
    }
}
//https://www.codewars.com/kata/5656b6906de340bd1b0000ac/train/csharp