using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class BasicSequencePracticeTask
	{
		public static int[] SumOfN(int n)
		{
			List<int> result = new List<int>();

			int sum = 0;
			int sign = n < 0 ? -1 : 1;
			n = Math.Abs(n);

			for (int i = 0; i <= n; i++)
			{
				sum += i;
				result.Add(sum * sign);
			}

			return result.ToArray();
		}
	}
}
//https://www.codewars.com/kata/5436f26c4e3d6c40e5000282/train/csharp