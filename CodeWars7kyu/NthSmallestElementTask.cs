using CodeWars7kyu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class NthSmallestElementTask
    {
        public static int NthSmallest(int[] arr, int pos)
        {
            int result = 0;
            arr = arr.OrderBy(x => x).ToArray();


            for (int i = 0; i < arr.Length; i++)
            {
                if(i+1 == pos)
                {
                    result = arr[i];
                }
            }
            return result;
        }
    }
}
//https://www.codewars.com/kata/5a512f6a80eba857280000fc/train/csharp