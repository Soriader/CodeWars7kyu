using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class OperationsWithSequenceTask
	{
		public static int Calc(int[] array)
		{
			return array.Select((x, i) => x > 0 ? x * x : x)
				.Select((x, i) => (i + 1) % 3 == 0 ? x * 3 : x) 
				.Select((x, i) => (i + 1) % 5 == 0 ? x * -1 : x)
				.Sum();
		}
	}
}
//https://www.codewars.com/kata/596ddaccdd42c1cf0e00005c/train/csharp