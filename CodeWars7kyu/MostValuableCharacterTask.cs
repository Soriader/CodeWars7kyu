using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class MostValuableCharacterTask
	{
		public static char Solve(string s)
		{
			Dictionary<char, int> firstOccurrence = new Dictionary<char, int>();
			Dictionary<char, int> lastOccurrence = new Dictionary<char, int>();

			for (int i = 0; i < s.Length; i++)
			{
				char c = s[i];

				if (!firstOccurrence.ContainsKey(c))
				{
					firstOccurrence[c] = i;
				}

				lastOccurrence[c] = i;
			}

			char mostValuableChar = s[0];
			int maxDifference = 0;

			foreach (char c in firstOccurrence.Keys)
			{
				int difference = lastOccurrence[c] - firstOccurrence[c]; 

				if (difference > maxDifference || (difference == maxDifference && c < mostValuableChar))
				{
					maxDifference = difference;
					mostValuableChar = c;
				}
			}

			return mostValuableChar;

		}
	}
}
//https://www.codewars.com/kata/5dd5128f16eced000e4c42ba/train/csharp