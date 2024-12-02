using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class EverythingIsEvenTask
	{
		public static int EnsureEven(double number)
		{
			int result = (int)number;

			if (result % 2 != 0)
			{
				result += Math.Sign(result);
			}

			return result;
		}
	}
}
//https://www.codewars.com/kata/59c0cdbd5fb133c82b00007d/train/csharp