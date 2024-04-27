using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class AlphabetWarTask
	{
		public static string AlphabetWar(string fight)
		{
			var result = fight.ToLower().ToCharArray();
			int rightScore = 0;
			int leftScore = 0;

			for (int i = 0; i < result.Length; i++)
			{
				switch(result[i])
				{
					case 'w':
						{
							leftScore += 4;
							break;
						}
					case 'p':
						{
							leftScore += 3;
							break;
						}
					case 'b':
						{
							leftScore += 2;
							break;
						}
					case 's':
						{
							leftScore += 1;
							break;
						}
					case 'm':
						{
							rightScore += 4;
							break;
						}
					case 'q':
						{
							rightScore += 3;
							break;
						}
					case 'd':
						{
							rightScore += 2;
							break;
						}
					case 'z':
						{
							rightScore += 1;
							break;
						}
				}
			}

			if (rightScore > leftScore) return "Right side wins!";
			if (leftScore > rightScore) return "Left side wins!";

			return "Let's fight again!";
		}
	}
}
