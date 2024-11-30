using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class PutALetterInAColumnTask
	{
		public static string BuildRowText(int index, char character)
		{
			char[] row = new char[] { '|', ' ', '|', ' ', '|', ' ', '|', ' ', '|', ' ', '|', ' ', '|', ' ', '|', ' ', '|', ' ', '|' };

			int position = index * 2 + 1;

			row[position] = character;

			return new string(row);
		}
	}
}
//https://www.codewars.com/kata/563d54a7329a7af8f4000059/train/csharp