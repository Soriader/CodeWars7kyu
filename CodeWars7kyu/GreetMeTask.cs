using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class GreetMeTask
    {
        public static string Greet(string name)
        {
            string realName = "";
            var result = name.ToCharArray();

            for (int i = 0; i < result.Length; i++)
            {
                realName += result[i].ToString().ToLower();

                if (i == 0)
                {
                    realName = result[0].ToString().ToUpper();
                }

            }

            return $"Hello {realName}!";
        }
    }
}
//https://www.codewars.com/kata/535474308bb336c9980006f2/train/csharp