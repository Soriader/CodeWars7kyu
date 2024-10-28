using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class DistanceFromTheAverageTask
	{
		public static double[] DistancesFromAverage(int[] input)
		{
			double average = input.Average();
			List<double> result = new List<double>();

			foreach (int i in input) 
			{
				var check = average - i;
				result.Add(Math.Round(check, 2));
			}

			return result.ToArray();	
		}
	}
}
//https://www.codewars.com/kata/568ff914fc7a40a18500005c/train/csharp