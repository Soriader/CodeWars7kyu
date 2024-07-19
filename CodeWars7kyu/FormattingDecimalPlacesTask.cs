using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class FormattingDecimalPlacesTask
	{
		public static double TwoDecimalPlaces(double number)
		{
			string str = number.ToString("F15", System.Globalization.CultureInfo.InvariantCulture);

			int decimalPointIndex = str.IndexOf('.');

			if (decimalPointIndex != -1)
			{
				str = str.Substring(0, decimalPointIndex + 3);
			}

			return double.Parse(str, System.Globalization.CultureInfo.InvariantCulture);
		}
	}
}
//https://www.codewars.com/kata/5641c3f809bf31f008000042/train/csharp