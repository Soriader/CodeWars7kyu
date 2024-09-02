using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class MovesInSquaredStringsTask
	{
		public static string VertMirror(string strng)
		{
			return string.Join("\n", strng.Split('\n').Select(line => new string(line.Reverse().ToArray())));
		}

		public static string HorMirror(string strng)
		{
			return string.Join("\n", strng.Split('\n').Reverse());
		}

		public static string Oper(Func<string, string> fct, string s)
		{
			return fct(s);
		}
	}
}
//https://www.codewars.com/kata/56dbe0e313c2f63be4000b25/train/csharp