using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class SeeYouNextHappyYearTask
	{
		public short NextHappyYear(short year)
		{
			while (true)
			{
				year++;
				if (HasUniqueDigits(year))
				{
					return year;
				}
			}
		}

		private static bool HasUniqueDigits(int year)
		{
			string checkYear = year.ToString();

			HashSet<char> digits = new HashSet<char>();

			foreach (char digit in checkYear)
			{
				if (!digits.Add(digit)) 
				{
					return false;
				}
			}
			return true;
		}
	}
}
//https://www.codewars.com/kata/5ae7e3f068e6445bc8000046/train/csharp