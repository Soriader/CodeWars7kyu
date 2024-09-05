using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class CompleteThePatternTask
	{
		public static string Pattern(int n)
		{

			if (n <= 0) return ""; 
			string result = "";

			for (int i = 1; i <= n; i++)
			{
				for (int j = i; j <= n; j++)
				{
					result += j.ToString(); 
				}

				if (i < n) result += "\n";
			}

			return result;

		}
	}
}
//https://www.codewars.com/kata/55736129f78b30311300010f/train/csharp
