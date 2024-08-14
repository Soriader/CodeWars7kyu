using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class CalculateTwoPeopleIndividualAgesTask
	{
		public static double[] GetAges(int sum, int difference)
		{
			if(sum < 0 || difference < 0)
			{
				return null;
			}

			double oldest = (double)(sum /2.0 + difference/2.0);
			double youngest = (double)(sum/2.0 - difference/2.0);

			if (oldest >= 0 && youngest >= 0)
			{
				return new double[] { oldest, youngest };
			}

			return null;
		}
	}
}
//https://www.codewars.com/kata/58e0bd6a79716b7fcf0013b1/train/csharp
