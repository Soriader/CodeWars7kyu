using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class JumpingNumberTask
	{
		public static string JumpingNumber(int number)
		{
			var check = number.ToString().ToCharArray();

			for (int i = 0; i < check.Length - 1; i++)
			{
				int currentDigit = check[i] - '0';
				int nextDigit = check[i + 1] - '0';

				if (Math.Abs(currentDigit - nextDigit) != 1)
				{
					return "Not!!";
				}
			}

			return "Jumping!!";
		}
	}
}
//https://www.codewars.com/kata/5a54e796b3bfa8932c0000ed/train/csharp