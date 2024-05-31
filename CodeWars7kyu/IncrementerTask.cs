using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class IncrementerTask
    {
        public static int[] Incrementer(int[] numbers)
        {
            var result = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                result[i] = (numbers[i] + (i + 1)) % 10;
            }

            return result;
        }
    }
}
//https://www.codewars.com/kata/590e03aef55cab099a0002e8/train/csharp
