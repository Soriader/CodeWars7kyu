using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class SwitcherooTask
    {
        public static string Switcheroo(string x)
        {
            var result = x.ToCharArray();

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] == 'a')
                {
                    result[i] = 'b';
                }
                else if (result[i] == 'b')
                {
                    result[i] = 'a';
                }
            }

            return new string(result);

        }
    }
}
//https://www.codewars.com/kata/57f759bb664021a30300007d/train/csharp