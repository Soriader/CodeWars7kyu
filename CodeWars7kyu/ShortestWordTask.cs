using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class ShortestWordTask
    {
        public static int FindShort(string s)
        {
            var shortestLength = s.Split(' ').Min(word => word.Length);
            return shortestLength;
        }
    }
}
//https://www.codewars.com/kata/57cebe1dc6fdc20c57000ac9/train/csharp