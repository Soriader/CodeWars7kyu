using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class PairsOfIntegersFromTask
	{
		public static IEnumerable<(int, int)> GeneratePairs(int m, int n)
		{
			int iteratorToM = m;
			int iteratorToN = m;

			while (iteratorToM <= n) 
			{
				yield return (iteratorToM, iteratorToN);

				if(iteratorToN == n)
				{
					iteratorToM++;
					iteratorToN = iteratorToM;
				}
				else
				{
					iteratorToN++;
				}

			}

		}
	}
}
//https://www.codewars.com/kata/588e2a1ad1140d31cb00008c/train/csharp