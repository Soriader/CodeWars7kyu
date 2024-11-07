using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class NumberClimberTask
	{
		public static int[] Climb(int n)
		{ 
			if(n == 1)
			{
				return new int[] {1};
			}

			List<int> result = new List<int>() { n };
			bool isOne = true ;
			var actualNumberInSequence = n;

			while(isOne)
			{
				if(actualNumberInSequence % 2 != 0)
				{
					actualNumberInSequence = (actualNumberInSequence - 1) / 2;
					result.Add(actualNumberInSequence);
				}
				else if(actualNumberInSequence % 2 == 0)
				{
					actualNumberInSequence = actualNumberInSequence / 2;
					result.Add(actualNumberInSequence);
				}

				if(actualNumberInSequence == 1)
				{
					isOne = false;
				}
			}

			return result.OrderBy(x => x).ToArray();
		}
	}
}
//https://www.codewars.com/kata/559760bae64c31556c00006b/train/csharp