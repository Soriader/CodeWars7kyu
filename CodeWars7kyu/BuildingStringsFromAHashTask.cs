using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class BuildingStringsFromAHashTask
    {
        public static string StringifyDict<TKey, TValue>(Dictionary<TKey, TValue> hash)
        {
            string result = "";

            foreach (var item in hash)
            {
                result += $"{item.Key} = {item.Value},";
            }

            return result.Trim(',');

        }
    }
}
//https://www.codewars.com/kata/51c7d8268a35b6b8b40002f2/train/csharp