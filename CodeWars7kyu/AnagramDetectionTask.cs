using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class AnagramDetectionTask
    {
        public static bool IsAnagram(string test, string original)
        {
            var first = new string(test.ToLower().OrderBy(c => c).ToArray());
            var second = new string(original.ToLower().OrderBy(c => c).ToArray());

            return first == second;

        }
    }
}
//https://www.codewars.com/kata/529eef7a9194e0cbc1000255/train/csharp