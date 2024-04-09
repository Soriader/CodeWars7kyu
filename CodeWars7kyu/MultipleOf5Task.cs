using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodeWars7kyu
{
    public class MultipleOf5Task
    {
        public static int RoundToNext5(int n)
        {
            //if (n == -2 && n == -1 && n == 0) return 0;
            int roundedNumber = (int)Math.Ceiling(n / 5.0) * 5;

            return roundedNumber;

        }
    }
}
//https://www.codewars.com/kata/55d1d6d5955ec6365400006d/train/csharp