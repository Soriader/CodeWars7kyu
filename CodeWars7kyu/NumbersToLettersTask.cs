using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class NumbersToLettersTask
    {
        public static string Switcher(string[] x)
        {
            var map = new Dictionary<int, char>
        {
            { 1, 'z' }, { 2, 'y' }, { 3, 'x' }, { 4, 'w' }, { 5, 'v' },
            { 6, 'u' }, { 7, 't' }, { 8, 's' }, { 9, 'r' }, {10, 'q' },
            {11, 'p' }, {12, 'o' }, {13, 'n' }, {14, 'm' }, {15, 'l' },
            {16, 'k' }, {17, 'j' }, {18, 'i' }, {19, 'h' }, {20, 'g' },
            {21, 'f' }, {22, 'e' }, {23, 'd' }, {24, 'c' }, {25, 'b' },
            {26, 'a' }, {27, '!' }, {28, '?' }, {29, ' ' }
        };

            var result = x.Select(num => map[int.Parse(num)]).ToArray();

            return new string(result);
        }
    }
}
//https://www.codewars.com/kata/57ebaa8f7b45ef590c00000c/train/csharp





