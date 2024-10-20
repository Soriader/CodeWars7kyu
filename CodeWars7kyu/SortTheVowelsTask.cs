using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class SortTheVowelsTask
	{
		public static string SortVowels(string s)
		{
			if(s is null)
			{
				return "";
			}

			var vovels = "aeiou";
			var check = s.ToCharArray();
			var result = "";
			for (int i = 0; i < check.Length; i++)
			{

				if (vovels.Contains(check[i].ToString().ToLower()))
				{
					if (i == 0)
					{
						result += $"|{check[i]}";
						continue;

					}

					result += $"\n|{check[i]}";
				}
				else if (check[i] == '|')
				{
					result += "\n ";
				}
				else
				{
					if (i == 0)
					{
						result += $"{check[i]}|";
						continue;
					}

					result += $"\n{check[i]}|";

				}
			}


			return result;
		}
	}
}
//https://www.codewars.com/kata/59e49b2afc3c494d5d00002a/train/csharp