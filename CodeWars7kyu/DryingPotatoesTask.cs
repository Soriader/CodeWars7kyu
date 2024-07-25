using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class DryingPotatoesTask
	{
		public static int Potatoes(int p0, int w0, int p1)
		{
			double dryMass = w0 * (100 - p0) / 100.0;

			double finalWeight = dryMass * 100 / (100 - p1);

			return (int)finalWeight;
		}
	}
}
//https://www.codewars.com/kata/58ce8725c835848ad6000007/train/csharp
