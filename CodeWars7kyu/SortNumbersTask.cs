using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class SortNumbersTask
    {
        public static int[] SortNumbers(int[] nums)
        {
            if(nums == null)
            {
                return new int[] { };
            }

            return nums.OrderBy(x => x).ToArray();
        }
    }
}
//https://www.codewars.com/kata/5174a4c0f2769dd8b1000003/train/csharp