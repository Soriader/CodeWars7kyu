using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class MoveAllVowelsTask
	{
		public static string MoveVowel(string input)
		{
			string vowels = "aeiou";

			var noVowels = new string(input.Where(c => !vowels.Contains(c)).ToArray());

			var findVowels = new string(input.Where(c => vowels.Contains(c)).ToArray());

			return noVowels + findVowels;
		}
	}
}
//https://www.codewars.com/kata/56bf3287b5106eb10f000899/train/csharp