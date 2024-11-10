using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class EightBitUnsignedNumberTask
	{
		public static bool EightBitNumber(string str)
		{
			if (string.IsNullOrEmpty(str) || !str.All(char.IsDigit) || str.Any(char.IsWhiteSpace))
			{
				return false;
			}

			if (str.Length > 1 && str.StartsWith("0"))
			{
				return false;
			}

			if (int.TryParse(str, out int number))
			{
				return number >= 0 && number <= 255;
			}

			return false;
		}
	}
}
//https://www.codewars.com/kata/567e8f7b4096f2b4b1000005/train/csharp