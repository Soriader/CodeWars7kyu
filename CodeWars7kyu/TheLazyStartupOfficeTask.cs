using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class TheLazyStartupOfficeTask
	{
		public static string[] BinRota(string[][] input)
		{
			var result = new List<string>();

			for (int i = 0; i < input.Length; i++)
			{
				if (i % 2 == 0)
				{
					result.AddRange(input[i]);
				}
				else
				{
					for (int j = input[i].Length - 1; j >= 0; j--)
					{
						result.Add(input[i][j]);
					}
				}
			}

			return result.ToArray();
		}
	}
}
//https://www.codewars.com/kata/578fdcfc75ffd1112c0001a1/train/csharp