using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class WhatDominatesYourArrayTask
	{
		public static int WhoDominates(int[] array)
		{
			Dictionary<int, int> howManyNumbersInArray = new Dictionary<int, int>();

			int n = array.Length;

			foreach (int number in array)
			{
				if (howManyNumbersInArray.ContainsKey(number))
				{
					howManyNumbersInArray[number]++;
				}
				else
				{
					howManyNumbersInArray.Add(number, 1);
				}
			}

			foreach (var kvp in howManyNumbersInArray)
			{
				if (kvp.Value > n / 2)
				{
					return kvp.Key; 
				}
			}

			return -1;
		}
	}
	
}
//https://www.codewars.com/kata/559e10e2e162b69f750000b4/train/csharp