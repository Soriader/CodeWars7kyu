using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public static class OddLadderTask
	{
		public static string OddLadder(int n)
		{
			if (n <= 0)
			{
				return "";
			}

			StringBuilder result = new StringBuilder();

			for (int i = 1; i <= n; i += 2)  
			{
				string repeated = new string(i.ToString()[0], i);
				result.Append(repeated + "\n");  
			}

			return result.ToString().TrimEnd('\n');
		}
	}

}
//https://www.codewars.com/kata/5574940eae1cf7d520000076/train/csharp