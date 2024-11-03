using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class DoubletonNumberTask
	{
		public static int Doubleton(int num)
		{
			Dictionary<int, int> doubletonMap = new Dictionary<int, int>(); 	
			bool isDoubleton = false;
			var check = num + 1;

			while (!isDoubleton)
			{
				var actualNumber = check.ToString();

				foreach (char digitChar in actualNumber)
				{
					int digit = (int)char.GetNumericValue(digitChar);

					if (doubletonMap.ContainsKey(digit))
					{
						doubletonMap[digit]++;
					}
					else
					{
						doubletonMap[digit] = 1;
					}
				}

				if (HasTwoUniqueNumbers(doubletonMap))
				{
					return int.Parse(actualNumber);
				}
				else
				{
					doubletonMap = new Dictionary<int, int>();
					check++;
				}
			}

			return 0;
		}

		static bool HasTwoUniqueNumbers(Dictionary<int, int> digitCount)
		{
			return digitCount.Count == 2;
		}
	}
}
//https://www.codewars.com/kata/604287495a72ae00131685c7/train/csharp