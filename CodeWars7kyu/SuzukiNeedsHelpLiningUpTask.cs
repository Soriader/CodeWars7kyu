using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class SuzukiNeedsHelpLiningUpTask
	{
		public static String[] LineupStudents(String a)
		{
			var check = a.Split(' ');

			List<String> listOfStudents = new List<String>(check);

			listOfStudents.Sort((x, y) =>
			{
				int lengthComparison = y.Length.CompareTo(x.Length);

				if (lengthComparison == 0)
				{
					return y.CompareTo(x); 
				}

				return lengthComparison;
			});

			return listOfStudents.ToArray();
		}
	}
}
//https://www.codewars.com/kata/5701800886306a876a001031/train/csharp