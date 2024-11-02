using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class HungarianVowelHarmonyTask
	{
		public static string Dative(string word)
		{
			var front = "eéiíöőüű";
			var back = "aáoóuú";

			for (var i = word.Length - 1; i >= 0; i--)
			{
				if (word[i].ToString().Any(ch => front.Contains(ch)))
				{
					return word + "nek";
				}
				else if (word[i].ToString().Any(ch => back.Contains(ch)))
				{
					return word + "nak";
				}
			} 

			return word;
		}
	}
}
//https://www.codewars.com/kata/57fd696e26b06857eb0011e7/train/csharp