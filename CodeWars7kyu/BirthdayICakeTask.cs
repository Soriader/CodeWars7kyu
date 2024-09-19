using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class BirthdayICakeTask
	{
		public static string Cake(int x, string y)
		{
			if(x <= 0 || y == null)
			{
				return "That was close!";
			}

			var check = y.ToCharArray();
			int sum = 0;

			Dictionary<char, int> letterToNumber = new Dictionary<char, int>();

			for (char letter = 'a'; letter <= 'z'; letter++)
			{
				letterToNumber[letter] = letter - 'a' + 1;
			}

			for (int i = 0; i < check.Length; i++)
			{
				if (i % 2 == 0)  
				{
					sum += (int)check[i];
				}
				else if (letterToNumber.ContainsKey(check[i])) 
				{
					sum += letterToNumber[check[i]];
				}
			}

			int seventyPercent = x*70/100;

			if(sum >= seventyPercent)
			{
				return "Fire!";

			}

			return "That was close!";
		}
	}
}
//https://www.codewars.com/kata/5805ed25c2799821cb000005/train/csharp