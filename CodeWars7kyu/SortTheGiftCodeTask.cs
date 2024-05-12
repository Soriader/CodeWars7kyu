using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class SortTheGiftCodeTask
    {
        public static string SortGiftCode(string code)
        {
            string sortedWord = string.Concat(code.OrderBy(c => c));

            return sortedWord;

        }
    }
}
//https://www.codewars.com/kata/52aeb2f3ad0e952f560005d3/train/csharp
