using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class MeanVsMedianTask
	{
		public static string MeanVsMedian(int[] numbers)
		{
			Array.Sort(numbers);
			double median = numbers[numbers.Length / 2];

			long sum = numbers.Sum(x => (long)x);
			double mean = (double)sum / numbers.Length;

			if (median > mean)
			{
				return "median";
			}
			else if (median < mean)
			{
				return "mean";
			}

			return "same";
		}
	}
}
//https://www.codewars.com/kata/5806445c3f1f9c2f72000031/train/csharp