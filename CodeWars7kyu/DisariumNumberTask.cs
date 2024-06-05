using CodeWars7kyu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class DisariumNumberTask
    {
        public static string DisariumNumber(int number)
        {
            var checkTheNumber = number.ToString().ToCharArray();
            double resultOfSum = 0;

            for (int i = 0; i < checkTheNumber.Length; i++)
            {
                resultOfSum += Math.Pow(char.GetNumericValue(checkTheNumber[i]), i + 1);
            }

            if (number == resultOfSum) return "Disarium !!";

            return "Not !!";
        }
    }
}
//https://www.codewars.com/kata/5a53a17bfd56cb9c14000003/train/csharp