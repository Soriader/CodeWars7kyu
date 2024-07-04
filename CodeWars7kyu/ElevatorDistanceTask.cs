using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodeWars7kyu
{
    public class ElevatorDistanceTask
    {
        public static int ElevatorDistance(int[] array)
        {
            int result = 0;
            for (int i = 0; i < array.Length -1; i++)
            {
                result += Math.Abs(array[i] - array[i + 1]);

            }
            return result;

        }
    }
}
//https://www.codewars.com/kata/59f061773e532d0c87000d16/train/csharp