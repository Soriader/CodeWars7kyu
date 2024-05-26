using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class SumOfOddCubedNumbersTask
    {
        public static int CubeOdd(int[] arr)
        {
            int result = 0;
            double cubingNumbers = 0;
            int[] cubing = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                cubingNumbers = (Math.Pow(arr[i], 3));
                cubing[i] = (int)cubingNumbers;
                cubingNumbers = 0;
            }

            for (int i = 0; i < cubing.Length; i++)
            {
                if (cubing[i] % 2 != 0)
                {
                    result += cubing[i];
                }
            }

            return result;
        }
    }
}
//https://www.codewars.com/kata/580dda86c40fa6c45f00028a/train/csharp