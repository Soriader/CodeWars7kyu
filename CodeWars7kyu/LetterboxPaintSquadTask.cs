using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodeWars7kyu
{
	public class LetterboxPaintSquadTask
	{
		public static IEnumerable<int> PaintLetterBoxes(int start, int end)
		{
			int[] digitCounts = new int[10];

			for (int number = start; number <= end; number++)
			{
				foreach (char digit in number.ToString())
				{
					digitCounts[digit - '0']++;
				}
			}

			return digitCounts;
		}
	}
}
//https://www.codewars.com/kata/597d75744f4190857a00008d/train/csharp