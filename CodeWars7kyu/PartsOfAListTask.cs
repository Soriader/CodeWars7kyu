using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class PartsOfAListTask
    {
        public static string[][] Partlist(string[] arr)
        {
            string[][] result = new string[arr.Length - 1][];

            for (int i = 0; i < arr.Length - 1; i++)
            {
                string[] part1 = new string[i + 1];
                string[] part2 = new string[arr.Length - i - 1];

                Array.Copy(arr, 0, part1, 0, i + 1);
                Array.Copy(arr, i + 1, part2, 0, arr.Length - i - 1);

                result[i] = new string[] { string.Join(" ", part1), string.Join(" ", part2) };
            }

            return result;
        }
    }
}
//https://www.codewars.com/kata/56f3a1e899b386da78000732/train/csharp