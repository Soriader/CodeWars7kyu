using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class ShadesOfGreyTask
	{
		public static string[] ShadesOfGrey(int n)
		{
			n = Math.Max(0, Math.Min(n, 254));

			List<string> shades = new List<string>();

			for (int i = 1; i <= n; i++)
			{
				string hexValue = i.ToString("x2");
				string shade = $"#{hexValue}{hexValue}{hexValue}";
				shades.Add(shade);
			}

			return shades.ToArray();
		}
	}
	
}
//https://www.codewars.com/kata/54d22119beeaaaf663000024/train/csharp