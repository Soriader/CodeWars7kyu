using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class ProductArrayTask
	{
		public static int[] ProductArray(int[] array)
		{
			int length = array.Length;
			int[] result = new int[length];

			for (int i = 0; i < length; i++)
			{
				int product = 1;

				for (int j = 0; j < length; j++)
				{
					if (i != j)
					{
						product *= array[j];
					}
				}

				result[i] = product;
			}

			return result;

		}
	}
}
//https://www.codewars.com/kata/5a905c2157c562994900009d/train/csharp