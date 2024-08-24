using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class RemoveAllExclamationMarksFromTheEndTask
	{
		public static string Remove(string s)
		{
			var check = s.Split(" ");
			string result = "";

			foreach (var item in check)
			{
				result += item.TrimEnd('!') + " ";
			}

			return result.Trim();
		}
	}
}
//https://www.codewars.com/kata/57faf32df815ebd49e000117/train/csharp
