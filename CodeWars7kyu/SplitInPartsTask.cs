using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class SplitInPartsTask
    {
        public static string SplitInParts(string s, int partLength)
        {
            var letter = s.ToCharArray();
            int iterator = 0;
            string result = "";

            for (int i = 0; i < letter.Length; i++)
            {
                result += letter[i];
                iterator ++;    
                if(iterator == partLength)
                {
                    result += " ";
                    iterator = 0;
                }
            }

            return result.Trim();
        }
    }
}
//https://www.codewars.com/kata/5650ab06d11d675371000003/train/csharp