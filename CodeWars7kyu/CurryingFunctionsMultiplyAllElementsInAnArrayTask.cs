using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class CurryingFunctionsMultiplyAllElementsInAnArrayTask
    {
        public static Func<int, int[]> MultiplyAll(int[] numbers)
        {
            return (int multiply) =>
            {
                if (numbers == null) return new int[] { };

                int[] result = new int[numbers.Length];
                for (int i = 0; i < numbers.Length; i++)
                {
                    result[i] = numbers[i] * multiply;
                }
                return result;
            };
        }
    }
}
//https://www.codewars.com/kata/586909e4c66d18dd1800009b/train/csharp