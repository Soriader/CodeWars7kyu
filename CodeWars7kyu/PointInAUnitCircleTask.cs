using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class PointInAUnitCircleTask
	{
		public static bool PointInCircle(double x, double y)
		{
			if(Math.Sqrt((Math.Pow(x, 2) + Math.Pow(y, 2))) < 1)
			{
				return true;
			}

			return false;
		}
	}
}
//https://www.codewars.com/kata/58da7ae9b340a2440500009c/train/csharp