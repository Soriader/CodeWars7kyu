using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class ThePonyExpressTask
	{
		public static int Riders(int[] stations)
		{
			int riders = 1;  
			int distance = 0;  

			foreach (int station in stations)
			{
				distance += station;

				if (distance > 100)
				{
					riders++;
					distance = station;
				}
			}

			return riders;


		}
	}
}
//https://www.codewars.com/kata/5b18e9e06aefb52e1d0001e9/train/csharp