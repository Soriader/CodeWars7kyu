using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class TheRobberLanguageTask
    {
        public static string RobberEncode(string sentence)
        {
            var result = "";
            var vovels = "aeiouAEIOU";
            for (int i = 0; i < sentence.Length; i++) 
            {
                if (!vovels.Contains(sentence[i]) && char.IsLetter(sentence[i]))
                {
                    if (char.IsUpper(sentence[i]))
                    {
                        result += sentence[i] + "O" + sentence[i];

                    }
                    else
                    {
                        result += sentence[i] + "o" + sentence[i];

                    }
                }
                else
                {
                    result += sentence[i];
                }
            }

            return result;
        }
    }
}
//https://www.codewars.com/kata/629e4d5f24b98110a83b2d0d/train/csharp