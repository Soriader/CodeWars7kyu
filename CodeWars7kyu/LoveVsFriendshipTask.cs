using CodeWars7kyu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class LoveVsFriendshipTask
    {
        public static int WordsToMarks(string str)
        {
            var sumOfNumer = str.ToLower().Where(char.IsLetter).Sum(c => c - 'a' + 1);

            return sumOfNumer;
        }
    }
}
//https://www.codewars.com/kata/59706036f6e5d1e22d000016/train/csharp
