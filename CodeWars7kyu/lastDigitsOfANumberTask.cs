using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class lastDigitsOfANumberTask
	{
		public static int[] LastDigit(long n, int d)
		{
			var digits = n.ToString().ToCharArray();

			if (d <= 0)
			{
				return new int[] { };
			}

			if (d > digits.Length)
			{
				d = digits.Length;
			}

			List<int> result = new List<int>();

			for (int i = digits.Length - d; i < digits.Length; i++)
			{
				result.Add(digits[i] - '0');
			}

			return result.ToArray();
		}
	}
}
//https://www.codewars.com/kata/5cd5ba1ce4471a00256930c0/train/csharp