using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class FindTheCapitalsTask
    {
        public static int[] Capitals(string word)
        {
            List<int> result = new List<int>(); 
            int index = 0;

            foreach (char c in word)
            {
                if (char.IsUpper(c))
                {
                    result.Add(index); 
                }
                index++;
            }

            return result.ToArray(); 
        }
    }
}
//https://www.codewars.com/kata/539ee3b6757843632d00026b/train/csharp