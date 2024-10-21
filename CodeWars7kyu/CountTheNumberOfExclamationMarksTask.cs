using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class CountTheNumberOfExclamationMarksTask
	{
		public static int Product(string str)
		{
			var questionMarks = str.Count(x => x == '?');
			var exclamationMarks = str.Count(x => x == '!');

			return questionMarks * exclamationMarks;
		}
	}
}
//https://www.codewars.com/kata/57fb142297e0860073000064/train/csharp