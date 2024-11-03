using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class ElapsedSecondsTask
	{
		public static int ElapsedSeconds(DateTime startDate, DateTime endDate)
		{
			TimeSpan timeSpan = endDate - startDate;

			return (int)timeSpan.TotalSeconds;
		}
	}
}
//https://www.codewars.com/kata/517b25a48557c200b800000c/train/csharp