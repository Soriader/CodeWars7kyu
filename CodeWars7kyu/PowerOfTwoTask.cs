using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class PowerOfTwoTask
    {
        public static bool PowerOfTwo(int n)
        {

            return (n > 0) && ((n & (n - 1)) == 0);

        }
    }
}
//https://www.codewars.com/kata/534d0a229345375d520006a0/train/csharp