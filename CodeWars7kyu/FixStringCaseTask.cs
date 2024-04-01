using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class FixStringCaseTask
    {
        public static string Solve(string s)
        {
            string lowercase = "";
            string uppercase = "";

            foreach (char c in s)
            {
                if (char.IsLower(c))
                {
                    lowercase += c;
                }
                else if (char.IsUpper(c))
                {
                    uppercase += c;
                }
            }

            if(uppercase.Length > lowercase.Length)
            {
                return s.ToUpper();
            }

            return s.ToLower();
        }
    }
}
//https://www.codewars.com/kata/5b180e9fedaa564a7000009a/train/csharp