using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class MaxDiffEasyTask
    {
        public static int MaxDiff(int[] lst)
        {
            if (lst.Length == 0)
            {
                return 0;
            }

            var max = lst.Max();
            var min = lst.Min();

            return max - min;
        }
    }
}
//https://www.codewars.com/kata/588a3c3ef0fbc9c8e1000095/train/csharp