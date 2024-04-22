using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class SortArrayByStringLengthTask
    {
        public static string[] SortByLength(string[] array)
        {
            string[] result = new string[array.Length];
            var sortedWords = array.OrderBy(word => word.Length);

            result = sortedWords.ToArray();
            return result;
        }
    }
}
//https://www.codewars.com/kata/57ea5b0b75ae11d1e800006c/train/csharp