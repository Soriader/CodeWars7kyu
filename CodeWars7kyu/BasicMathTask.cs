using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class BasicMathTask
    {
        public static string Calculate(string str)
        {
            string[] parts = Regex.Split(str, "(plus|minus)");

            int result = int.Parse(parts[0]);

            for (int i = 1; i < parts.Length; i += 2)
            {
                string operation = parts[i];
                int nextNumber = int.Parse(parts[i + 1]);

                if (operation == "plus")
                {
                    result += nextNumber;
                }
                else if (operation == "minus")
                {
                    result -= nextNumber;
                }
            }

            return result.ToString();

        }

        //    return str.Replace("plus", " +").Replace("minus", " -").Split().Sum(int.Parse).ToString();

    }
}
//https://www.codewars.com/kata/5809b62808ad92e31b000031/train/csharp