using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class ClassFunctionFactoryTask
	{
		public static Func<int[], int[]> Factory(int x)
		{
			return array => FactoryMultiply(x, array);
		}

		public static int[] FactoryMultiply(int x, int[] array)
		{
			List<int> result = new List<int>();

			foreach (var item in array)
			{
				result.Add(item * x);
			}

			return result.ToArray();
		}
	}
}
//https://www.codewars.com/kata/563f879ecbb8fcab31000041/train/csharp