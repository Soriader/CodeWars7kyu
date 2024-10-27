using MoreLinq.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class CompleteThePatternThreeTask
	{
		public static string Pattern(int n)
		{
			if (n <= 0)
			{
				return "";
			}

			StringBuilder result = new StringBuilder();

			for (int i = 1; i <= n; i++)
			{
				string variation = "";

				for (int j = n; j >= n - i + 1; j--)
				{
					variation += j.ToString();
				}

				result.Append(variation + "\n");
			}

			return result.ToString().TrimEnd('\n');
		}
	}
}
//https://www.codewars.com/kata/557341907fbf439911000022/train/csharp