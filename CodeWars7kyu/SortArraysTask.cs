using MoreLinq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class SortArraysTask
    {
        public static string[] SortMe(string[] names)
        {
            Array.Sort(names, StringComparer.InvariantCulture);

            return names;
        }

    }
}
//https://www.codewars.com/kata/51f41b98e8f176e70d0002a8/train/csharp