using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class CountTheDigitTask
	{
		public static int NbDig(int n, int d)
		{
			int result = 0;
			char digit = d.ToString()[0];

			for (int i = 0; i <= n; i++)
			{
				int square = i * i; 

				string squareStr = square.ToString();

				foreach (char c in squareStr)
				{
					if (c == digit)
					{
						result++;
					}
				}
			}

			return result;
		}
	}
}
//https://www.codewars.com/kata/566fc12495810954b1000030/train/csharp