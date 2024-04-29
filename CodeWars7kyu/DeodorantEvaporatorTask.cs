using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class DeodorantEvaporatorTask
	{
		public static int Evaporator(double content, double evap_per_day, double threshold)
		{
			int days = 0;
			double remainingContent = content;
			double thresholdVolume = content * (threshold / 100);

			while (remainingContent > thresholdVolume)
			{
				remainingContent *= (1 - (evap_per_day / 100));
				days++;
			}

			return days;
		}
	}
}
//https://www.codewars.com/kata/5506b230a11c0aeab3000c1f/train/csharp