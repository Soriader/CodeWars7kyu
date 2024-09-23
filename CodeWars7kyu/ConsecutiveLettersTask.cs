using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class ConsecutiveLettersTask
	{
		public static bool Solve(string s)
		{
			var hasDuplicateLetters = s.GroupBy(c => c).Any(group => group.Count() > 1);
			if (hasDuplicateLetters) 
			{ 
				return false;
			}

			var check = s.OrderBy(c => c).ToList();

			for (int i = 0; i < check.Count - 1; i++)
			{
				if (check[i + 1] != (char)(check[i] + 1))
				{
					return false; 
				}
			}

			return true;
		}
	}
}
//https://www.codewars.com/kata/5ce6728c939bf80029988b57/train/csharp