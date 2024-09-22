using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class EncodeDecodeTask
    {
		public static string Encode(string str)
		{
			var codeToEncode = "gaderypoluki";
			string result = "";
			var check = str.ToCharArray();

			foreach (var c in check)
			{
				if (char.IsLetter(c) && codeToEncode.Contains(char.ToLower(c)))
				{
					char lowerC = char.ToLower(c);
					int index = codeToEncode.IndexOf(lowerC);

					char encodedChar;
					if (index % 2 == 0)
					{
						encodedChar = codeToEncode[index + 1];
					}
					else
					{
						encodedChar = codeToEncode[index - 1];
					}

					if (char.IsUpper(c))
					{
						result += char.ToUpper(encodedChar);
					}
					else
					{
						result += encodedChar;
					}
				}
				else
				{
					result += c;
				}
			}

			return result;
		}

		public static string Decode(string str)
		{
			return Encode(str);
		}
	}
}
//https://www.codewars.com/kata/592a6ad46d6c5a62b600003f/train/csharp