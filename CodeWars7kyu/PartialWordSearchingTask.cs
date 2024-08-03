using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class PartialWordSearchingTask
	{
		public static string[] WordSearch(string query, string[] seq)
		{
			query = query.ToLower();
			List<string> result = new List<string>();

			foreach (var word in seq)
			{
				if (word.ToLower().Contains(query))
				{
					result.Add(word);
				}
			}

			if (result.Count == 0)
			{
				return new string[] { "Empty" };
			}

			return result.ToArray();
		}
	}
}
//https://www.codewars.com/kata/54b81566cd7f51408300022d/train/csharp