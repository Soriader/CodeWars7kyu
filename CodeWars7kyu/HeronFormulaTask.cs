using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class HeronFormulaTask
	{
		public static double Heron(double a, double b, double c)
		{
			double x = (a + b + c) / 2;

			return Math.Sqrt(x * (x - a) * (x - b) * (x - c));
		}
	}
}
//https://www.codewars.com/kata/57aa218e72292d98d500240f/train/csharp