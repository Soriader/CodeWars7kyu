using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class RotateMatrixTask
	{
		public int[,] RotateMatrixLeft(int[,] matrix)
		{
			int rows = matrix.GetLength(0); 
			int cols = matrix.GetLength(1); 

			int[,] rotatedMatrix = new int[cols, rows];

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					rotatedMatrix[cols - j - 1, i] = matrix[i, j];
				}
			}

			return rotatedMatrix;
		}

	}
}
//https://www.codewars.com/kata/56b5dd1702a30326ce000b02/train/csharp