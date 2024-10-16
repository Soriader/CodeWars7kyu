using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class Ch4113ng3Task
	{
		public static string Nerdify(string str)
		{
			if (str == null)
			{
				throw new ArgumentNullException();
			}

			return str.Replace('a', '4')
				.Replace('A', '4')
				.Replace('e', '3')
				.Replace('E', '3')
				.Replace('l', '1');
		}
	}
}
//https://www.codewars.com/kata/59e9f404fc3c49ab24000112/train/csharp