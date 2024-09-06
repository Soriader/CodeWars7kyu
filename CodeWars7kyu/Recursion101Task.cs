using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class Recursion101Task
	{
		public static (int, int) Solve(int a, int b)
		{
			while (a != 0 && b != 0)
			{
				if (a >= 2 * b)
				{
					a -= 2 * b;
				}
				else if (b >= 2 * a)
				{
					b -= 2 * a;
				}
				else
				{
					break;
				}
			}

			return (a, b);
		}
	}
}
//https://www.codewars.com/kata/5b752a42b11814b09c00005d/train/csharp