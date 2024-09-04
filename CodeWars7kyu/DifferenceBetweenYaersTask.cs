using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class DifferenceBetweenYaersTask
	{
		public static int HowManyYears(string date1, string date2)
		{
			var firstDate = date1.Split('/').Select(x => int.Parse(x)).ToList();
			var secondDate = date2.Split('/').Select(x => int.Parse(x)).ToList(); 

			if(secondDate[0] > firstDate[0])
			{
				return secondDate[0] - firstDate[0];
			}

			return firstDate[0] - secondDate[0];
		}
	}
}
//https://www.codewars.com/kata/588f5a38ec641b411200005b/train/csharp