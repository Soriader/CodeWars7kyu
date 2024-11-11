using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodeWars7kyu
{
	public class ClosestToZeroTask
	{
		public static int? Closest(int[] arr)
		{
			if (arr.Contains(0))
			{
				return 0;
			}

			var result = arr.OrderBy(Math.Abs).ThenByDescending(x => x).First();

			if (arr.Contains(-result)) return null;

			return result;
		}
	}
}
//https://www.codewars.com/kata/59887207635904314100007b/train/csharp