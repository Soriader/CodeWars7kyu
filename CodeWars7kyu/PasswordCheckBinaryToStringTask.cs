using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class PasswordCheckBinaryToStringTask
	{
		public static string DecodePass(string[] passArr, string bin)
		{
			var partOfPassword = bin.Split(' ');
			string result = "";

			foreach (var part in partOfPassword)
			{
				string paddedPart = part.PadLeft(8, '0');

				int asciiValue = Convert.ToInt32(paddedPart, 2);
				result += (char)asciiValue;
			}

			return passArr.Contains(result) ? result : null;
		}
	}
}
//https://www.codewars.com/kata/5a731b36e19d14400f000c19/train/csharp