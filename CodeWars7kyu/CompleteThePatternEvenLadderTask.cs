using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class CompleteThePatternEvenLadderTask
	{
		public static string Pattern(int n)
		{
			if(n <= 1)
			{
				return "";
			}

			string result = "";
			int patternMax = n;
			int iterator = 2;

			if(patternMax % 2 != 0)
			{
				patternMax--;
			}

			int patternStart = 2;

			while (iterator <= patternMax)
			{
				result += String.Concat(Enumerable.Repeat(patternStart.ToString(), patternStart)) + "\n";
				iterator += 2;
				patternStart += 2;
			}


			return result.TrimEnd('\n');
		}
	}
}
//https://www.codewars.com/kata/55749101ae1cf7673800003e/train/csharp