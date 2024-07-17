using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class HowManyConsecutiveTask
    {
        public static int Consecutive(int[] arr)
        {
            if (arr.Length <= 1) return 0;

            int min = arr[0];
            int max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min) min = arr[i];
                if (arr[i] > max) max = arr[i];
            }

            return (max - min + 1) - arr.Length;

        }
    }
}
//https://www.codewars.com/kata/559cc2d2b802a5c94700000c/train/csharp