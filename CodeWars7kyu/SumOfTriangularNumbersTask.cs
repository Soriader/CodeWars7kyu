using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class SumOfTriangularNumbersTask
    {
        public static int SumTriangularNumbers(int n)
        {
            int iterator = 0;
            int result = 0;

            while (iterator < n)
            {
                iterator++;
                result += (iterator + 1) * iterator / 2;
            }

            return result;
        }
    }
}
//https://www.codewars.com/kata/580878d5d27b84b64c000b51/train/csharp