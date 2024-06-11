using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class TheOfficeIIBoredomScoreTask
    {
        public static string Boredom(Dictionary<string, string> staff)
        {
            Dictionary<string, int> departmentScores = new Dictionary<string, int>
        {
            { "accounts", 1 },
            { "finance", 2 },
            { "canteen", 10 },
            { "regulation", 3 },
            { "trading", 6 },
            { "change", 6 },
            { "IS", 8 },
            { "retail", 5 },
            { "cleaning", 4 },
            { "pissing about", 25 }
        };

            int totalScore = 0;
            foreach (var employee in staff)
            {
                if (departmentScores.ContainsKey(employee.Value))
                {
                    totalScore += departmentScores[employee.Value];
                }
            }

            if (totalScore <= 80)
            {
                return "kill me now";
            }
            else if (totalScore < 100)
            {
                return "i can handle this";
            }
            else
            {
                return "party time!!";
            }
        }
    }
}
//https://www.codewars.com/kata/57ed4cef7b45ef8774000014/train/csharp