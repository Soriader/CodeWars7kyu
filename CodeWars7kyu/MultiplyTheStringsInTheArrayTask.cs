using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class MultiplyTheStringsInTheArrayTask
	{
		public static string ArrMultiply(string[] arr)
		{
			int first = int.Parse(arr[0]);
			int second = int.Parse(arr[1]);

			return $"{first * second}";
		}
	}
}
//https://www.codewars.com/kata/59b2963132779166d2001018/train/csharp