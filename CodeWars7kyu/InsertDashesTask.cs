using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class InsertDashesTask
	{
		public static string InsertDash(int num)
		{
			var check = num.ToString().ToCharArray();
			string result = "";

			for (int i = 0; i < check.Length - 1 ;  i++)
			{
				result += check[i].ToString();

				if (check[i] % 2 != 0 && check[i + 1] % 2 != 0)
				{
					result += "-";

				}

			}

			return result + check.Last();
		}
	}
}
//https://www.codewars.com/kata/55960bbb182094bc4800007b/train/csharp