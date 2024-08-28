using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class EasyWallpaperTask
	{
		private static readonly string[] UnitsMap = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen", "twenty" };
		public static string WallPaper(double l, double w, double h)
		{
			if (l <= 0 || w <= 0 || h <= 0)
			{
				return UnitsMap[0];
			}

			double roomPerimeter = 2 * (l + w); 
			double wallArea = roomPerimeter * h;
			double rollCoverage = 10 * 0.52; 

			double rollsNeeded = wallArea / rollCoverage;
			rollsNeeded = rollsNeeded * 1.15; 
			int rollsRoundedUp = (int)Math.Ceiling(rollsNeeded);

			return UnitsMap[rollsRoundedUp];
		}
	}
}
//https://www.codewars.com/kata/567501aec64b81e252000003/train/csharp