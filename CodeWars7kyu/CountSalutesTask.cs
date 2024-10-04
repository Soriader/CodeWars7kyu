using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class CountSalutesTask
	{
		public static int CountSalutes(string hallway)
		{
			var removeMark = hallway.Replace("-", "");

			if (string.IsNullOrEmpty(removeMark))
			{
				return 0;
			}

			int result = 0;

			for (int i = 0; i < removeMark.Length; i++)
			{
				if (removeMark[i] == '>')
				{
					for (int j = i + 1; j < removeMark.Length; j++)
					{
						if (removeMark[j] == '<')
						{
							result++;
						}
					}
				}
			}

			return result * 2;
		}
	}
}
//https://www.codewars.com/kata/605ae9e1d2be8a0023b494ed/train/csharp