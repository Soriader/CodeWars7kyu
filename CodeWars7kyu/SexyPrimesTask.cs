using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class SexyPrimesTask
	{
		public static bool SexyPrime(int x, int y)
		{
			if(!IsPrime(x) || !IsPrime(y) || !IsPrime(y) && !IsPrime(x))
			{
				return false;
			}

			if(Math.Abs(x - y) == 6)
			{
				return true;
			}

			return false;

		}

		static bool IsPrime(int n)
		{
			if (n <= 1)
			{
				return false;
			}
			if (n == 2)
			{
				return true;
			}

			if (n % 2 == 0)
			{
				return false;
			}

			for (int i = 3; i < Math.Sqrt(n); i++)
			{
				if (n % i == 0)
				{
					return false;
				}
			}
			return true;
		}


	}
}
//https://www.codewars.com/kata/56b58d11e3a3a7cade000792/train/csharp