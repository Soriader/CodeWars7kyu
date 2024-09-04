using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class PossibilitiesArrayTask
	{
		public static bool IsAllPossibilities(int[] arr)
		{
			int n = arr.Length;

			return arr.OrderBy(x => x).SequenceEqual(Enumerable.Range(0, n));
		}
	}
}

//https://www.codewars.com/kata/59b710ed70a3b7dd8f000027/train/csharp