using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class LengthAndTwoTask
	{
		public static object[] Alternate(int n, object firstValue, object secondValue)
		{
			List<object> result = new List<object>();

			for (int i = 0; i < n; i++)
			{
				if (i % 2 == 0)
				{
					result.Add(firstValue);
				}
				else
				{
					result.Add(secondValue);
				}
			}

			return result.ToArray();
		}
	}
}
//https://www.codewars.com/kata/62a611067274990047f431a8/train/csharp