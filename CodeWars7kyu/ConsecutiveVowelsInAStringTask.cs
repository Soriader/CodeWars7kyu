using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class ConsecutiveVowelsInAStringTask
	{
		public static int GetTheVowels(string word)
		{
			List<char> vovels = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
			int result = 0;
			int iterator = 0;

			for (int i = 0; i < word.Length; i++)
			{
				if (word[i] == vovels[iterator])
				{
					result++;
					iterator++;

					if(iterator == 5)
					{
						iterator = 0;
					}
				}
			}

			return result;
		}
	}
}
//https://www.codewars.com/kata/62a933d6d6deb7001093de16/train/csharp