using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class StantonMeasureTask
    {
        public static int StantonMeasure(int[] arr)
        {
            int iteratror = 0;
            int result = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 1)
                {
                    iteratror++;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == iteratror)
                {
                    result++;
                }
            }

            return result;
        }
    }
}
//https://www.codewars.com/kata/59a1cdde9f922b83ee00003b/train/csharp