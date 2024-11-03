using MoreLinq.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class MobileDisplayKeystrokesTask
	{
		public static int MobileKeyboard(string str)
		{
			int result = 0;

			Dictionary<char, int> phoneKeyboard = new Dictionary<char, int>
	{
		{ '1', 1 },
		{ '2', 1 }, { 'a', 2 }, { 'b', 3 }, { 'c', 4 },
		{ '3', 1 }, { 'd', 2 }, { 'e', 3 }, { 'f', 4 },
		{ '4', 1 }, { 'g', 2 }, { 'h', 3 }, { 'i', 4 },
		{ '5', 1 }, { 'j', 2 }, { 'k', 3 }, { 'l', 4 },
		{ '6', 1 }, { 'm', 2 }, { 'n', 3 }, { 'o', 4 },
		{ '7', 1 }, { 'p', 2 }, { 'q', 3 }, { 'r', 4 }, { 's', 5 },
		{ '8', 1 }, { 't', 2 }, { 'u', 3 }, { 'v', 4 },
		{ '9', 1 }, { 'w', 2 }, { 'x', 3 }, { 'y', 4 }, { 'z', 5 },
		{ '0', 1 },
		{ '*', 1 },
		{ '#', 1 }
	};

			foreach (char c in str)
			{
				if (phoneKeyboard.ContainsKey(c))
				{
					result += phoneKeyboard[c];
				}
			}

			return result;
		}

	}
}
//https://www.codewars.com/kata/59564a286e595346de000079/train/csharp