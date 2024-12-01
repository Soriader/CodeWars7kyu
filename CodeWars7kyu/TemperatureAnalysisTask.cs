using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class TemperatureAnalysisTask
	{
		public static int? LowestTemperature(string t)
		{
			if (t is null || t == "")
			{
				return null;
			}

			List<int> temperature = new List<int>();
			string[] parts = t.Split(' ');

			foreach (var part in parts)
			{
				if (int.TryParse(part, out int temp))
				{
					temperature.Add(temp);
				}
			}

			return temperature.Min();
		}
	}
}
//https://www.codewars.com/kata/588e0f11b7b4a5b373000041/train/csharp