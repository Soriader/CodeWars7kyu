using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class EasyLineTask
	{
		public static BigInteger EasyLine(int n)
		{
			return EasyLineHelper(2 * n, n);
		}

		private static BigInteger EasyLineHelper(int n, int k)
		{
			BigInteger result = 1;

			for (int i = 1; i <= k; i++)
			{
				result *= (n - i + 1);
				result /= i;
			}

			return result;
		}
	}
}
//https://www.codewars.com/kata/56e7d40129035aed6c000632/train/csharp