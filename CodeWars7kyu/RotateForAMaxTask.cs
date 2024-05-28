using CodeWars7kyu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodeWars7kyu
{
    public class RotateForAMaxTask
    {
        public static long MaxRot(long n)
        {
            List<long> result = new List<long>();
            result.Add(n);
            var numbers = n.ToString();

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                numbers = numbers.Substring(0, i) + numbers.Substring(i + 1) + numbers[i];
                result.Add(long.Parse(numbers));
            }

            return result.Max();
        }
    }
}
//https://www.codewars.com/kata/56a4872cbb65f3a610000026/train/csharp