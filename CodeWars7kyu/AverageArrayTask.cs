using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class AverageArrayTask
	{
		public static double[] AvgArray(double[][] arr)
		{
			int length = arr[0].Length; 
			double[] result = new double[length];

			for (int i = 0; i < length; i++)
			{
				double sum = 0;
				for (int j = 0; j < arr.Length; j++)
				{
					sum += arr[j][i];
				}
				result[i] = sum / arr.Length;
			}

			return result;
		}
	}
}
//https://www.codewars.com/kata/596f6385e7cd727fff0000d6/train/csharp