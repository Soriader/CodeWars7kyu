using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class BandNameGeneratorTask
    {
        public static string BandNameGenerator(string str)
        {
            if (str[0] == str[str.Length - 1])
            {
                string capitalized = char.ToUpper(str[0]) + str.Substring(1);
                return capitalized + str.Substring(1);
            }
            else
            {
                return "The " + char.ToUpper(str[0]) + str.Substring(1);
            }
        }
    }
}
//https://www.codewars.com/kata/59727ff285281a44e3000011/train/csharp