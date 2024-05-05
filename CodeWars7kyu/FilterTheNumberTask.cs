using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class FilterTheNumberTask
    {
        public static int FilterString(string s)
        {
            List<int> listOfNumbers = new List<int> ();
            var result = s.ToCharArray();

            for (int i = 0; i < result.Length; i++)
            {
                if (char.IsDigit(result[i]))
                {
                    listOfNumbers.Add(int.Parse(result[i].ToString()));                
                }
            }

            string concatenatedDigits = string.Concat(listOfNumbers);
            return int.Parse(concatenatedDigits);
        }
    }
}
//https://www.codewars.com/kata/55b051fac50a3292a9000025/train/csharp