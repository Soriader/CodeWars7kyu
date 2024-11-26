using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class ChineseZodiacTask
	{
		enum Animal
		{
			Rat, Ox, Tiger, Rabbit, Dragon, Snake, Horse, Goat, Monkey, Rooster, Dog, Pig
		}

		enum Elements
		{
			Wood, Fire, Earth, Metal, Water
		}

		public static string ChineseZodiac(int year)
		{
			int startYear = 1924;
			int iteratorForAnimal = 0;
			int iteratorForElement = 0;

			while(startYear != year)
			{
				startYear++;
				iteratorForAnimal++;

				if (iteratorForAnimal > 11)
				{
					iteratorForAnimal = 0;
				}

				if (iteratorForAnimal % 2 == 0)
				{
					iteratorForElement++;
				}
				if (iteratorForElement > 4)
				{
					iteratorForElement = 0;
				}

			}

			Animal animal = (Animal)iteratorForAnimal;
			Elements element = (Elements)iteratorForElement;

			return $"{element} {animal}";
		}
	}
}
//https://www.codewars.com/kata/57a73e697cb1f31dd70000d2/train/csharp