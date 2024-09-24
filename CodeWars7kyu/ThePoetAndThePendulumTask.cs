using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class ThePoetAndThePendulumTask
	{
		public static int[] Pendulum(int[] values)
		{
			var sortedValues = values.OrderBy(x => x).ToArray();

			int n = sortedValues.Length;
			int[] result = new int[n];

			int centerIndex = (n - 1) / 2;

			result[centerIndex] = sortedValues[0];

			int leftIndex = centerIndex - 1;
			int rightIndex = centerIndex + 1;

			for (int i = 1; i < n; i++)
			{
				if (i % 2 == 1)
				{
					result[rightIndex] = sortedValues[i];
					rightIndex++;
				}
				else
				{
					result[leftIndex] = sortedValues[i];
					leftIndex--;
				}
			}

			return result;
		}
	}
}
//https://www.codewars.com/kata/5bd776533a7e2720c40000e5/train/csharp