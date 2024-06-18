using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class ReturnTheFirstMMultiplesOfNTask
    {
        public static double[] Multiples(int m, double n)
        {
            int iterator = 1;
            double multiple = 0;
            List<double> result = new List<double>();

            while (iterator <= m)
            {
                multiple += n;
                result.Add(multiple);
                iterator++;
            }

            return result.ToArray();
        }
    }
}
//https://www.codewars.com/kata/593c9175933500f33400003e/train/csharp