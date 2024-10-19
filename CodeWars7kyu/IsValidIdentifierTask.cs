using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class IsValidIdentifierTask
	{
		public static bool IsValid(string idn)
		{
			var check = idn.ToCharArray();

			if (string.IsNullOrEmpty(idn))
			{
				return false;
			}

			if (!char.IsLetter(check[0]) && check[0] != '$' && check[0] != '_')
			{
				return false;
			}
			else if(char.IsLetter(check[0]) && check[0] == '$' && check[0] == '_' && check.Length == 1)
			{
				return true;
			}

			for (int i = 1; i < check.Length; i++)
			{
				if (!char.IsDigit(check[i]) && !char.IsLetter(check[i]) && check[i] != '$' && check[i] != '_')
				{
					return false;
				}
			}

			return true;
		}
	}
}
//https://www.codewars.com/kata/563a8656d52a79f06c00001f/train/csharp