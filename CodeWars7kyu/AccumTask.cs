using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class AccumTask
    {
        public static String Accum(string s)
        {
            string result = "";

            for (int i = 0; i < s.Length; i++)
            {

                result += char.ToUpper(s[i]);

                for (int j = 0; j < i; j++)
                {
                    result += char.ToLower(s[i]);
                }
                if (i < s.Length - 1)
                {
                    result += "-";
                }
            }

            return result;

            //https://www.codewars.com/kata/5667e8f4e3f572a8f2000039/train/csharp
        }
    }
}
