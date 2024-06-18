using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class ToLeetSpeakTask
    {
        private static readonly Dictionary<char, char> LeetDictionary = new Dictionary<char, char>
    {
        {'A', '@'},
        {'B', '8'},
        {'C', '('},
        {'D', 'D'},
        {'E', '3'},
        {'F', 'F'},
        {'G', '6'},
        {'H', '#'},
        {'I', '!'},
        {'J', 'J'},
        {'K', 'K'},
        {'L', '1'},
        {'M', 'M'},
        {'N', 'N'},
        {'O', '0'},
        {'P', 'P'},
        {'Q', 'Q'},
        {'R', 'R'},
        {'S', '$'},
        {'T', '7'},
        {'U', 'U'},
        {'V', 'V'},
        {'W', 'W'},
        {'X', 'X'},
        {'Y', 'Y'},
        {'Z', '2'}
    };

        public static string ToLeetSpeak(string str)
        {
            char[] leetChars = new char[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                char currentChar = str[i];
                if (LeetDictionary.ContainsKey(currentChar))
                {
                    leetChars[i] = LeetDictionary[currentChar];
                }
                else
                {
                    leetChars[i] = currentChar; 
                }
            }

            return new string(leetChars);

        }
    }
}
//https://www.codewars.com/kata/57c1ab3949324c321600013f/train/csharp