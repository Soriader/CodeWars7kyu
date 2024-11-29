using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class FridayThe13thPartOneTask
	{
		public static string[] KillCount(Dictionary<string, int> counselors, int jason)
		{
			return counselors.Where(c => c.Value < jason).Select(c => c.Key).ToList().ToArray();
		}
	}
}
//https://www.codewars.com/kata/5925acf31a9825d616000e74/train/csharp