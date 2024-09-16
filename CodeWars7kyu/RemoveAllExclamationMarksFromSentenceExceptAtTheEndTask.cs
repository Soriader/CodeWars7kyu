using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class RemoveAllExclamationMarksFromSentenceExceptAtTheEndTask
	{
		public static string Remove(string s)
		{
			string withoutExclamations = s.Replace("!", "");

			int exclamationCount = 0;

			for (int i = s.Length - 1; i >= 0; i--)
			{
				if (s[i] == '!')
				{
					exclamationCount++;
				}
				else
				{
					break;
				}
			}

			return withoutExclamations + new string('!', exclamationCount);
		}
	}
}
//https://www.codewars.com/kata/57faefc42b531482d5000123/train/csharp