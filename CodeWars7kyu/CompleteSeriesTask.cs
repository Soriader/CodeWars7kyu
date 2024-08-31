using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class CompleteSeriesTask
	{
		public static int[] CompleteSeries(int[] arr)
		{
			Dictionary<int,int> checkTheRepeat = new Dictionary<int,int>();

			foreach (int item in arr) 
			{
				if (checkTheRepeat.ContainsKey(item))
				{
					checkTheRepeat[item]++;
				}
				else
				{
					checkTheRepeat.Add(item, 1);
				}
			}

			foreach (var pair in checkTheRepeat)
			{
				if (pair.Value >= 2)
				{
					return new int[] { 0 };
				}
			}

			int maxValue = arr.Max();
			int iterator = 0;
			List<int> result = new List<int>();

			while (maxValue >= iterator) 
			{
				result.Add(iterator);
				iterator++;
			}

			return result.ToArray();	
		}
	}
}
//https://www.codewars.com/kata/580a4001d6df740d61000301/train/csharp