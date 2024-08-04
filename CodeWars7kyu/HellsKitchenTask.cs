using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class HellsKitchenTask
	{
		public static string Gordon(string a)
		{
			var check = a.ToUpper().ToCharArray();
			var vowels = new char[] { 'O', 'I', 'E', 'U', };
			string result = "";

			for (int i = 0; i < check.Length; i++)
			{
				if (char.IsWhiteSpace(check[i]))
				{
					result += "!!!!";
				}

				if (Array.Exists(vowels, element => element == check[i]))
				{
					result += '*';
				}
				else if (check[i] == 'A')
				{
					result += '@';
				}
				else
				{
					result += check[i];

				}


			}

			return result + "!!!!";
		}

		
	}
}
//https://www.codewars.com/kata/57d1f36705c186d018000813/train/csharp
