using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class CharCodeCalculationTask
    {
        public static Int32 Calc(String s)
        {
            var letter = s.ToCharArray();
            string total1 = "";

            for (int i = 0; i < letter.Length; i++)
            {
                total1 += (int)letter[i];
            }

            var total2 = total1.Replace("7", "1");

            var checkTotal1 = total1.ToCharArray();
            var checkTotal2 = total2.ToCharArray();
            int sumOfTotal1 = 0;
            int sumOfTotal2 = 0;

            for (int i = 0; i < checkTotal1.Length; i++)
            {
                sumOfTotal1 += (int)checkTotal1[i];
            }

            for (int i = 0; i < checkTotal2.Length; i++)
            {
                sumOfTotal2 += (int)checkTotal2[i];
            }

            return sumOfTotal1 - sumOfTotal2;
        }
    }
}
//https://www.codewars.com/kata/57f75cc397d62fc93d000059/train/csharp