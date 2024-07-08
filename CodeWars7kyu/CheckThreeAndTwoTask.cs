using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class CheckThreeAndTwoTask
    {
        public static bool CheckThreeAndTwo(string[] array)
        {
            Dictionary<string, int> checkTheLetter = new Dictionary<string, int>();

            foreach (string item in array)
            {
                if (checkTheLetter.ContainsKey(item))
                {
                    checkTheLetter[item]++;
                }
                else
                {
                    checkTheLetter[item] = 1;
                }
            }

            bool hasThree = checkTheLetter.ContainsValue(3);
            bool hasTwo = checkTheLetter.ContainsValue(2);

            return hasThree && hasTwo;
        }
    }
}
//https://www.codewars.com/kata/5a9e86705ee396d6be000091/train/csharp