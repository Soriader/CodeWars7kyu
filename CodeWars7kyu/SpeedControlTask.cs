using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class SpeedControlTask
	{
		public static int Gps(int s, double[] x)
		{
			if (x.Length <= 1)
			{
				return 0;
			}

			double maxSpeed = 0;

			for (int i = 1; i < x.Length; i++)
			{
				double deltaDistance = x[i] - x[i - 1];

				double speed = (3600 * deltaDistance) / s;

				if (speed > maxSpeed)
				{
					maxSpeed = speed;
				}
			}

			return (int)Math.Floor(maxSpeed);

		}
	}
}
//https://www.codewars.com/kata/56484848ba95170a8000004d/train/csharp