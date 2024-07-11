using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class EvensTimesLastTask
    {
        public static int EvenTimesLast(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                return 0;

            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sum += arr[i];
                }
            }

            return sum * arr[^1];
        }
    }
}
//https://www.codewars.com/kata/5a1a9e5032b8b98477000004/train/csharp