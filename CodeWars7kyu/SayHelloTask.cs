using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class SayHelloTask
	{
		public static string Greet(string name)
		{
			if (string.IsNullOrEmpty(name))
			{
				return null;
			}
			else
			{
				return $"hello {name}!";
			}
		}
	}
}
//https://www.codewars.com/kata/55955a48a4e9c1a77500005a/train/csharp