using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class EnumerableMagicFiveTask
	{
		public static bool One(int[] arr, Func<int, bool> fun)
		{
			int iterator = 0; 
			foreach (int item in arr)
			{
				if (fun(item))
				{
					iterator++;
				}
			}

			if (iterator == 1)
			{
				return true;
			}
			return false;
		}
	}
}
//https://www.codewars.com/kata/54599705cbae2aa60b0011a4/train/csharp