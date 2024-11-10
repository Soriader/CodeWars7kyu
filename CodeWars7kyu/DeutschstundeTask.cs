using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class DeutschstundeTask
	{
		public static string DerDieDas(string wort)
		{
			string vovels = "aeiouäöü";
			int iterator = 0;
			foreach (char item in wort.ToLower())
			{
				if (vovels.Contains(item))
				{
					iterator++;
				}
			}

			if(iterator < 2)
			{
				return $"das {wort}";
			}
			else if(iterator == 2 || iterator == 3)
			{
				return $"die {wort}";
			}
			else
			{
				return $"der {wort}";
			}
		}
	}
}
//https://www.codewars.com/kata/552cd8624a414ec2b2000086/train/csharp