using MoreLinq.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class DescribeAListTask
	{
		public static string DescribeList(List<int> list)
		{
			if(list.Count == 0)
			{
				return "empty";
			}

			return list.Count == 1 ? "singleton" : "longer";
		}
	}
}
//https://www.codewars.com/kata/57a4a3e653ba3346bc000810/train/csharp