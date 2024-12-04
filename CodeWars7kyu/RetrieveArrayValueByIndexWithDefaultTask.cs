using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class RetrieveArrayValueByIndexWithDefaultTask
	{
		public static int Solution(int[] items, int index, int defaultValue)
		{
			if (index <= items.Length && index >= 0)
			{
				return items[index];
			}
			else if(index < 0)
			{
				var newItems = items.Reverse().ToArray();
				var newIndex = Math.Abs(index);

				if(newIndex <= items.Length)
				{
					return newItems[newIndex - 1];

				}
			}


			return defaultValue;

		}
	}
}
//https://www.codewars.com/kata/515ceaebcc1dde8870000001/train/csharp