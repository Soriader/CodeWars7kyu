using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class CorrectTheTimeStringTask
	{
		public static string Correct(string timeString)
		{
			if (string.IsNullOrEmpty(timeString))
			{
				return timeString;
			}

			var checkTime = timeString.Split(":");

			if (checkTime.Length != 3)
			{
				return null;
			}

			bool validHour = int.TryParse(checkTime[0], out int hour);
			bool validMinute = int.TryParse(checkTime[1], out int minute);
			bool validSecond = int.TryParse(checkTime[2], out int second);

			if (!validHour || !validMinute || !validSecond)
			{
				return null;
			}

			if (second >= 60)
			{
				minute += second / 60;
				second = second % 60;
			}

			if (minute >= 60)
			{
				hour += minute / 60;
				minute = minute % 60;
			}

			if (hour >= 24)
			{
				hour = hour % 24;
			}

			return $"{hour:D2}:{minute:D2}:{second:D2}";

		}
	}
}
//https://www.codewars.com/kata/57873ab5e55533a2890000c7/train/csharp