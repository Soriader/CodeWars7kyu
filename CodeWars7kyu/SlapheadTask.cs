using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class SlapheadTask
	{
		public static string[] Bald(string x)
		{
			int iterator = 0;
			var check = x.ToCharArray();

			foreach (char c in check) 
			{
				if(c == '/')
				{
					iterator++; 
				}
			}

			var result = x.Replace("/", "-");


			if (iterator == 0)
			{
				return new string[] { result, "Clean!" };
			}
			else if (iterator == 1)
			{
				return new string[] { result, "Unicorn!" };
			}
			else if (iterator == 2) 
			{
				return new string[] { result, "Homer!" };
			}
			else if (iterator == 3 || iterator == 4 || iterator == 5)
			{
				return new string[] { result, "Careless!" };
			}
			else
			{
				return new string[] { result, "Hobo!" };
			}

		}
	}
}
//https://www.codewars.com/kata/57efab9acba9daa4d1000b30/train/csharp