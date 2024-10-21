using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class OffloadYourWorkTask
	{
		public static string WorkNeeded(int projectMinutes, int[][] freelancers)
		{
			int sumOfFreelancersTime = 0;

			foreach (var time in freelancers)
			{
				int hours = time[0];  
				int minutes = time[1]; 

				sumOfFreelancersTime += hours * 60 + minutes;
			}

			int remainingMinutes = projectMinutes - sumOfFreelancersTime;

			if (remainingMinutes <= 0)
			{
				return "Easy Money!";
			}
			else
			{
				int hoursNeeded = remainingMinutes / 60;
				int minutesNeeded = remainingMinutes % 60;
				return $"I need to work {hoursNeeded} hour(s) and {minutesNeeded} minute(s)";
			}
		}
	}
}
//https://www.codewars.com/kata/5b3e1dca3da310a4390000f3/train/csharp