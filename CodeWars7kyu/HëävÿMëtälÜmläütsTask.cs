using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class HeavyMetalTask
	{
		public static Dictionary<char, char> HeavyLetters = new Dictionary<char, char>()
{
	{'A', 'Ä'},
	{'E', 'Ë'},
	{'I', 'Ï'},
	{'O', 'Ö'},
	{'U', 'Ü'},
	{'Y', 'Ÿ'},
	{'a', 'ä'},
	{'e', 'ë'},
	{'i', 'ï'},
	{'o', 'ö'},
	{'u', 'ü'},
	{'y', 'ÿ'}
};

		public static string HeavyMetalUmlauts(string boringText)
		{
			var result = "";

			foreach (char c in boringText) 
			{
				if (HeavyLetters.ContainsKey(c))
				{
					result += HeavyLetters[c];               
				}
				else
				{
					result += c;
				}
			}

			return result;
		}
	}
}
//https://www.codewars.com/kata/57d4e99bec16701a67000033/train/csharp