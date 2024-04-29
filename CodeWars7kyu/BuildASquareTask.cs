using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class BuildASquareTask
	{
		public static string GenerateShape(int n)
		{
			if (n == 0) return "";
			int iterator = 0;
			string block = "";
			string result = "";

			while (n > 0)
			{
				iterator++;
				block += "+";

				if(iterator == n)
				{
					iterator = 1;
					result += block;
					break;
				}
			}

			while (n > iterator)
			{
				iterator++;
				result += "\n" + block;

				if (iterator == n)
				{
					break;
				}
			}

			return result;

		}
	}
}
//https://www.codewars.com/kata/59a96d71dbe3b06c0200009c/train/csharp