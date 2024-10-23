using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class CompoundArrayTask
	{
		public static int[] CompoundArray(int[] a, int[] b)
		{
			List<int> result = new List<int>();
			int iteratorA = 0;
			int iteratorB = 0;
			bool sequence = true;

			while (iteratorA < a.Length && iteratorB < b.Length)
			{
				if (sequence)
				{
					result.Add(a[iteratorA]);
					iteratorA++;
					sequence = false;
				}
				else
				{
					result.Add(b[iteratorB]);
					iteratorB++;
					sequence = true;
				}
			}

			while (iteratorA < a.Length)
			{
				result.Add(a[iteratorA]);
				iteratorA++;
			}

			while (iteratorB < b.Length)
			{
				result.Add(b[iteratorB]);
				iteratorB++;
			}

			return result.ToArray();
		}
	}
}
//https://www.codewars.com/kata/56044de2aa75e28875000017/train/csharp