using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class OddOrEvenTask
    {
        public static string OddOrEven(int[] array)
        {
            if(array.Length == 0)
            {
                return "even";
            }
            int result = array.Aggregate((x, y) => x + y);


            if (result % 2 == 0)
            {
                return "even";
            }
            else return "odd";

        }
    }
}
//https://www.codewars.com/kata/5949481f86420f59480000e7/train/csharp