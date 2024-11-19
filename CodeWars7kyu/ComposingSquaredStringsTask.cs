using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class ComposingSquaredStringsTask
	{
		public static string Compose(string s1, string s2)
		{
			string result = "";
			var s1Parts = s1.Split('\n');
			var s2Parts = s2.Split('\n');
			int n = s1Parts.Length;

			for (int i = 0; i < n; i++)
			{
				result += s1Parts[i].Substring(0, i + 1) + s2Parts[n - i - 1].Substring(0, n - i);

				if (i < n - 1)
				{
					result += '\n';
				}
			}

			return result;
		}
	}
}
//https://www.codewars.com/kata/56f253dd75e340ff670002ac/train/csharp