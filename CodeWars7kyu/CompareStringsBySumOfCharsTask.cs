using CodeWars7kyu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class CompareStringsBySumOfCharsTask
    {
        public static bool Compare(string s1, string s2)
        {
            s1 = s1 ?? "";
            s2 = s2 ?? "";

            s1 = s1.ToUpper();
            s2 = s2.ToUpper();

            bool isS1Valid = s1.All(char.IsLetter);
            bool isS2Valid = s2.All(char.IsLetter);

            if (!isS1Valid) s1 = "";
            if (!isS2Valid) s2 = "";

            var check1 = s1.ToCharArray();
            var check2 = s2.ToCharArray();

            int firstResult = 0;
            int secondResult = 0;

            foreach (var letter in check1)
            {
                if (char.IsLetter(letter))
                {
                    firstResult += Convert.ToInt32(letter);
                }
            }

            foreach (var letter in check2)
            {
                if (char.IsLetter(letter))
                {
                    secondResult += Convert.ToInt32(letter);
                }
            }

            return firstResult == secondResult;

        }
    }
}
//https://www.codewars.com/kata/576bb3c4b1abc497ec000065/train/csharp
