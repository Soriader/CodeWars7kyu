using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class AreaOfACircleTask
	{
		public static double CalculateAreaOfCircle(double radius)
		{
			if (radius <= 0)
			{
				throw new ArgumentException("Radius must be a positive number.");
			}

			return (Math.PI * Math.Pow(radius, 2));
		}
	}
}
//https://www.codewars.com/kata/537baa6f8f4b300b5900106c/train/csharp