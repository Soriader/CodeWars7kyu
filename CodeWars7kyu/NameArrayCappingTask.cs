using Microsoft.VisualBasic;
using MoreLinq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class NameArrayCappingTask
	{
		public static string[] CapMe(string[] strings)
		{
			List<string> nameInLower = new List<string>();

			List<string> result = new List<string>();

			foreach (string s in strings)
			{
				nameInLower.Add(s.ToLower());
			}

			foreach (var name in nameInLower)
			{
				if (name.Length > 0)
				{
					string correctName = name.Substring(0, 1).ToUpper() + name.Substring(1).ToLower();
					result.Add(correctName);
				}
			}

			return result.ToArray();
		}
	}
}
//https://www.codewars.com/kata/5356ad2cbb858025d800111d/train/csharp