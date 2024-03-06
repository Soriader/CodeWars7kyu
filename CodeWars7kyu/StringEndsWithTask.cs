using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class StringEndsWithTask
    {
        public static bool Solution(string str, string ending)
        {
            bool findTheAnswer = str.EndsWith(ending);

            if (findTheAnswer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
//https://www.codewars.com/kata/51f2d1cafc9c0f745c00037d/train/csharp