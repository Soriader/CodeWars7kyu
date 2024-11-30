using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class HexadecimalNumberTask
	{
		public static bool HexNumber(string s)
		{
			if (string.IsNullOrEmpty(s)) return false;

			if (s.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
			{
				s = s.Substring(2);
			}

			if (string.IsNullOrEmpty(s)) 
			{
				return false; 
			}

			foreach (char c in s)
			{
				if (!("0123456789abcdefABCDEF".Contains(c)))
				{
					return false;
				}
			}

			return true;
		}
	}
}
//https://www.codewars.com/kata/567c9f56d83baeed8300000f/train/csharp