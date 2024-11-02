using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodeWars7kyu
{
	public class ORingArraysTask
	{
		public static int[] OrArrays(int[] arr1, int[] arr2, int d = 0)
		{
			int maxLength = Math.Max(arr1.Length, arr2.Length);
			List<int> result = new List<int>();

			for (int i = 0; i < maxLength; i++)
			{
				int value1 = (i < arr1.Length) ? arr1[i] : d; 
				int value2 = (i < arr2.Length) ? arr2[i] : d;

				result.Add(value1 | value2);
			}

			return result.ToArray();
		}

	}
}
//https://www.codewars.com/kata/5ac5e9aa3853da25d9000102/train/csharp