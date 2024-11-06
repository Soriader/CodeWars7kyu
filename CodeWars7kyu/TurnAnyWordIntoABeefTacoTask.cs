using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class TurnAnyWordIntoABeefTacoTask
	{
		public static string[] Tacofy(string word)
		{
			List<string> taco = new List<string>() {"shell"};
			string vovels = "aeiou";
			var check = word.ToLower().ToCharArray();

			foreach (char c in check) 
			{
				switch (c)
				{
					case 't':
						{
							taco.Add("tomato");
							break;
						}
					case 'l':
						{
							taco.Add("lettuce");
							break;
						}
					case 'c':
						{
							taco.Add("cheese");
							break;
						}
					case 'g':
						{
							taco.Add("guacamole");
							break;
						}
					case 's':
						{
							taco.Add("salsa");
							break;
						}
					default: 
						{
							if (vovels.Contains(c))
							{
								taco.Add("beef");
							}
							break;
						}

				}
			}

			taco.Add("shell");

			return taco.ToArray();
		}
	}
}
//https://www.codewars.com/kata/59414b46d040b7b8f7000021/train/csharp