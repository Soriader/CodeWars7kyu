using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class RemoveWordsFromTheSentenceIfItContainsOneExclamationMarkTask
	{
		public static string Remove(string s)
		{
			var check = s.Split(" ");
			int iterator = 0;
			string result = "";

			foreach (var word in check) 
			{
				var howManyExclamation = word.ToCharArray();


				foreach (var exclamation in howManyExclamation)
				{
					if(exclamation == '!')
					{
						iterator++;
					}
				}

				if (iterator >= 2 || iterator == 0)
				{
					result += word + " ";
				}

				iterator = 0;
			}

			return result.TrimEnd();
		}
	}
}
//https://www.codewars.com/kata/57fafb6d2b5314c839000195/train/csharp