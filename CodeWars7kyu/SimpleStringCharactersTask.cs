using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class SimpleStringCharactersTask
    {
        public static int[] Solve(String s)
        {
            int uppercaseLetters = 0;
            int lowercase = 0;
            int numbers = 0;
            int specialCharacters = 0;

            char[] check = s.ToCharArray();

            for (int i = 0; i < check.Length; i++)
            {
                if (char.IsUpper(check[i]))
                {
                    uppercaseLetters++;
                }

                if (char.IsLower(check[i]))
                {
                    lowercase++;
                }

                if (char.IsDigit(check[i]))
                {
                    numbers++;
                }

                if (!char.IsLetterOrDigit(check[i]))
                {
                    specialCharacters++;
                }
            }

            return new int[] { uppercaseLetters, lowercase, numbers, specialCharacters };
        }
    }
}
//https://www.codewars.com/kata/5a29a0898f27f2d9c9000058/train/csharp