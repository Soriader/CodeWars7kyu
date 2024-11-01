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
			Match m = Regex.Match(price, @"\$\d+\.\d{2}");
			return m.Success && m.Value == price ? (int)(decimal.Parse(m.Value.Substring(1)) * 100) : (int?)null;

		}
	}
}
//https://www.codewars.com/kata/56833b76371e86f8b6000015/train/csharp