using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace CodeWars7kyu
{
	public class HelpBobCountTask
	{
		public static int CountLettersAndDigits(string input)
		{
			int result = 0;

			var check = input.ToCharArray();

			foreach (char c in check)
			{
				if(char.IsDigit(c) || char.IsLetter(c))
				{
					result++;
				}
			}

			return result;
		}
	}
}
//https://www.codewars.com/kata/5738f5ea9545204cec000155/train/csharp