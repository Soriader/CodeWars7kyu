using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class IsItALetterTask
	{
		public static bool IsItLetter(char c)
		{
			if (char.IsLetter(c))
			{
				return true;
			}
			return false;
		}
	}
}
//https://www.codewars.com/kata/57a06b07cf1fa58b2b000252/train/csharp