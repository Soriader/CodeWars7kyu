using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class VeryEvenNumbersTask
	{
		public static bool IsVeryEvenNumber(int number)
		{
			int result = 0;
			var check = number.ToString().ToCharArray();
			int sumOfNumbers = 0;

			foreach (var digit in check)
			{
				sumOfNumbers += digit - '0';
			}

			while (sumOfNumbers.ToString().ToCharArray().Length != 1) 
			{
				check = sumOfNumbers.ToString().ToCharArray();
				sumOfNumbers = 0;

				foreach (var digit in check)
				{
					sumOfNumbers += digit - '0';
				}
			}

			if(sumOfNumbers % 2 == 0)
			{
				return true;
			}
			else 
			{
				return false; 
			}
		}
	}
}
//https://www.codewars.com/kata/58c9322bedb4235468000019/train/csharp
