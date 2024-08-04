using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class NthRootOfANumberTask
	{
		public static double FindRoot(double x, int n)
		{
			return Math.Pow(x, 1.0 / n);
		}
	}
}
//https://www.codewars.com/kata/5520714decb43308ea000083/train/csharp