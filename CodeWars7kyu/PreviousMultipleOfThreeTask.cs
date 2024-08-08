using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class PreviousMultipleOfThreeTask
	{
		public static int? PreviousMultipleOfThree(int n)
		{
			if (n % 3 == 0)
			{
				return n;
			}

			while (n > 0)
			{
				n /= 10;

				if (n % 3 == 0 && n > 0)
				{
					return n;
				}
			}

			return null;

		}
		
	}
}
//https://www.codewars.com/kata/61123a6f2446320021db987d/train/csharp