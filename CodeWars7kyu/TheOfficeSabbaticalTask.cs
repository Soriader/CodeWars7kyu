using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class TheOfficeSabbaticalTask
	{
		public static string Sabb(string s, int val, int happiness)
		{
			char[] sabbatical = { 's', 'a', 'b', 't', 'i', 'c', 'l' };
			int iterator = 0;

			var check = s.ToLower().ToCharArray();

			for (int i = 0; i < check.Length; i++)
			{
				if (sabbatical.Contains(check[i]))
				{
					iterator++;
				}
			}

			if (iterator + val + happiness > 22)
			{
				return "Sabbatical! Boom!";
			}
			else
			{
				return "Back to your desk, boy.";
			}
		}
	}
}
//https://www.codewars.com/kata/57fe50d000d05166720000b1/train/csharp