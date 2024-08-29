using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class MoveAllExclamationMarksToTheEndOfTheSentenceTask
	{
		public static string Remove(string s)
		{
			var check = s.ToCharArray();
			int iterator = 0;
			int howManyExclamation = 0;

			foreach (char c in check) 
			{
				if (c == '!')
				{
					howManyExclamation++;
				}
			}

			var noExclamation = s.Replace("!", "");

			while(iterator < howManyExclamation)
			{
				iterator++;
				noExclamation += "!";
			}

			return noExclamation;
		}
	}
}
//https://www.codewars.com/kata/57fafd0ed80daac48800019f/train/csharp