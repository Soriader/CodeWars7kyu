using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class TwoNumbersArePositiveTask
	{
		public static bool TwoArePositive(int a, int b, int c)
		{
			if ((a > 0 && b > 0 && c <= 0) || (a <= 0 && b > 0 && c > 0) || (a > 0 && b <= 0 && c > 0))
			{
				return true;
			}

			return false;
		}
	}
}
//https://www.codewars.com/kata/602db3215c22df000e8544f0/train/csharp