using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class InitializeMyNameTask
    {
        public static string InitializeNames(string name)
        {
            var check = name.Split(" ");
            string result = "";

            if (check.Length > 2) 
            {
                result += check[0] + " ";

                for (int i = 1; i < check.Length - 1; i++)
                {
                    result +=  check[i].ToUpper().ToCharArray().First() + "." + " ";
                }

                result += check.Last();
            }
            else
            {
                result = name;
            }

            return result;
        }
    }
}
//https://www.codewars.com/kata/5768a693a3205e1cc100071f/train/csharp