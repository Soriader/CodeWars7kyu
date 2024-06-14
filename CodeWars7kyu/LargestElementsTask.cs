using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class LargestElementsTask
    {
        public static List<int> Largest(int n, List<int> xs)
        {
            List<int> largestNElements = xs.OrderByDescending(x => x).Take(n).ToList();

            return largestNElements.OrderBy(x => x).ToList();
        }
    }
}
//https://www.codewars.com/kata/53d32bea2f2a21f666000256/train/csharp