using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class MultiplyWordInStringTask
	{
		public static string ModifyMultiply(string str, int loc, int num)
		{
			var check = str.Split(" ");

			var wordWhatWeNeed = check[loc];

			int iterator = 0;

			string result = "";

			while (iterator < num) 
			{
				result += wordWhatWeNeed + "-";
				iterator++;
			}

			return result.Trim('-');

		}
	}
}
//https://www.codewars.com/kata/5ace2d9f307eb29430000092/train/csharp