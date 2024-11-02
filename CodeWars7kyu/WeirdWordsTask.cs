using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class WeirdWordsTask
	{
		public static string NextLetter(string str)
		{
			string result = "";

			for (int i = 0; i < str.Length; i++)
			{
				char current = str[i];

				if (char.IsUpper(current))
				{
					result += current == 'Z' ? 'A' : (char)(current + 1);
				}
				else if (char.IsLower(current))
				{
					result += current == 'z' ? 'a' : (char)(current + 1);
				}
				else
				{
					result += current;
				}
			}

			return result;
		}
	}
}
//https://www.codewars.com/kata/57b2020eb69bfcbf64000375/train/csharp