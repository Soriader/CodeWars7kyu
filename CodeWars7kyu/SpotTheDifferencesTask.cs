using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class SpotTheDifferencesTask
	{
		public static List<int> Spot(string s1, string s2)
		{
			List<int> result = new List<int>();

			for (int i = 0; i < s1.Length; i++) 
			{
				if (s1[i] != s2[i])
				{
					result.Add(i);
				}
			}

			return result;
		}
	}
}
//https://www.codewars.com/kata/5881460c780e0dd207000084/train/csharp