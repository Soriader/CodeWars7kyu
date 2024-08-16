using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class FixMyPhoneNumbersTask
	{
		public static String IsItANum(string str)
		{
			string number = "";

			foreach (char c in str)
			{
				if (char.IsDigit(c))
				{
					number += c; 
				}
			}

			if (number.StartsWith("0") && number.Length == 11)
			{
				return number;
			}

			return "Not a phone number";
		}
	}
}
//https://www.codewars.com/kata/596343a24489a8b2a00000a2/train/csharp