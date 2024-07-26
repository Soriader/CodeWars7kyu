using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class CountConsonantsTask
	{
		public static int ConsonantCount(string str)
		{
			char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

			int result = 0;

			foreach (var item in str)
			{
				if (char.IsLetter(item))
				{
					if (!vowels.Contains(item))
					{
						result++;
					}
				}
			}

			return result;
		}
	}
}
