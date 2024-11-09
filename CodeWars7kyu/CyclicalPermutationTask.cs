using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodeWars7kyu
{
	public class CyclicalPermutationTask
	{
		public static string Pattern(int n)
		{
			if (n <= 0) 
			{
				return "";
			}

			var list = new List<string>();
			var nums = new List<int>();

			for (int i = 1; i <= n; i++)
			{
				nums.Add(i);
			}

			list.Add(string.Concat(nums));

			for (int i = 1; i < n; i++)
			{
				var temp = nums[0];
				nums.RemoveAt(0);
				nums.Add(temp);
				list.Add(string.Concat(nums));
			}

			return string.Join("\n", list);
		}


	}
}
//https://www.codewars.com/kata/557592fcdfc2220bed000042/train/csharp