using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class OddMarchBits8BitsTask
	{
		public int[][] BitMarch(int n)
		{
			int size = 8 - n + 1;
			int[][] result = new int[size][];

			for (int i = 0; i < size; i++)
			{
				result[i] = new int[8];
				for (int j = 0; j < n; j++)
				{
					result[i][8 - n - i + j] = 1;
				}
			}
			return result;
		}

	
	}
}
//https://www.codewars.com/kata/58ee4db3e479611e6f000086/train/csharp