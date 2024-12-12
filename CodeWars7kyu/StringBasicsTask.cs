using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class StringBasicsTask
	{
		public static string[] GetUserIds(string s)
		{
			return s.ToLower().Replace("#", "").Split(',').Select(x => x.Trim()[3..]).ToArray();
		}
	}
}
//https://www.codewars.com/kata/56326c13e63f90538d00004e/train/csharp