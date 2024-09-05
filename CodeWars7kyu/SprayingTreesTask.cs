using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class SprayingTreesTask
	{
		public static string Task(string w, int n, int c)
		{
			string name = "";

			switch (w)
			{
				case "Monday":
					name = "James";
					break;
				case "Tuesday":
					name = "John";
					break;
				case "Wednesday":
					name = "Robert";
					break;
				case "Thursday":
					name = "Michael";
					break;
				case "Friday":
					name = "William";
					break;
				default:
					name = "Unknown";
					break;
			}


			return $"It is {w} today, {name}, you have to work, you must spray {n} trees and you need {n*c} dollars to buy liquid";

		}
	}
}
//https://www.codewars.com/kata/5981a139f5471fd1b2000071/train/csharp