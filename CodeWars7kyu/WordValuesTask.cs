using CodeWars7kyu;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CodeWars7kyu.DisemvowelTrollsTask;

namespace CodeWars7kyu
{
    public class WordValuesTask
    {
        public static int[] WordValue(string[] a)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < a.Length; i++)
            {
                string word = a[i];
                int wordValue = 0;

                foreach (char c in word)
                {
                    if (char.IsLetter(c)) 
                    {
                        wordValue += (int)c - 96; 
                    }
                }

                wordValue *= (i + 1); 
                result.Add(wordValue);
            }

            return result.ToArray();
        }
    }
}
//https://www.codewars.com/kata/598d91785d4ce3ec4f000018/train/csharp
