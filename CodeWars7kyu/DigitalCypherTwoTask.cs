using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class DigitalCypherTwoTask
	{
		public static string Decode(int[] code, int key)
		{
			string keyString = key.ToString();
			int keyLength = keyString.Length;

			char[] decodedMessage = new char[code.Length];

			for (int i = 0; i < code.Length; i++)
			{
				int keyDigit = int.Parse(keyString[i % keyLength].ToString());

				int originalValue = code[i] - keyDigit;
				decodedMessage[i] = (char)(originalValue + 'a' - 1);
			}

			return new string(decodedMessage);
		}
	}
}
//https://www.codewars.com/kata/592edfda5be407b9640000b2/train/csharp