using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class HowManyUrinalsTask
	{
		public static int GetFreeUrinals(string urinals)
		{
			if (urinals.Contains("11"))
			{
				return -1;

			}

			int result = 0;
			char[] urinalsArray = urinals.ToCharArray();

			for (int i = 0; i < urinalsArray.Length; i++)
			{
				if (urinalsArray[i] == '0')
				{
					bool leftEmpty = (i == 0 || urinalsArray[i - 1] == '0');
					bool rightEmpty = (i == urinalsArray.Length - 1 || urinalsArray[i + 1] == '0');

					if (leftEmpty && rightEmpty)
					{
						urinalsArray[i] = '1';
						result++;
					}
				}
			}
			return result;

		}
	}
}
//https://www.codewars.com/kata/5e2733f0e7432a000fb5ecc4/train/csharp