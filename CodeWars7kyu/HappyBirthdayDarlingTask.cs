using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class HappyBirthdayDarlingTask
	{
		public static string WomensAge(int n)
		{

			var checkTheBase = n / 2;

			if (n == checkTheBase * 2)
			{
				return $"{n}? That's just 20, in base {checkTheBase}!";
			}
			else
			{
				return $"{n}? That's just 21, in base {checkTheBase}!";
			}

		}
	}
}
//https://www.codewars.com/kata/5e96332d18ac870032eb735f/train/csharp