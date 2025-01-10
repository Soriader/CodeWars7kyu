using MoreLinq.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class YouGotChangeTask
    {
        public static int[] GiveChange(int amount)
        {
            int[] result = new int[6];
            int[] bill = new int[] { 100, 50, 20, 10, 5, 1 };
            int cash = amount;

            for (int i = 0; i < result.Length; i++) 
            {
                result[i] = cash / bill[i];

                cash -= result[i] * bill[i];
            }

            return result.Reverse().ToArray();
        }
    }
}
//https://www.codewars.com/kata/5966f6343c0702d1dc00004c/train/csharp