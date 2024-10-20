using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class HeroRootTask
	{
		public static long IntRac(long n, long guess)
		{
			long boxToPreviouslyX = guess;
			long boxToAcctualX = 0;
			long newN = n;
			bool work = true;
			List<long> result = new List<long>();

			boxToAcctualX = (boxToPreviouslyX + newN / boxToPreviouslyX) / 2;
			boxToPreviouslyX = boxToAcctualX;
			result.Add(boxToAcctualX);

			while (work)
			{
				boxToAcctualX = (boxToPreviouslyX + newN / boxToPreviouslyX) / 2;
				result.Add(boxToAcctualX);

				if(boxToAcctualX == boxToPreviouslyX)
				{
					work = false;
				}

				boxToPreviouslyX = boxToAcctualX;
			}

			return result.Count();

		}
	}
}
//https://www.codewars.com/kata/55efecb8680f47654c000095/train/csharp