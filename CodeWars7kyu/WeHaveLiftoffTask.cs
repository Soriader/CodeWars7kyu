using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class WeHaveLiftoffTask
	{
		public static string Liftoff(List<int> instructions)
		{
			if(instructions == null)
			{
				throw new NotImplementedException();
			}

			instructions = instructions.OrderBy(x => x).ToList();
			instructions.Reverse();

			string result = "";

			foreach (int i in instructions) 
			{
				result += i.ToString() + " ";
			}

			return $"{result}liftoff!";
		}
	}
}
//https://www.codewars.com/kata/53d6387b83db278202000802/train/csharp