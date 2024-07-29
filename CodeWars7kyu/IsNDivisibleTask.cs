using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class IsNDivisibleTask
	{
		public static bool IsDivisible(params int[] numbers)
		{

			for (int i = 0; i < numbers.Length; i++)
			{
				if (numbers[0] % numbers[i] != 0)
				{
					return false;
				}
			}

			return true;
		}
	}
}
//https://www.codewars.com/kata/558ee8415872565824000007/train/csharp