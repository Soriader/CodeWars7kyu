using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class ConvertAnArrayOfStringsToArrayOfNumbersTask
    {
        public static double[] ToDoubleArray(string[] stringArray)
        {
            List<double> result = new List<double>();
            double numbers = 0;

            for (int i = 0; i < stringArray.Length; i++)
            {
                var toDouble = double.TryParse(stringArray[i], NumberStyles.Float, CultureInfo.InvariantCulture, out numbers);

                if (toDouble)
                {
                    result.Add(numbers);
                }
            }

            return result.ToArray();
        }
    }
}
//https://www.codewars.com/kata/5783d8f3202c0e486c001d23/train/csharp