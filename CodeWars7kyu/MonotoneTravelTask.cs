using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class MonotoneTravelTask
	{
		public static bool IsMonotone(int[] arr)
		{

			for (int i = 0; i < arr.Length - 1; i++) 
			{
				if(arr[i + 1] >= arr[i])
				{
					continue;
				}
				else
				{
					return false;
				}
			}

			return true;

		}
	}
}
//https://www.codewars.com/kata/54466996990c921f90000d61/train/csharp