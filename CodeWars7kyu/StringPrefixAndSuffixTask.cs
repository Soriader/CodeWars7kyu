using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class StringPrefixAndSuffixTask
	{
		public static int Solve(string s)
		{
			int n = s.Length;

			for (int i = n / 2; i > 0; i--)
			{
				if (s.Substring(0, i) == s.Substring(n - i, i))
				{
					return i;
				}
			}

			return 0;
		}
	}
}
//https://www.codewars.com/kata/5ce969ab07d4b7002dcaa7a1/train/csharp