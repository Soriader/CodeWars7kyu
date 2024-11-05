using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class InternationalMorseCodeEncryptionTask
	{
		static Dictionary<char, string> morseAlphabet = new Dictionary<char, string>
	{
		{ 'A', ".-" }, { 'B', "-..." }, { 'C', "-.-." },
		{ 'D', "-.." }, { 'E', "." }, { 'F', "..-." },
		{ 'G', "--." }, { 'H', "...." }, { 'I', ".." },
		{ 'J', ".---" }, { 'K', "-.-" }, { 'L', ".-.." },
		{ 'M', "--" }, { 'N', "-." }, { 'O', "---" },
		{ 'P', ".--." }, { 'Q', "--.-" }, { 'R', ".-." },
		{ 'S', "..." }, { 'T', "-" }, { 'U', "..-" },
		{ 'V', "...-" }, { 'W', ".--" }, { 'X', "-..-" },
		{ 'Y', "-.--" }, { 'Z', "--.." },
		{ '1', ".----" }, { '2', "..---" }, { '3', "...--" },
		{ '4', "....-" }, { '5', "....." }, { '6', "-...." },
		{ '7', "--..." }, { '8', "---.." }, { '9', "----." },
		{ '0', "-----" },
		{ ' ', " " }
    };
		public static string ToMorse(string englishStr)
		{
			englishStr = englishStr.ToUpper();
			StringBuilder morseResult = new StringBuilder();

			foreach (char letter in englishStr)
			{
				if (morseAlphabet.ContainsKey(letter))
				{
					morseResult.Append(morseAlphabet[letter] + " ");
				}
			}

			return morseResult.ToString().Trim();
		}
	}
}
//https://www.codewars.com/kata/55b8c0276a7930249e00003c/train/csharp