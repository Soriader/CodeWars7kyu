using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class IsTriangleTask
    {
        public static bool IsTriangle(int a, int b, int c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                return false;
            }
            if (a >= b + c || b >= a + c || c >= a + b)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
//https://www.codewars.com/kata/56606694ec01347ce800001b/train/csharp