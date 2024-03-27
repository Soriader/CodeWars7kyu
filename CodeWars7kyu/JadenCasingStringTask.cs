using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class JadenCasingStringTask
    {
        public static string ToJadenCase(string phrase)
        {
            string[] words = phrase.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (!string.IsNullOrEmpty(words[i]))
                {
                    char firstChar = char.ToUpper(words[i][0]);
                    words[i] = firstChar + words[i].Substring(1);
                }
            }

            return string.Join(" ", words);
        }
    }
}
//https://www.codewars.com/kata/5390bac347d09b7da40006f6/train/csharp