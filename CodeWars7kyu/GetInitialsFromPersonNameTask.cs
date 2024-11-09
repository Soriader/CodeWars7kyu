using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class GetInitialsFromPersonNameTask
	{
		public static string ToInitials(string name)
		{
			return string.Join(" ", name.Split().Select(s => s[0] + "."));
		}
	}
}
//https://www.codewars.com/kata/57b56af6b69bfcffb80000d7/train/csharp