using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class TargetDateTask
	{
		public static string DateNbDays(double a0, double a, double p)
		{
			var startDate = new DateTime(2016, 1, 1);
			int days = 0;
			var moneyWeNeed = a0;

			while (moneyWeNeed <= a)
			{
				moneyWeNeed += moneyWeNeed * (p / 36000);
				days++;
			}
			DateTime resultDate = startDate.AddDays(days);

			return resultDate.ToString("yyyy-MM-dd");

		}
	}
}
//https://www.codewars.com/kata/569218bc919ccba77000000b/train/csharp