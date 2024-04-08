using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class CreateFactorialmethodTask
    {
        public static ulong Factorial(int n)
        {
            ulong result = 1;

            while(n > 0)
            {
                result *= (ulong)n;
                n--;
            }

            return result;
        }
    }
}
//https://www.codewars.com/kata/57a049e253ba33ac5e000212/train/csharp