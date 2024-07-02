using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class ShorterConcatTask
    {
        public static string ShorterReverseLonger(string a, string b)
        {

            a = a ?? string.Empty;
            b = b ?? string.Empty;

            if (a.Length >= b.Length)
            {
                return b + new string(a.Reverse().ToArray()) + b;
            }
            else
            {
                return a + new string(b.Reverse().ToArray()) + a;
            }

        }
    }
}
//https://www.codewars.com/kata/54557d61126a00423b000a45/train/csharp