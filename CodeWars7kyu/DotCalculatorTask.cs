using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class DotCalculatorTask
	{

		public static string Calculator(string txt)
		{
			string[] parts = txt.Split(' ');
			string left = parts[0];
			string mark = parts[1];
			string right = parts[2];

			int resultLength = 0;

			switch (mark)
			{
				case "+":
					resultLength = left.Length + right.Length;
					break;
				case "-":
					resultLength = left.Length - right.Length;
					break;
				case "*":
					resultLength = left.Length * right.Length;
					break;
				case "//":
					resultLength = left.Length / right.Length;
					break;
			}

			return new string('.', resultLength);
		}

	}
}
//https://www.codewars.com/kata/6071ef9cbe6ec400228d9531/train/csharp