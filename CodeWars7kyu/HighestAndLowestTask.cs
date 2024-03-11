using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class HighestAndLowestTask
    {
        public static string HighAndLow(string numbers)
        {
            var maxAdnMin = numbers.Split(' ').Select(int.Parse).ToList();
            var max = maxAdnMin.Max();
            var min = maxAdnMin.Min();

            return $"{max} {min}";
        }
    }
}
//https://www.codewars.com/kata/554b4ac871d6813a03000035/train/csharp