using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class SelectiveFearOfNumbersTask
	{
		public static bool AmIAfraid(string day, int num)
		{
			switch (day) 
			{
				case "Monday":
				{
					if(num == 12)
					{
						return true;
					}
					else
					{
						return false;
					}
				}
				case "Tuesday":
					{
						if (num > 95)
						{
							return true;
						}
						else
						{
							return false;
						}
					}
				case "Wednesday":
					{
						if (num == 34)
						{
							return true;
						}
						else
						{
							return false;
						}
					}
				case "Thursday":
					{
						if (num == 0)
						{
							return true;
						}
						else
						{
							return false;
						}
					}
				case "Friday":
					{
						if (num % 2 == 0)
						{
							return true;
						}
						else
						{
							return false;
						}
					}
				case "Saturday":
					{
						if (num == 56)
						{
							return true;
						}
						else
						{
							return false;
						}
					}
				case "Sunday":
					{
						if (num == -666 || num == 666)
						{
							return true;
						}
						else
						{
							return false;
						}
					}
			}

			return false;
		}
	}
}
//https://www.codewars.com/kata/55b1fd84a24ad00b32000075/train/csharp