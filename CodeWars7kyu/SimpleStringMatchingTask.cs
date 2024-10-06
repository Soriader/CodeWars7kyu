using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class SimpleStringMatchingTask
	{
		public static bool Solve(string a, string b)
		{
			if (!a.Contains("*"))
			{
				return a == b;
			}

			int starIndex = a.IndexOf('*');

			string prefix = a.Substring(0, starIndex);
			string suffix = a.Substring(starIndex + 1);

			if (b.Length < prefix.Length + suffix.Length)
			{
				return false;
			}

			return b.StartsWith(prefix) && b.EndsWith(suffix);
		}
	}

}
//https://www.codewars.com/kata/5bc052f93f43de7054000188/train/csharp