using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class EasyTimeConvertTask
	{
		public static string TimeConvert(int num)
		{
			if (num < 0)
			{
				return "00:00";
			}

			int hours = num / 60; 
			int minutes = num % 60; 

			return $"{hours:D2}:{minutes:D2}";
		}
	}
}
//https://www.codewars.com/kata/5a084a098ba9146690000969/train/csharp