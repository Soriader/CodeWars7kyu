using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class SumOfAnglesTask
    {
        public static int Angle(int n)
        {
            if (n < 2)
            {
                return 0;
            }
            else
            {
                return (n - 2) * 180;
            }
        }
    }
}
//https://www.codewars.com/kata/5a03b3f6a1c9040084001765/train/csharp