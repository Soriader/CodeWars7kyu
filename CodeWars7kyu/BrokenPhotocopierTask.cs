using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class BrokenPhotocopierTask
	{
		public static string Broken(string x)
		{
			var check = x.ToCharArray();
			string result = "";

			foreach (char c in check) 
			{
				if (c == '1')
				{
					result += c.ToString().Replace("1", "0");
				}
				else if (c == '0')
				{
					result += c.ToString().Replace("0", "1");

				}
			}

			return result;

		}
	}
}
//https://www.codewars.com/kata/57ed56657b45ef922300002b/train/csharp