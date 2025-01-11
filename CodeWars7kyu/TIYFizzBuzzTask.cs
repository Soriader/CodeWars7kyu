using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class TIYFizzBuzzTask
    {
        public static string FizzBuzz(string sentence)
        {
            string result = "";
            var lowerVovels = "aeiou";
            var upperVovels = "AEIOU";

            foreach (char c in sentence) 
            {
                if(char.IsUpper(c) && !upperVovels.Contains(c))
                {
                    result += "Iron";
                    continue;
                }

                if (upperVovels.Contains(c))
                {
                    result += "Iron Yard";
                    continue;
                }

                if (lowerVovels.Contains(c))
                {
                    result += "Yard";
                    continue;
                }

                result += c;
            }

            return result;
        }
    }
}
//https://www.codewars.com/kata/5889177bf148eddd150002cc/train/csharp