using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodeWars7kyu
{
	public class IsEvenBitwiseSeriesTask
	{
		public static bool IsEven(int n)
		{
			bool isOdd = (n & 1) != 0;

			return !isOdd;
		}
	}
}
//https://www.codewars.com/kata/592a33e549fe9840a8000ba1/train/csharp