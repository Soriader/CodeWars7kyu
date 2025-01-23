using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class CatsInHatsTask
	{
		public static string Height(int n)
		{
			double currentCat = 2000000.000;
			double totalHeigth = 0;
			int i = 0;
			while (i <= n)
			{
				totalHeigth += currentCat;
				currentCat /= 2.5;
				i++;
			}

			return totalHeigth.ToString("F3");
		}
	}
}
//https://www.codewars.com/kata/57b5907920b104772c00002a/train/csharp