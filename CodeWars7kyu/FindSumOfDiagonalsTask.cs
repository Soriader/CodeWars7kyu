using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class FindSumOfDiagonalsTask
	{
		public static int DiagonalSum(int[,] matrix)
		{
			int sum = 0;
			int size = matrix.GetLength(0);  

			for (int i = 0; i < size; i++)
			{
				sum += matrix[i, i]; 
			}

			return sum;
		}
	}
}
//https://www.codewars.com/kata/5497a3c181dd7291ce000700/train/csharp