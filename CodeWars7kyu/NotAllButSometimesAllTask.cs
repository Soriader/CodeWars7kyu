using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class NotAllButSometimesAllTask
    {
        public static string Remove(string str, Dictionary<char, int> what)
        {
            var check = str.ToCharArray();
            string result = "";

            foreach (char c in check) 
            {
                if (what.ContainsKey(c) && what[c] > 0)
                {
                    what[c] -= 1;
                }
                else
                {
                    result += c;    
                }
            }

            return result;
        }
    }
}
//https://www.codewars.com/kata/564ab935de55a747d7000040/train/csharp