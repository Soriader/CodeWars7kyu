using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodeWars7kyu
{
    public class FormTheMinimumTask
    {

        public static long MinValue(int[] a)
        {
            var uniqueDigits = a.Distinct().ToArray();
            Array.Sort(uniqueDigits);

            long result = 0;
            long multiplier = 1;

            for (int i = uniqueDigits.Length - 1; i >= 0; i--)
            {
                result += uniqueDigits[i] * multiplier;
                multiplier *= 10;
            }

            return result;

        }




        //skonsultować rozwiązanie 
        //public static long MinValue(int[] a)
        //{
        //    long result = 0;
        //    var noDuplicate = a.Distinct().ToArray();
        //    Array.Sort(noDuplicate);
        //    string mergedString = string.Join(",", noDuplicate);

        //    if (long.TryParse(mergedString, out result))
        //    {
        //        return result;
        //    }
        //    else
        //    {
        //        return 0;            
        //    }

        //}
    }
}
//https://www.codewars.com/kata/5ac6932b2f317b96980000ca/train/csharp