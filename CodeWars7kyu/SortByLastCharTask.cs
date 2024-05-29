using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class SortByLastCharTask
    {
        public static string[] Last(string x)
        {
            string[] words = x.Split(' ');

            words = words.OrderBy(w => w.Last()).ThenBy(w => Array.IndexOf(words, w)).ToArray();

            return words;
        }
    }
}
//https://www.codewars.com/kata/57eba158e8ca2c8aba0002a0/train/csharp