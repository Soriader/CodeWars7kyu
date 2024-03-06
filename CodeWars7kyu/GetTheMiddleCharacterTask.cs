using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class GetTheMiddleCharacterTask
    {
        public static string GetMiddle(string s)
        {
            int length = s.Length;
            int middle = length / 2;

            if (length % 2 == 0)
            {
                return s.Substring(middle - 1, 2);
            }
            else
            {
                return s.Substring(middle, 1);
            }
        }
    }
}
//https://www.codewars.com/kata/56747fd5cb988479af000028/train/csharp