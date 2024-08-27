using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class CatDogTask
	{
		public static (int, int) OwnedCatAndDog(int catYears, int dogYears)
		{
			return (CatYearsToHumanYears(catYears), DogYearsToHumanYears(dogYears));
		}

		public static int CatYearsToHumanYears(int catYears)
		{
			if (catYears < 15) 
			{
				return 0; 
			}
			else if (catYears < 24)
			{
				return 1;
			}
			else
			{
				return 2 + (catYears - 24) / 4;
			}
		}

		public static int DogYearsToHumanYears(int dogYears)
		{
			if (dogYears < 15)
			{
				return 0;
			}
			else if (dogYears < 24)
			{
				return 1;
			}
			else
			{
				return 2 + (dogYears - 24) / 5;
			}
		}
	}
}
//https://www.codewars.com/kata/5a6d3bd238f80014a2000187/train/csharp