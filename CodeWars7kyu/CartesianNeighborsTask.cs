using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class CartesianNeighborsTask
	{
		public static IEnumerable<int[]> CartesianNeighbor(int x, int y)
		{
			List<int[]> result = new List<int[]>();

			result.Add(new int[] { x - 1, y - 1 });
			result.Add(new int[] { x - 1, y });
			result.Add(new int[] { x - 1, y + 1 });
			result.Add(new int[] { x, y - 1 });
			result.Add(new int[] { x, y + 1 });
			result.Add(new int[] { x + 1, y - 1 });
			result.Add(new int[] { x + 1, y });
			result.Add(new int[] { x + 1, y + 1 });

			return result;
		}
	}
}
//https://www.codewars.com/kata/58989a079c70093f3e00008d/train/csharp