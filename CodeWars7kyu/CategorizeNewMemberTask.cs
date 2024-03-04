using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class CategorizeNewMemberTask
    {
        public static IEnumerable<string> OpenOrSenior(int[][] data)
        {
            foreach (var member in data)
            {
                int age = member[0];
                int handicap = member[1];

                if (age >= 55 && handicap > 7)
                {
                    yield return "Senior";
                }
                else
                {
                    yield return "Open";
                }
            }
        }
    }
}
//https://www.codewars.com/kata/5502c9e7b3216ec63c0001aa/train/csharp