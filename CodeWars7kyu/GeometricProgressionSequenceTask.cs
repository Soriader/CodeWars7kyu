using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class GeometricProgressionSequenceTask
	{
		public static string GeometricSequenceElements(int a, int r, int n)
		{
			if(n == 1)
			{
				return $"{a}";
			}

			string result = "";
			int actualElement = a;
			int iterator = 1;

			result += actualElement + ", ";

			for (int i = 1; i < n; i++) 
			{
				iterator++;

				if (iterator == n)
				{
					actualElement = actualElement * r;
					result += actualElement;
					break;
				}

				actualElement = actualElement * r;
				result += actualElement + ", ";
			}

			return result;
		}
	}
}
//https://www.codewars.com/kata/55caef80d691f65cb6000040/train/csharp