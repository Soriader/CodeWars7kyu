using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class TriangularNumbersTask
	{
		public static bool IsTriangular(int t)
		{
			long discriminant = 1 + 8L * t;

			long sqrt = (long)Math.Sqrt(discriminant);

			if (sqrt * sqrt != discriminant)
			{
				return false;
			}

			return (sqrt - 1) % 2 == 0;
		}
	}
}
//https://www.codewars.com/kata/56d0a591c6c8b466ca00118b/train/csharp