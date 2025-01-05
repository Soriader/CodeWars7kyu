using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class SimpleInterestAndCompoundInterestTask
    {
        public static int[] Interest(int p, double r, int n)
        {
            var result = new int[2];
            var pFor0 = (p + (p*r*n));
            result[0] = (int)Math.Round(pFor0);


            int iterator = 0;
            double pFor1 = p;

            while (iterator < n) 
            {
                pFor1 += (pFor1 * r);
                iterator++;
            }

            result[1] = (int)Math.Round(pFor1);

            return result;
        }
    }
}
//https://www.codewars.com/kata/59cd0535328801336e000649/train/csharp