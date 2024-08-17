using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class MaxMinArraysTask
	{
		public static List<int> Solve(List<int> arr)
		{
			List<int> workList = new List<int>(arr);
			List<int> result = new List<int>();

			while (workList.Count > 0)
			{
				int max = workList.Max();
				result.Add(max);
				workList.Remove(max);

				if (workList.Count > 0)
				{
					int min = workList.Min();
					result.Add(min);
					workList.Remove(min);
				}
			}

			return result;
		}
	}
}
//https://www.codewars.com/kata/5a090c4e697598d0b9000004/train/csharp