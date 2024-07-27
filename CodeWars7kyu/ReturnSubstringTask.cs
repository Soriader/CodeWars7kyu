using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class ReturnSubstringTask
	{
		public static int SubstringCount(string fullText, string searchText)
		{
			if (string.IsNullOrEmpty(fullText) || string.IsNullOrEmpty(searchText))
			{
				return 0;
			}

			int count = 0;
			int startIndex = 0;

			while ((startIndex = fullText.IndexOf(searchText, startIndex)) != -1)
			{
				count++;
				startIndex += searchText.Length;
			}

			return count;
		}
	}
}
//https://www.codewars.com/kata/5168b125faced29f66000005/train/csharp
