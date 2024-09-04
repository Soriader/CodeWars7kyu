using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class MakeBackronymTask
	{
		public static string MakeBackronym(string s)
		{
			Dictionary<char, string> dict = new Dictionary<char, string>(); //dictionary was create for no generate mistakes in compiler
			return string.Join(" ", s.ToUpper().Select(c => dict[c]));
		}
	}
}
//https://www.codewars.com/kata/55805ab490c73741b7000064/train/csharp
//This cata don't have a test because the dictionary from this task is not given by author 