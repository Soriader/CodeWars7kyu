using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class EvenOrOddWhichIsGreaterTask
	{
		public static string EvenOrOdd(string str)
		{
			var check = str.ToCharArray();
			int even = 0;
			int odd = 0;

			for (int i = 0; i < check.Length; i++)
			{
				if (char.IsDigit(check[i]))
				{
					if (check[i] % 2 == 0)
					{
						even += check[i] - '0';
					}
					else if (check[i] % 2 != 0)
					{
						odd += check[i] - '0';
					}
				}
			}

			if (even > odd)
			{
				return "Even is greater than Odd";
			}
			else if(odd > even)
			{
				return "Odd is greater than Even";
			}

			return "Even and Odd are the same";

		}
	}
}
//https://www.codewars.com/kata/57f7b8271e3d9283300000b4/train/csharp