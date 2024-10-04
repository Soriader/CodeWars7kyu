using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class InvalidInputErrorHandlingTask
	{
		public int Vowels { get; set; }
		public int Consonants { get; set; }

		public InvalidInputErrorHandlingTask(int vowels, int consonants)
		{
			Vowels = vowels;
			Consonants = consonants;
		}

		public static InvalidInputErrorHandlingTask GetCount(object word)
		{
			if (word == null || !(word is string))
			{
				return new InvalidInputErrorHandlingTask(0, 0);
			}

			string input = word.ToString().ToLower();
			string vowelsForCheck = "aeiou";

			int vowelsCount = 0;
			int consonantsCount = 0;

			foreach (char c in input)
			{
				if (char.IsLetter(c))
				{
					if (vowelsForCheck.Contains(c))
					{
						vowelsCount++;
					}
					else
					{
						consonantsCount++;
					}
				}
			}

			return new InvalidInputErrorHandlingTask(vowelsCount, consonantsCount);
		}
	}
	
}
//https://www.codewars.com/kata/55e6125ad777b540d9000042/train/csharp