using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodeWars7kyu
{
	public class ChainMeTask
	{
		public static double Chain(double input, Func<double, double>[] fs)
		{
			double result = input;

			foreach (var func in fs)
			{
				result = func(result);
			}

			return result;
		}

		public static double add(double x)
		{
			return x + 1;
		}

		public static double mul(double x)
		{
			return x * 30;
		}
	}
}
//https://www.codewars.com/kata/54fb853b2c8785dd5e000957/train/csharp