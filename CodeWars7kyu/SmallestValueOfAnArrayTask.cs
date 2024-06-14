using CodeWars7kyu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class SmallestValueOfAnArrayTask
    {
        public static int FindSmallest(int[] numbers, string toReturn)
        {
            int minValue = numbers.Min();

            switch (toReturn)
            {
                case "value":
                    return minValue;

                case "index":
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (numbers[i] == minValue)
                        {
                            return i;
                        }
                    }
                    break; 
            }

            return -1; 
        }
    }
}
//https://www.codewars.com/kata/544a54fd18b8e06d240005c0/train/csharp