using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class VampireNumbersTask
	{
		public static bool Vampire(long x, long y)
		{
			if (x <= 0 && y <= 0)
			{
				return false;
			}

			var vampireNumber = x * y;

			if(vampireNumber.ToString().Length == x.ToString().Length + y.ToString().Length)
			{
				var fangsDigits = (x.ToString() + y.ToString()).OrderBy(c => c).ToArray();
				var vampireDigits = vampireNumber.ToString().OrderBy(c => c).ToArray();

				return fangsDigits.SequenceEqual(vampireDigits);
			}

			return false;
		}
	}
}
//https://www.codewars.com/kata/54d418bd099d650fa000032d/train/csharp