using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class NextPalindromicNumberTask
    {
		public static int NextPal(int val)
		{
			var check = val;
			bool isPalindrom = true;

			while (isPalindrom)
			{
				check += 1;

				string checkStr = check.ToString();

				string reversedStr = new string(checkStr.Reverse().ToArray());

				if (checkStr == reversedStr)
				{
					isPalindrom = false;
				}
			}

			return check;

			
		}
	}
}
//https://www.codewars.com/kata/56a6ce697c05fb4667000029/train/csharp