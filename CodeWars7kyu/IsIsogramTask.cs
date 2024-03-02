using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class IsIsogramTask
    {
        public static bool IsIsogram(string str)
        {
            var chars = str.ToLower().ToCharArray();
            var hash = new HashSet<char>();

            foreach (var c in chars)
            {
                if (hash.Contains(c))
                {
                    return false;
                }
                else
                {
                    hash.Add(c);
                }
            }

            return true;

            //https://www.codewars.com/kata/54ba84be607a92aa900000f1/train/csharp
        }
    }
}
