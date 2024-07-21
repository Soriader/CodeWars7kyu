using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class CleanUpTask
	{
		public static string Crap(char[,] x, int bags, int cap)
		{
			int trash = 0;
			bool dogIsHere = false;

			for (int i = 0; i < x.GetLength(0); i++) 
			{
				for (int j = 0; j < x.GetLength(1); j++) 
				{
					if (x[i, j] == '@')
					{
						trash++;
					}

					if (x[i, j] == 'D')
					{
						dogIsHere = true;
					}
				}
			}

				if (dogIsHere) 
			{
				return "Dog!!";
			}

			if(trash <= bags * cap)
			{
				return "Clean";
			}

			return "Cr@p";
		}
	}
}
//https://www.codewars.com/kata/57faa6ff9610ce181b000028/train/csharp