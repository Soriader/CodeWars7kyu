using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class ConsecutiveItemsTask
    {
        public static bool Consecutive(int[] arr, int a, int b)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == a && arr[i+1] == b || arr[i] == b && arr[i + 1] == a)
                {
                   return true;
                }
            }

            return false;

        }
    }
}
//https://www.codewars.com/kata/5f6d533e1475f30001e47514/train/csharp