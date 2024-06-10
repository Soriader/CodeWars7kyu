using CodeWars7kyu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CodeWars7kyu.DisemvowelTrollsTask;

namespace CodeWars7kyu
{
    public class IndexedCapitalizationTask
    {
        public static string Capitalize(string s, List<int> idxs)
        {
            var letters = s.ToCharArray();

            foreach (int idx in idxs)
            {
                if (idx >= 0 && idx < letters.Length)
                {
                    letters[idx] = char.ToUpper(letters[idx]);
                }
            }
            return new string(letters);

        }
    }
}
//https://www.codewars.com/kata/59cfc09a86a6fdf6df0000f1/train/csharp