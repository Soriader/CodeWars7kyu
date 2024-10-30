using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class BuildingSpheresTask
	{
		private int radius;
		private int mass;

		public BuildingSpheresTask(int radius, int mass)
		{
			this.radius = radius;
			this.mass = mass;
		}

		public int GetRadius()
		{
			return radius;
		}

		public int GetMass()
		{
			return mass;
		}

		public double GetVolume()
		{
			double volume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
			return Math.Round(volume, 5);
		}

		public double GetSurfaceArea()
		{
			double surfaceArea = 4 * Math.PI * Math.Pow(radius, 2);
			return Math.Round(surfaceArea, 5);
		}

		public double GetDensity()
		{
			double density = (double)mass / GetVolume();
			return Math.Round(density, 5);
		}

	}
}
//https://www.codewars.com/kata/55c1d030da313ed05100005d/train/csharp