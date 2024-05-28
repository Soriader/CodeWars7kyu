using CodeWars7kyu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CodeWars7kyu.DisemvowelTrollsTask;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodeWars7kyu
{
    public class MaximumTripletSumTask
    {
        public static int MaxTriSum(int[] a)
        {
            int[] set = a.Distinct().ToArray();

            List<int> list = set.ToList();
            list.Sort((x, y) => y.CompareTo(x));

            if (list.Count < 3)
            {
                return 0;
            }

            int result = list[0] + list[1] + list[2];

            return result;
        }
    }
}
//https://www.codewars.com/kata/5aa1bcda373c2eb596000112/train/csharp