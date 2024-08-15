using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class FindAllOccurrencesTask
	{
		public static int[] FindAll(int[] array, int n)
		{
			List<int> result = new List<int>();
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == n)
				{
					result.Add(i);
				}
			}
			
			return result.ToArray();
		}
	}
}
//https://www.codewars.com/kata/59a9919107157a45220000e1/train/csharp