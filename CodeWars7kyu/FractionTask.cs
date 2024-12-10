using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class FractionTask
	{
		public int Fraction(int a, int b)
		{
			int gcd = GCD(a, b);
			int reducedNumerator = a / gcd;
			int reducedDenominator = b / gcd;

			return reducedNumerator + reducedDenominator;
		}

		private static int GCD(int x, int y)
		{
			while (y != 0)
			{
				int temp = y;
				y = x % y;
				x = temp;
			}
			return x;
		}
	}
}
//https://www.codewars.com/kata/58b8db810f40ea7788000126/train/csharp