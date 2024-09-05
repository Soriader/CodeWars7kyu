using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodeWars7kyu
{
	public class FindTheLongestGapTask
	{
		public static int Gap(int num)
		{
			string binary = Convert.ToString(num, 2);
			int iterator = 0;
			int result = 0;
			bool inGap = false;

			foreach (char bit in binary)
			{
				if (bit == '1')
				{
					if (inGap)
					{
						result = Math.Max(result, iterator); 
					}
					inGap = true; 
					iterator = 0; 
				}
				else if (inGap)
				{
					iterator++;
				}
			}

			return result;
		}
	}
}
//https://www.codewars.com/kata/55b86beb1417eab500000051/train/csharp