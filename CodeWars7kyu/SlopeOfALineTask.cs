using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class SlopeOfALineTask
	{

		public static double? GetSlope(Point p1, Point p2)
		{
			if(p1.X == p2.X)
			{
				return null;
			}

			var resultForX = p2.X - p1.X;
			var resultForY = p2.Y - p1.Y;

			return resultForY / resultForX;
		}
	}

	public class Point : System.Object
	{
		public double X;
		public double Y;

		public Point(double x, double y)
		{
			this.X = x;
			this.Y = y;
		}

		public override string ToString()
		{
			return $"({this.X}, {this.Y})";
		}

		public override bool Equals(object point)
		{
			if (point == null || point.GetType() != this.GetType())
			{
				return false;
			}

			return this.ToString() == point.ToString();
		}
	}

}
//https://www.codewars.com/kata/53222010db0eea35ad000001/train/csharp