using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class LCMTask
	{
		public static int SumDifferencesBetweenProductsAndLCMs(int[][] pairs)
		{
			if(pairs is null)
			{
				return 0;
			}

			List<int> result = new List<int>();

			for (int i = 0; i < pairs.Length; i++)
			{
				if (pairs[i][0] == 0)
				{
					continue;
				}

				int a = pairs[i][0];
				int b = pairs[i][1];

				int product = a * b;
				int lcm = (a * b) / Gcd(a, b);

				result.Add(product - lcm);
			}

			return result.Sum();
		}

		private static int Gcd(int a, int b)
		{
			while (b != 0)
			{
				int temp = b;
				b = a % b;
				a = temp;
			}
			return a;
		}
	}
}
//https://www.codewars.com/kata/56e56756404bb1c950000992/train/csharp