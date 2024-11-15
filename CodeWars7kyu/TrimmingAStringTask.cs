using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class TrimmingAStringTask
	{
		public static string TrimString(string phrase, int len)
		{
			if (phrase.Length <= len)
			{
				return phrase;
			}

			string result = "";

			if (len <= 3)
			{
				for (int i = 0; i < len; i++)
				{
					result += phrase[i];
				}

				return result + "...";
			}


			result = phrase.Substring(0, len - 3);

			return result + "...";
		}
	}
}
//https://www.codewars.com/kata/563fb342f47611dae800003c/train/csharp