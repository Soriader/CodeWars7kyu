using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class TheOldSwitcherooTask
	{
		public static string Encode(string str)
		{
			Dictionary<char, int> letterToNumber = new Dictionary<char, int>();

			for (char letter = 'a'; letter <= 'z'; letter++)
			{
				letterToNumber[letter] = letter - 'a' + 1;
			}

			string result = "";

			var check = str.ToLower().ToCharArray();

			foreach (char letter in check)
			{
				if (char.IsLetter(letter)) 
				{
					result += letterToNumber[letter].ToString();             
				}
				else
				{
					result += letter;
				}
			}

			return result;
		}
	}
}
//https://www.codewars.com/kata/55d6a0e4ededb894be000005/train/csharp