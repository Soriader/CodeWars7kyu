using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class ProgressiveSpiralNumberPositionTask
	{
		public static long Layers(long n)
		{
			if (n == 1)
			{
				return 1;
			}

			int result = 1;
			long maxInLayer = 1;

			while (maxInLayer < n)
			{
				maxInLayer += 8 * result;
				result++;
			}

			return result;
		}
	}
}
//https://www.codewars.com/kata/5a254114e1ce0ecf6a000168/train/csharp