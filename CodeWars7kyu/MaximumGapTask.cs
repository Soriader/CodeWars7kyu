using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class MaximumGapTask
	{
		public static int MaxGap(int[] numbers)
		{
			var check = numbers.OrderBy(x => x).ToList();

			int maxGap = 0;
			int checkTheGap = 0;

			for (int i = 0; i < check.Count - 1; i++) 
			{
				checkTheGap = check[i + 1] - check[i];

				if (checkTheGap > maxGap) 
				{
					maxGap = checkTheGap;
				}

			}

			return maxGap;
		}
	}
}
//https://www.codewars.com/kata/5a7893ef0025e9eb50000013/train/csharp