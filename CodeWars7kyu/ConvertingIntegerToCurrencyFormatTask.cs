using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class ConvertingIntegerToCurrencyFormatTask
	{
		public static string ToCurrency(int price)
		{
			var check = price.ToString().ToCharArray();
			int iterator = 0;
			string result = "";

			for (int i = check.Length - 1; i >= 0; i--)
			{
				result += check[i];
				iterator++;

				if (iterator == 3 && i != 0)
				{
					result += ",";
					iterator = 0;
				}
			}

			return new string(result.Reverse().ToArray());
		}
	}
}
//https://www.codewars.com/kata/54e9554c92ad5650fe00022b/train/csharp