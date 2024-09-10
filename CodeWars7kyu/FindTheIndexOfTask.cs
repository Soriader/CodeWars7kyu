using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class FindTheIndexOfTask
	{
		public static int SecondSymbol(string str, char symbol)
		{
			var check = str.ToCharArray();
			int iteratror = 0;
			bool findOne = false;
			bool notFind = true;
			int howManySymbol = 0;

			foreach (char c in check) 
			{
				if (c == symbol)
				{
					findOne = true;
					howManySymbol++;
				}

				if (c == symbol && findOne == true && howManySymbol == 2) 
				{
					notFind = false;
					break;
				}

				iteratror++;
			}

			if (notFind)
			{
				return -1;
			}

			return iteratror;
		}
	}
}
//https://www.codewars.com/kata/63f96036b15a210058300ca9/train/csharp