using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class FindTheVowelsTask
    {
        public static int[] VowelIndices(string word)
        {
            var letter = word.ToLower().ToCharArray();
            List<int> result = new List<int>();

            for (int i = 0; i < letter.Length; i++)
            {
                if (letter[i].ToString().Any(c => c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'y'))
                {
                    result.Add(i+1);
                }
            }

            return result.ToArray();
        }
    }
}
//https://www.codewars.com/kata/5680781b6b7c2be860000036/train/csharp