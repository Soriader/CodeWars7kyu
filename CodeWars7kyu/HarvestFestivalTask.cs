using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class HarvestFestivalTask
	{
		public static string Plant(char seed, int water, int fert, int temp)
		{
			if (temp > 30 || temp < 20)
			{
				return String.Concat(Enumerable.Repeat("-", water * water)) + seed;
			}

			string flower = "";
			int flowerLength = (water + fert) * water;
			int iterator = 0;

			while (iterator < flowerLength)
			{
				flower += String.Concat(Enumerable.Repeat("-", water)) + String.Concat(Enumerable.Repeat(seed, fert));
				iterator+= water + fert;
			}

			return flower;
		}
	}
}
//https://www.codewars.com/kata/606efc6a9409580033837dfb/train/csharp