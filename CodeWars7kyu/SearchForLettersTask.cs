using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class SearchForLettersTask
	{
		public static string Change(string input)
		{
			char[] result = new char[26];
			for (int i = 0; i < 26; i++)
			{
				result[i] = '0';
			}

			foreach (char c in input)
			{
				if (char.IsLetter(c))
				{
					int index = char.ToLower(c) - 'a';

					if (index >= 0 && index < 26)
					{
						result[index] = '1';
					}
				}
			}

			return new string(result);
		}
	}
}
//https://www.codewars.com/kata/52dbae61ca039685460001ae/train/csharp