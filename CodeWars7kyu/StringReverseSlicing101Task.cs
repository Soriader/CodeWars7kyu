using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class StringReverseSlicing101Task
    {
		public static string[] ReverseSlice(string str)
		{
			var stringToAdded = new string(str.Reverse().ToArray());
			int lenght = stringToAdded.Length;
			int iterator = 0;
			List<string> result = new List<string>();

			while (iterator != lenght)
			{
				result.Add(stringToAdded);
				stringToAdded = stringToAdded.Remove(0, 1);
				iterator++;
			}

			return result.ToArray();
		}
	}
}
//https://www.codewars.com/kata/586efc2dcf7be0f217000619/train/csharp