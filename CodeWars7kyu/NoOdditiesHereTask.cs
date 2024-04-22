using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class NoOdditiesHereTask
    {
        public static int[] NoOdds(int[] values)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] % 2 == 0)
                {
                    result.Add(values[i]); 
                }
            }

            return result.ToArray();
        }
    }
}
//https://www.codewars.com/kata/51fd6bc82bc150b28e0000ce/train/csharp