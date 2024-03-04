using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class MinMaxTask
    {
        public static int[] minMax(int[] lst)
        {
            int min = lst.Min();
            int max = lst.Max();
            return new int[] { min, max };
        }
        //https://www.codewars.com/kata/559590633066759614000063/train/csharp
    }
}
