using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class ZebulanNightmareTask
	{
		public static string ZebulansNightmare(string functionName)
		{
			var check = functionName.Split("_").ToArray();
			string result = "";

			for (int i = 0; i < check.Length; i++)
			{
				if (check[i].Length > 0)
				{
					if (i == 0)
					{
						result += char.ToLower(check[i][0]) + check[i].Substring(1).ToLower();
					}
					else
					{
						result += char.ToUpper(check[i][0]) + check[i].Substring(1).ToLower();
					}
				}
			}

			return result;

		}
	}
}
//https://www.codewars.com/kata/570fd7ad34e6130455001835/train/csharp