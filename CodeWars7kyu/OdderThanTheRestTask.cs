using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class OdderThanTheRestTask
	{
		public static int OddOne(List<int> list)
		{
			int iterator = 0;

			foreach (var item in list) 
			{

				if(item % 2 != 0)
				{
					return iterator;
				}

				iterator++;
			}

			return -1;
		}
	}
}
//https://www.codewars.com/kata/5983cba828b2f1fd55000114/train/csharp