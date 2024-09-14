using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class TheRejectFunctionTask
	{
		public static int[] Reject(int[] array, Func<int, bool> predicate)
		{
			List<int> result = new List<int>();

			var check = array.Where(x => !predicate(x));
			result.AddRange(check);

			return result.ToArray();

		}
	}
}
//https://www.codewars.com/kata/52988f3f7edba9839c00037d/train/csharp