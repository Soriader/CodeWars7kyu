using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class MaximumProductTask
    {
        public static int AdjacentElementsProduct(int[] array)
        {
            int iterator = 0;
            List<int> result = new List<int> ();

            for (int i = 0; i < array.Length - 1; i++)
            {
                iterator = array[i] * array[i + 1];
                result.Add(iterator);
            }
        
            var maxValue = result.Max (x => x);

            return maxValue;
        }
    }
}
//https://www.codewars.com/kata/5a4138acf28b82aa43000117/train/csharp