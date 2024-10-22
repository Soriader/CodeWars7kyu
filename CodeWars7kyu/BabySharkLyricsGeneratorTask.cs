using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class BabySharkLyricsGeneratorTask
	{
		public static string BabySharkLyrics()
		{
			int iterator = 0;
			int sharkNumber = 0;
			string song = "";
			string baby = "Baby";
			string mommy = "Mommy";
			string daddy = "Daddy";
			string grandma = "Grandma";
			string grandpa = "Grandpa";
			string hunt = "Let's go hunt, doo doo doo doo doo doo";
			bool work= true;

			while (work)
			{

				if (iterator == 3 && sharkNumber == 5)
				{
					work = false;
					break;
				}

				switch (sharkNumber)
				{
					case 0:
						{
							if(iterator == 3)
							{
								song += $"{baby} shark!\n";
								iterator = 0;
								sharkNumber++;
								break;
							}
							song += $"{baby} shark, doo doo doo doo doo doo\n";
							iterator++;
							break;
						}
					case 1:
						{
							if (iterator == 3)
							{
								song += $"{mommy} shark!\n";
								iterator = 0;
								sharkNumber++;
								break;
							}
							song += $"{mommy} shark, doo doo doo doo doo doo\n";
							iterator++;
							break;
						}
					case 2:
						{
							if (iterator == 3)
							{
								song += $"{daddy} shark!\n";
								iterator = 0;
								sharkNumber++;
								break;
							}
							song += $"{daddy} shark, doo doo doo doo doo doo\n";
							iterator++;
							break;
						}
					case 3:
						{
							if (iterator == 3)
							{
								song += $"{grandma} shark!\n";
								iterator = 0;
								sharkNumber++;
								break;
							}
							song += $"{grandma} shark, doo doo doo doo doo doo\n";
							iterator++;
							break;
						}
					case 4:
						{
							if (iterator == 3)
							{
								song += $"{grandpa} shark!\n";
								iterator = 0;
								sharkNumber++;
								break;
							}
							song += $"{grandpa} shark, doo doo doo doo doo doo\n";
							iterator++;
							break;
						}
						case 5: 
						{
							song += "Let's go hunt, doo doo doo doo doo doo\n";
							iterator++;
							break;
						}
				}
			}


			return song + "Let's go hunt!\nRun away,…\n";
		}


		public static string BabySharkLyricsLessThan300()
		{
			string r = "",
			  d = ", doo doo doo doo doo doo\n", s = " shark";
			foreach (var f in new[] { "Baby" + s, "Mommy" + s, "Daddy" + s, "Grandma" + s, "Grandpa" + s, "Let's go hunt" })
				r += f + d + f + d + f + d + f + "!\n";
			return r + "Run away,…\n";
		}
	}
}
//https://www.codewars.com/kata/5d076515e102162ac0dc514e/train/csharp