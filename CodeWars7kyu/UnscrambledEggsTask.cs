using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class UnscrambledEggsTask
	{
		public static string UnscrambleEggs(string word)
		{
			string result = Regex.Replace(word, "egg", "");

			return result;
		}
	}
}
//https://www.codewars.com/kata/55ea5650fe9247a2ea0000a7/train/csharp