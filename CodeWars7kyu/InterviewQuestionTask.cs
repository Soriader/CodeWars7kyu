using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class InterviewQuestionTask
	{
		public static string GetStrings(string city)
		{
			Dictionary<char, int> letterCount = new Dictionary<char, int>();

			foreach (char letter in city.ToLower())
			{
				if (char.IsLetter(letter))
				{
					if (letterCount.ContainsKey(letter))
					{
						letterCount[letter]++;
					}
					else
					{
						letterCount[letter] = 1;
					}
				}
			}

			string result = "";
			foreach (var value in letterCount)
			{
				result += $"{value.Key}:{GetStar(value.Value)},";
			}

			if (result.Length > 0)
			{
				result = result.TrimEnd(',');
			}

			return result;
		}

		public static string GetStar(int count)
		{
			return new string('*', count);
		}

	}

	
}
//https://www.codewars.com/kata/5b358a1e228d316283001892/train/csharp
