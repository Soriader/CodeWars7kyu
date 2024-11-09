using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class FusionChamberShutdownTask
	{
		public static (int, int, int) Burner(int c, int h, int o)
		{
			int water = 0;
			int co2 = 0;
			int methane = 0;

			while (h >= 2 && o >= 1) 
			{
				h -= 2;
				o -= 1;
				water++;
			}

			while (c >= 1 && o >= 2) 
			{
				c -= 1;
				o -= 2;
				co2++;
			}

			while (h >= 4 && c >= 1)
			{
				c -= 1;
				h -= 4;
				methane++;
			}

			return (water, co2, methane);
		}
	}
}
//https://www.codewars.com/kata/5fde1ea66ba4060008ea5bd9/train/csharp