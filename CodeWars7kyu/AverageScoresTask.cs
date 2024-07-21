using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class AverageScoresTask
	{
		public static int Average(int[] scores)
		{
			double sum = scores.Sum();
			double length = scores.Length;
			double result = sum / length;

			return (int)Math.Round(result);
		}
	}
}
//https://www.codewars.com/kata/57b68bc7b69bfc8209000307/train/csharp