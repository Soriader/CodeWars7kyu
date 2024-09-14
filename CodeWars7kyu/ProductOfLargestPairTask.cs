using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class ProductOfLargestPairTask
	{
		public static int MaxProduct(int[] array)
		{
			var bigNumbers = array.OrderByDescending(x => x).Take(2).ToArray();

			return bigNumbers[0] * bigNumbers[1];

		}
	}
}
//https://www.codewars.com/kata/5784c89be5553370e000061b/train/csharp