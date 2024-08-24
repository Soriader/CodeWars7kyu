using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class ReverseListTask
	{
		public static int[] ReverseList(int[] list)
		{
			List<int> result = new List<int>();

			for (int i = list.Length - 1; i >= 0; i--)
			{
				result.Add(list[i]);
			}

			return result.ToArray();
		}
	}
}
//https://www.codewars.com/kata/57a04da9e298a7ee43000111/train/csharp