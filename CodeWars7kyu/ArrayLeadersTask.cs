using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodeWars7kyu
{
	public class ArrayLeadersTask
	{
		public static int[] ArrayLeaders(int[] numbers)
		{
			List<int> result = new List<int>();
			int sumRight = 0;

			for (int j = numbers.Length - 1; j >= 0; j--)
			{
				if (numbers[j] > sumRight)
				{
					result.Add(numbers[j]);
				}
				sumRight += numbers[j];
			}

			result.Reverse();
			return result.ToArray();
		}
	}
}
//https://www.codewars.com/kata/5a651865fd56cb55760000e0/train/csharp