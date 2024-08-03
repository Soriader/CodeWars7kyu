using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class CalculateMeanAndConcatenateStringTask
	{
		public static object[] Mean(char[] lst)
		{
			double digit = 0;
			string letters = "";

			object[] result = new object[2];

			for (int i = 0; i < lst.Length; i++)
			{
				if (char.IsDigit(lst[i]))
				{
					digit += lst[i] - '0';
				}

				if (char.IsLetter(lst[i]))
				{
					letters += lst[i];
				}
			}

			result[0] = digit / 10;
			result[1] = letters;

			return result;
		}
	}
}
//https://www.codewars.com/kata/56f7493f5d7c12d1690000b6/train/csharp