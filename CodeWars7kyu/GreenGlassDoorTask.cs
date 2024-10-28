using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class GreenGlassDoorTask
	{
		public static bool StepThroughWith(string s)
		{
			var check = s.ToCharArray();

			for (int i = 0; i < check.Length - 1; i++) 
			{
				if (check[i] == check[i + 1])
				{
					return true;
				}
			}

			return false;
		}

	}
}
//https://www.codewars.com/kata/5642bf07a586135a6f000004/train/csharp