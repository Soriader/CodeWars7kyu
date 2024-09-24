using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class JavascriptFilterTask
    {
		public static string[][] SearchNames(string[][] logins)
		{
			List<string[]> results = new List<string[]>();

			foreach (var login in logins)
			{
				if (login.Length >= 2 && login[0].EndsWith("_"))
				{
					results.Add(new string[] { login[0], login[1] });
				}
			}

			return results.ToArray();
		}
	}
}
//https://www.codewars.com/kata/525d9b1a037b7a9da7000905/train/csharp