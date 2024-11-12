using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class StackedBalls2DTask
	{
		public static double StackHeight2d(int layers)
		{
			if(layers == 1)
			{
				return 1;
			}

			double result = 1 + (layers - 1) * (Math.Sqrt(3) / 2);

			return Math.Round(result, 3);
		}
	}
}
//https://www.codewars.com/kata/5bb804397274c772b40000ca/train/csharp