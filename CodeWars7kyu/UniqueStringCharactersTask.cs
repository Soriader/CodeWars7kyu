using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class UniqueStringCharactersTask
    {
        public static string Solve(string a, string b)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in a)
            {
                if (!b.Contains(c))
                {
                    result.Append(c);
                }
            }

            foreach (char c in b)
            {
                if (!a.Contains(c))
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
    }
}
//https://www.codewars.com/kata/5a262cfb8f27f217f700000b/train/csharp