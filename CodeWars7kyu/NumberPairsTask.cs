using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class NumberPairsTask
	{
		public static int[] GetLargerNumbers(int[] a, int[] b)
		{
			List<int> result = new List<int>();

			for (int i = 0; i < a.Length; i++)
			{
				if (a[i] > b[i])
				{
					result.Add(a[i]);
				}
				else
				{
					result.Add(b[i]);
				}
			}

			return result.ToArray();
		}
	}
}
//https://www.codewars.com/kata/563b1f55a5f2079dc100008a/train/csharp