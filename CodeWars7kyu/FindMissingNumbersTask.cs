using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class FindMissingNumbersTask
	{
		public static int[] FindMissingNumbers(int[] arr)
		{
			if (arr.Length == 0)
			{
				return new int[0];
			}

			List<int> result = new List<int>();

			var uniqueNumbers = new HashSet<int>(arr);

			int min = arr.Min();
			int max = arr.Max();

			for (int i = min; i <= max; i++)
			{
				if (!uniqueNumbers.Contains(i))
				{
					result.Add(i);
				}
			}

			return result.ToArray();

		}
	}
}
//https://www.codewars.com/kata/56d02e6cc6c8b49c510005bb/train/csharp