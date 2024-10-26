using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class BorrowerSpeakTask
	{
		public static string Borrow(string s)
		{
			string result = "";

			var check = s.ToCharArray();

			foreach (char c in check) 
			{
				if (char.IsLetter(c))
				{
					result += c.ToString().ToLower();
				}
			}

			return result;
		}
	}
}
//https://www.codewars.com/kata/57d2ba8095497e484e00002e/train/csharp