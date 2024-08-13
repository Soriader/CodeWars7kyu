using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class FindTheLuckyNumbersTask
	{
		public static int[] FilterLucky(int[] x)
		{
			List<int> result = new List<int>();


			foreach (var item in x)
			{
				if (item.ToString().ToCharArray().Contains('7'))
				{
					result.Add(item);
				}
			}

			return result.ToArray();
		}
	}
}
//https://www.codewars.com/kata/580435ab150cca22650001fb/train/csharp