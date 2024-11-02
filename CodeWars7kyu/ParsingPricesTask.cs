using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class ParsingPricesTask
	{
		public static int? ToCents(string price)
		{
			return Regex.IsMatch(price, @"\A\$\d+\.\d\d\z") ? Convert.ToInt32(Regex.Replace(price.Substring(1), @"\.", "")) : null;
		}
	}
}
//https://www.codewars.com/kata/56833b76371e86f8b6000015/train/csharp