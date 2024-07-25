using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class ProductOfMaximumsOfArrayTask
	{
		public static int MaxProduct(int[] arr, int size)
		{
			List<int> list = new List<int>(arr);
			int iterator = 1;
			int result = list.Max();

			list.Remove(result);

			while (iterator < size)
			{
				result *= list.Max();
				list.Remove(list.Max());
				iterator++;
			}

			return result;

		}
	}
}
//https://www.codewars.com/kata/5a63948acadebff56f000018/train/csharp