using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class ComputerProblemSeriesHardDiskDriveTask
	{
		public static int Save(int[] sizes, int hd)
		{
			int filesAdded = 0;
			int result = 0;


			if (sizes.Sum() <= hd)
			{
				return sizes.Length;
			}


			for (int i = 0; i < sizes.Length -1; i++)
			{
				if(sizes.First() > hd)
				{
					return 0;
				}

				filesAdded += sizes[i];
				result++;

				if (filesAdded == hd || filesAdded + sizes[i + 1] > hd)
				{
					break;
				}

			}

			return result;
		}
	}
}
//https://www.codewars.com/kata/5d49c93d089c6e000ff8428c/train/csharp