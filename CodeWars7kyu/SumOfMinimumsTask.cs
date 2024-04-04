using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class SumOfMinimumsTask
    {
        public static int SumOfMinimums(int[,] numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                int min = numbers[i, 0];

                for (int j = 1; j < numbers.GetLength(1); j++)
                {
                    if (numbers[i, j] < min)
                    {
                        min = numbers[i, j];
                    }
                }

                sum += min;
            }

            return sum;
        }
    }
}
//https://www.codewars.com/kata/5d5ee4c35162d9001af7d699/train/csharp