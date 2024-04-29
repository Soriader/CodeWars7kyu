using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class MostDigitsTask
	{
		public static int FindLongest(int[] number)
		{
			int longestNumberIndex = 0;
			int maxDigits = 0;

			for (int i = 0; i < number.Length; i++)
			{
				int currentDigits = Math.Abs(number[i]).ToString().Length;
				if (currentDigits > maxDigits)
				{
					longestNumberIndex = i;
					maxDigits = currentDigits;
				}
			}

			return number[longestNumberIndex];
		}
	}
}
//https://www.codewars.com/kata/58daa7617332e59593000006/train/csharp