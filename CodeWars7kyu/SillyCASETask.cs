using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class SillyCASETask
    {
		public static string SillyCase(string str)
		{
            string result = "";
			str = str.ToLower();
			int halfLength = str.Length / 2;

			if (str.Length % 2 == 0)
            {
				result += new string(str.Select((c, i) => i >= halfLength ? char.ToUpper(c) : c).ToArray());
			}
			else
			{
				result += new string(str.Select((c, i) => i > halfLength ? char.ToUpper(c) : c).ToArray());
			}

			return result;
        }
	}
}
//https://www.codewars.com/kata/552ab0a4db0236ff1a00017a/train/csharp