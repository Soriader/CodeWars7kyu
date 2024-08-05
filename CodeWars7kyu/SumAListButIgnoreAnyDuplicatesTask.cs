using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class SumAListButIgnoreAnyDuplicatesTask
	{
		public static int SumNoDuplicates(int[] arr)
		{
			Dictionary<int, int> counts = new Dictionary<int, int>();
			int result = 0;

			foreach (var item in arr)
			{
				if (counts.ContainsKey(item))
				{
					counts[item]++;
				}
				else
				{
					counts[item] = 1;
				}
			}

			foreach (var kvp in counts)
			{
				if (kvp.Value == 1)
				{
					result += kvp.Key;
				}
			}

			return result;
		}
	}
}
//https://www.codewars.com/kata/5993fb6c4f5d9f770c0000f2/train/csharp