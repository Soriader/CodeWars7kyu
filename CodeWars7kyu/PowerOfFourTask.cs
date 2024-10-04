using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class PowerOfFourTask
	{
		public static bool PowerOf4(object n)
		{
			if (n is int number && number > 0)
			{
				return (number & (number - 1)) == 0 && (number - 1) % 3 == 0;
			}
			return false;

		}
	}
}
//https://www.codewars.com/kata/544d114f84e41094a9000439/train/csharp

//First result but the process is too long for this task

//public static bool PowerOf4(object n)
//{
//	if (n is string || n is null)
//	{
//		return false;
//	}

//	double checkTheNumber = 0;
//	var parseTheNumber = double.TryParse(n.ToString(), out checkTheNumber);

//	if (!parseTheNumber)
//	{
//		return false;
//	}

//	if (checkTheNumber == 1)
//	{
//		return true;
//	}

//	double power = 1;

//	while (true)
//	{
//		if (Math.Pow(4, power) == checkTheNumber && checkTheNumber != 0)
//		{
//			return true;
//		}
//		else if (Math.Pow(4, power) > checkTheNumber)
//		{
//			return false;
//		}

//		power++;
//	}

//}