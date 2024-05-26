using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class OddEvenStringSortTask
    {
        public static string SortMyString(string s)
        {
            string even = "";
            string odd = "";
            char[] chars = s.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (i % 2 != 0)
                {
                    odd += chars[i];
                }

                if (i % 2 == 0)
                {
                    even += chars[i];
                }
            }

            return $"{even} {odd}";
        }
    }
}
//https://www.codewars.com/kata/580755730b5a77650500010c/train/csharp