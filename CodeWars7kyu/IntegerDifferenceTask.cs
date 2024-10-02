using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class IntegerDifferenceTask
	{
		public static int IntDiff(int[] arr, int n)
		{
			int result = 0;

			for (int i = 0; i < arr.Length; i++)
			{
				for (int j = i + 1; j < arr.Length; j++)
				{
					if (Math.Abs(arr[i] - arr[j]) == n)
					{
						result++;
					}
				}
			}

			return result;
		}
	}
}
//https://www.codewars.com/kata/57741d8f10a0a66915000001/train/csharp