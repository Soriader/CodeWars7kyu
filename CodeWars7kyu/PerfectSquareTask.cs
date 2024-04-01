using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class PerfectSquareTask
    {
        public static long FindNextSquare(long num)
        {
            double squareRoot = Math.Sqrt(num);

            long roundedSquareRoot = (long)Math.Floor(squareRoot);

            if (roundedSquareRoot * roundedSquareRoot == num)
            {
                long nextSquare = roundedSquareRoot + 1;
                return nextSquare * nextSquare;
            }
            else
            {
                return -1;
            }
        }
    }
}
//https://www.codewars.com/kata/56269eb78ad2e4ced1000013/train/csharp