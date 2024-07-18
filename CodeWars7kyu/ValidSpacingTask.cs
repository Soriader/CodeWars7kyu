using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class ValidSpacingTask
    {
        public static bool ValidSpacing(string s)
        {
            if (string.IsNullOrEmpty(s) || !s.Contains(' '))
            {
                return true;
            }

            if (s.First() == ' ' || s.Last() == ' ')
            {
                return false;
            }

            string[] words = s.Split(' ');

            foreach (string word in words)
            {
                if (string.IsNullOrEmpty(word))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
//https://www.codewars.com/kata/5f77d62851f6bc0033616bd8/train/csharp