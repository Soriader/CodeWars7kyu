using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class FromAToZTask
	{
		public static string GimmeTheLetters(string sp)
		{
			bool isUpper = false;

			if (char.IsUpper(sp.ToCharArray()[0]))
			{
				isUpper = true;
			}

			var alphabet = "abcdefghijklmnopqrstuvwxyz";
			var checkTheAlphabet = alphabet.ToCharArray();
			var range = sp.ToLower().ToCharArray();
			var start = range[0];
			var end = range[2];
			string result = "";
			int indexToStart = 0;
			int indexToEnd = 0;

			for (var i = 0; i < checkTheAlphabet.Length; i++) 
			{
				if (checkTheAlphabet[i] == start)
				{
					indexToStart = i;
				}

				if (checkTheAlphabet[i] == end)
				{
					indexToEnd = i;
				}
			}

			for (int i = indexToStart; i <= checkTheAlphabet.Length; i++)
			{
				result += checkTheAlphabet[i];

				if(i == indexToEnd)
				{
					break;
				}
			}

			if (isUpper)
			{
				return result.ToUpper();
			}

			return result;
		}
	}
}
//https://www.codewars.com/kata/6512b3775bf8500baea77663/train/csharp