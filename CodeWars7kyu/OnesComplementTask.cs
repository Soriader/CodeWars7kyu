using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class OnesComplementTask
	{
		public static string OnesComplement(string n)
		{
			return new string(n.Select(x => x == '0' ? '1' : (x == '1' ? '0' : x)).ToArray());

		}
	}
}
//https://www.codewars.com/kata/59b11f57f322e5da45000254/train/csharp