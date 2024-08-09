using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class NiceArrayTask
	{
		public static bool IsNice(int[] arr)
		{
			if (arr.Length == 0)
			{
				return false;
			}

			foreach (var num in arr)
			{
				bool hasNeighbor = false;

				foreach (var otherNum in arr)
				{
					if (num + 1 == otherNum || num - 1 == otherNum)
					{
						hasNeighbor = true;
						break;
					}
				}

				if (!hasNeighbor)
				{
					return false;
				}
			}

			return true;
		}
	}
}
//https://www.codewars.com/kata/59b844528bcb7735560000a0/train/csharp
