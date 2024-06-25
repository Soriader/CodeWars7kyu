using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class SevenAteNineTask
    {
        public static string SevenAteNine(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return str; 
            }

            char[] check = str.ToCharArray();
            List<char> result = new List<char>();

            for (int i = 0; i < check.Length; i++)
            {
                if (check[i] == '9' && i > 0 && i < check.Length - 1 && check[i - 1] == '7' && check[i + 1] == '7')
                {
                    continue;
                }

                result.Add(check[i]);
            }

            return new string(result.ToArray());
        }
    }
}
//https://www.codewars.com/kata/559f44187fa851efad000087/train/csharp