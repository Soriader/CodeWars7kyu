using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class SumTimesTablesTask
	{
		public static long SumTimesTable(List<int> tables, long min, long max)
		{
			long result = 0;

			foreach (var number in tables) 
			{
				for (long i = min; i <= max; i++)
				{
					result += number * i;
				}
			}

			return result;
		}
	}
}
//https://www.codewars.com/kata/551e51155ed5ab41450006e1/train/csharp