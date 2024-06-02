using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class DigitsExplosionTask
    {
        public static string Explode(string s)
        {
            string result = "";

            for (int i = 0; i < s.Length; i++)
            {
                int digit = int.Parse(s[i].ToString());

                for (int j = 0; j < digit; j++)
                {
                    result += s[i];
                }
            }

            return result;

        }
    }
}
//https://www.codewars.com/kata/585b1fafe08bae9988000314/train/csharp