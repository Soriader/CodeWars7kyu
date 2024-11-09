using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodeWars7kyu
{
	public class IsItNegativeZeroTask
	{
		public static bool IsNegativeZero(double n)
		{
			return n == 0.0 && double.IsNegativeInfinity(1.0 / n);
		}
	}
}
//https://www.codewars.com/kata/5c5086287bc6600001c7589a/train/csharp