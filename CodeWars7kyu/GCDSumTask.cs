using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class GCDSumTask
	{
		public static (int, int) Solve(int s, int g)
		{
			if (s % g != 0)
			{
				return (-1, -1);
			}

			int x = s / g;

			if (x <= 1)
			{
				return (-1, -1);
			}

			return (g, g * (x - 1));
		}
	}
}
//https://www.codewars.com/kata/5dd259444228280032b1ed2a/train/csharp
