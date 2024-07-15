using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class RowWeightsTask
    {
        public static int[] RowWeights(int[] a)
        {
            List<int> result = new List<int>();
            int firstGroup = 0;
            int secondGroup = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if(i % 2 == 0)
                {
                    firstGroup += a[i];
                }
                else
                {
                    secondGroup += a[i];
                }
            }

            result.Add(firstGroup);
            result.Add(secondGroup);

            return result.ToArray();
        }

    }
}
//https://www.codewars.com/kata/5abd66a5ccfd1130b30000a9/train/csharp