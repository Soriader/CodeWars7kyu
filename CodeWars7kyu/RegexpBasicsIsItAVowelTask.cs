using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class RegexpBasicsIsItAVowelTask
	{
		public static bool Vowel(string s)
		{
			string vowels = "aeiou";

			if (s.Length == 1 && vowels.Contains(s.ToLower()))
			{
				return true;
			}

			return false;

		}
	}
}
//https://www.codewars.com/kata/567bed99ee3451292c000025/train/csharp