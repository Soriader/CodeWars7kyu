using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class SumOfNumbersInSequenceTask
    {
        public static int GetSum(int a, int b)
        {
            int sum = 0;

            if (a == b)
            {
                return a;
            }

            if (a > b)
            {
                for (int i = b; i <= a; i++)
                {
                    sum += i;
                }
            }
            else
            {
                for (int i = a; i <= b; i++)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
//https://www.codewars.com/kata/55f2b110f61eb01779000053/train/csharp