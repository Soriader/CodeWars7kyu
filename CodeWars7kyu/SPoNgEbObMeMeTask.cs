using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class SPoNgEbObMeMeTask
	{
		public static string SpongeMeme(string sentence)
		{
			var result = new string(sentence
				.Select((c, i) => i % 2 == 0 ? char.ToUpper(c) : char.ToLower(c))
				.ToArray());

			return result;
		}

	}
}
//https://www.codewars.com/kata/5982619d2671576e90000017/train/csharp