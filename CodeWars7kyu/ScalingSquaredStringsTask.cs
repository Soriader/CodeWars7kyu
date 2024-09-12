using CodeWars7kyu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class ScalingSquaredStringsTask
	{
		public static string Scale(string strng, int k, int n)
		{
			if (string.IsNullOrEmpty(strng)) 
			{
				return "";
			}

			var lines = strng.Split('\n');

			var scaledLines = lines
				.Select(line => string.Concat(line.Select(ch => new string(ch, k))))
				.SelectMany(scaledLine => Enumerable.Repeat(scaledLine, n));

			return string.Join("\n", scaledLines);			
		}
	}
}
//https://www.codewars.com/kata/56ed20a2c4e5d69155000301/train/csharp