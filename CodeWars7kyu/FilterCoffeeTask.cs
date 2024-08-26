using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class FilterCoffeeTask
	{
		public static string Search(int budget, int[] prices)
		{
			List<int> numberOfBudgetLocals = prices.Where(cost => cost <= budget).ToList();

			numberOfBudgetLocals.Sort();

			string result = string.Join(",", numberOfBudgetLocals);

			return result;
		}
	}
}
//https://www.codewars.com/kata/56069d0c4af7f633910000d3/train/csharp