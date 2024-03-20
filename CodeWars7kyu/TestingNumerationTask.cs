using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class TestingNumerationTask
    {
        public static List<string> Number(List<string> lines)
        {
            int start = 1;
            List<string> result = new List<string>();

            foreach (string line in lines)
            {
                result.Add((start + ": " + line));
                start++;
            }

            return result;
        }
    }
}
//https://www.codewars.com/kata/54bf85e3d5b56c7a05000cf9/train/csharp