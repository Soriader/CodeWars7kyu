using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodeWars7kyu
{
    public class ReturnStringOfFirstCharactersTask
    {
        public static string MakeString(string s)
        {
            string result = "";
            var words = s.Split(' '); 

            foreach (var word in words)
            {
                result += word[0]; 
            }

            return result;
        }
    }
}
//https://www.codewars.com/kata/5639bdcef2f9b06ce800005b/train/csharp