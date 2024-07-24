using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class ChangingLettersTask
	{
		public static string Swap(string s)
		{
			var vowels = new char[] { 'a', 'o', 'i', 'e', 'u' };

			var check = s.ToCharArray();

			string result = "";

			foreach (char c in check)
			{
				if (vowels.Contains(char.ToLower(c)))
				{
					result += char.ToUpper(c);
				}
				else
				{
					result += c;
				}
			}

		    return result;
		}
	}
}
//https://www.codewars.com/kata/5831c204a31721e2ae000294/train/csharp