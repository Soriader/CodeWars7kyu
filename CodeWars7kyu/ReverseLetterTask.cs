using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class ReverseLetterTask
    {
        public static string ReverseLetter(string str)
        {
            string result = "";

            foreach (char c in str)
            {
                if (char.IsLetter(c))
                {
                    result += c;
                }
            }

            char[] reversedChars = result.ToCharArray();
            Array.Reverse(reversedChars);
            result = new string(reversedChars);

            return result;
        }
    }
}
//https://www.codewars.com/kata/58b8c94b7df3f116eb00005b/train/csharp