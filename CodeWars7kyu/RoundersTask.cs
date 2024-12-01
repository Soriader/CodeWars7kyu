using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class RoundersTask
	{
		public int Rounders(int value)
		{
			int factor = 1; 

			while (value >= 10)
			{
				int lastDigit = value % 10; 
				value /= 10;

				if (lastDigit >= 5)
				{
					value++; 
				}

				factor *= 10;
			}

			return value * factor;

		}
	}
}
//https://www.codewars.com/kata/58846d50f54f021d90000012/train/csharp