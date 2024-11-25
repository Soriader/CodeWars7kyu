using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class BobShortFormsTask
	{
		public string ShortForm(string str)
		{
			var vovels = "aeiouAEIOU";
			string result = "";

			for (int i = 0; i < str.Length; i++)
			{
				if (vovels.Contains(str[i]) && i != 0 && i != str.Length - 1)
				{
					continue;
				}
				else
				{
					result += str[i];
				}
			}	

			return result;
		}
	}
}
//https://www.codewars.com/kata/570cbe88f616a8f4f50011ac/train/csharp