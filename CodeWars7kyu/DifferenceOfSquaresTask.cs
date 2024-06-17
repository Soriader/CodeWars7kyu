using CodeWars7kyu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class DifferenceOfSquaresTask
    {
        public static int DifferenceOfSquares(int n)
        {
            int sumOfSquares = 0;
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sumOfSquares += i * i;
                sum += i;
            }

            int squareOfSum = sum * sum;

            return squareOfSum - sumOfSquares;

        }
    }
}
//https://www.codewars.com/kata/558f9f51e85b46e9fa000025/train/csharp