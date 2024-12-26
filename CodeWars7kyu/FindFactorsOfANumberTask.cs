using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class FindFactorsOfANumberTask
    {
        public static int[] Factors(int num)
        {
            int iterator = 1;
            List<int> result = new List<int>();   

            while(iterator < num)
            {
                if(num % iterator == 0)
                {
                    result.Add(iterator);
                }

                iterator++;

                if(iterator == num)
                {
                    result.Add(iterator);
                    break;
                }
            }

            return result.OrderByDescending(x => x).ToArray();
        }
    }
}
//https://www.codewars.com/kata/564fa92d1639fbefae00009d/train/csharp