using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class KatastropheTask
	{
		public static string StrongEnough(int[][] earthquake, int age)
		{
			double buildingPower = 1000 * Math.Pow(0.99, age); 
			var earthquakePower = EarthquakePower(earthquake);

			if(buildingPower >= earthquakePower)
			{
				return "Safe!";
			}


			return "Needs Reinforcement!";
		}

		static int EarthquakePower(int[][] earthquake)
		{
			int earthquakePower = 1;

			foreach (var innerArray in earthquake)
			{
				int sum = 0; 

				foreach (var number in innerArray)
				{
					sum += number;
				}

				earthquakePower *= sum;
			}

			return earthquakePower; 
		}
	}
}
//https://www.codewars.com/kata/55a3cb91d1c9ecaa2900001b/train/csharp