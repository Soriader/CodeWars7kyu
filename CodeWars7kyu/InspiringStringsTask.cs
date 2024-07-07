using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class InspiringStringsTask
    {
        public static string LongestWord(string stringOfWords)
        {
            var check = stringOfWords.Split(' ');
            
            int maxLength = check.Max(word => word.Length);

            return check.Last(word => word.Length == maxLength);

        }
    }
}
//https://www.codewars.com/kata/5939ab6eed348a945f0007b2/train/csharp
