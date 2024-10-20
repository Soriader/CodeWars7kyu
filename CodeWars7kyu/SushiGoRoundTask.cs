using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CodeWars7kyu
{
	public class SushiGoRoundTask
	{
		public static int TotalBill(string str)
		{
			var howManyR = str.Count(c => c == 'r');
			int itIsFree = howManyR / 5;

			return (howManyR - itIsFree) * 2;

		}
	}
}
