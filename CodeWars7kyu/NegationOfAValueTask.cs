using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class NegationOfAValueTask
	{
		public static bool NegationValue(string str, bool value)
		{
			if(str.Length % 2 == 0)
			{
				return value;
			}
			else
			{
				return !value;
			}
		}
	}
}
//https://www.codewars.com/kata/58f6f87a55d759439b000073/train/csharp