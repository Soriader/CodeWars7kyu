using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class AlternateCaseTask
    {
        public static string AlternateCase(string s)
        {
            string result = "";
            var check = s.ToCharArray();

            for (int i = 0; i < check.Length; i++)
            {
                if (char.IsUpper(check[i]))
                {
                    result += check[i].ToString().ToLower();
                }
                else
                {
                    result += check[i].ToString().ToUpper();
                }
            }

            return result;
        }
    }
}
//https://www.codewars.com/kata/57a62154cf1fa5b25200031e/train/csharp