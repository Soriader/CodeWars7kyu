using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class PlusMinusCountTask
	{
		public static int CatchSignChange(int[] arr)
		{
			var result = 0;
			for (var i = 0; i < arr.Length - 1; i++)
			{
				if ((arr[i] >= 0 && arr[i + 1] < 0) || (arr[i] < 0 && arr[i + 1] >= 0))
				{
					result++;
				}
			}
			return result;
		}
	}
}
//https://www.codewars.com/kata/5bbb8887484fcd36fb0020ca/train/csharp