using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class UniqueSumTask
	{
		public static int? UniqueSum(List<int> lst)
		{
			if (lst == null || lst.Sum() == 0)
			{
				return null;
			}

			var noDuplicates = lst.Distinct().ToList();

			return noDuplicates.Sum();
		}
	}
}
//https://www.codewars.com/kata/56b1eb19247c01493a000065/train/csharp