using CodeWars7kyu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CodeWars7kyu.DisemvowelTrollsTask;

namespace CodeWars7kyu
{
    public class AutomorphicNumberTask
    {
        public static string Automorphic(int n)
        {
            double square = Math.Pow(n, 2);

            string nStr = n.ToString();
            string squareStr = square.ToString();

            if (squareStr.EndsWith(nStr))
            {
                return "Automorphic";
            }

            return "Not!!";
        }
    }
}
//https://www.codewars.com/kata/5a58d889880385c2f40000aa/train/csharp