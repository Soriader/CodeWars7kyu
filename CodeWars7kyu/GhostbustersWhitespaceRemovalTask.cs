using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class GhostbustersWhitespaceRemovalTask
	{
		public static string GhostBusters(string building)
		{
			var check = " ";

			if (building.Contains(check)) 
			{
				return building.Replace(" ", "");
			}

			return "You just wanted my autograph didn't you?";
		}
	}
}
//https://www.codewars.com/kata/5668e3800636a6cd6a000018/train/csharp