using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class AlternateCapitalizationTask
    {
        public static string[] Capitalize(string s)
        {
            List<string> list = new List<string>();

            for (int i = 0; i < s.Length; i++)
            {
                if (i % 2 == 0)
                {
                    list.Add(char.ToUpper(s[i]).ToString());
                }
                else
                {
                    list.Add(char.ToLower(s[i]).ToString());
                }
            }

            string[] result = new string[2];
            result[0] = string.Join("", list);
            list.Clear();
            for (int i = 0; i < s.Length; i++)
            {
                if (i % 2 == 0)
                {
                    list.Add(char.ToLower(s[i]).ToString());
                }
                else
                {
                    list.Add(char.ToUpper(s[i]).ToString());
                }
            }
            result[1] = string.Join("", list);

            return result;
        }
    }
}
//https://www.codewars.com/kata/59cfc000aeb2844d16000075/train/csharp