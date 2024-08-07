using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class AllInclusiveTask
	{
		public static Boolean ContainAllRots(string strng, List<string> arr)
		{
			if (strng == null)
			{
				return true;
			}

			List<string> rotations = new List<string>();
			int length = strng.Length;
			int iterator = 0;

			for (int i = 0; i < length; i++)
			{
				string rotation = strng.Substring(i) + strng.Substring(0, i);
				rotations.Add(rotation);
			}

			var check = rotations.Count();

			foreach (string word in rotations) 
			{
				if (arr.Contains(word))
				{
					iterator++;
				}
			}

			if( iterator == check) 
			{
				return true;
			}

			return false;


		}
	}
}
//https://www.codewars.com/kata/5700c9acc1555755be00027e/train/csharp