using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class NumberOfDecimalDigitsTask
    {
        public static int Digits(ulong n)
        {
            int iterator = 0;
            var result = n.ToString().ToCharArray();

            for (int i = 0; i < result.Length; i++)
            {
                if (char.IsDigit(result[i]))
                {
                    iterator++;
                }

            }

            return iterator;
        }
    }
}
//https://www.codewars.com/kata/58fa273ca6d84c158e000052/train/csharp