using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class ReverseFactorialsTask
	{
		public static string ReverseFactorial(long num)
		{
			long result = 1;
			long sum = 1;

			while (sum < num)
			{
				result++;
				sum *= result;
			}

			return sum == num ? $"{result}!" : "None";

		}
	}
}
//https://www.codewars.com/kata/58067088c27998b119000451/train/csharp