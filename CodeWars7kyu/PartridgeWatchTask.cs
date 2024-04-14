using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class PartridgeWatchTask
    {
        public static string Part(string[] x)
        {
            string[] relatedTerms = { "Partridge", "PearTree", "Chat", "Dan", "Toblerone", "Lynn", "AlphaPapa", "Nomad" };

            if (x.Any(item => relatedTerms.Contains(item)))
            {
                int exclamationCount = x.Count(item => relatedTerms.Contains(item));
                string exclamationMarks = new string('!', exclamationCount);
                return $"Mine's a Pint{exclamationMarks}";
            }
            else
            {
                return "Lynn, I've pierced my foot on a spike!!";
            }

        }
    }
}
//https://www.codewars.com/kata/5808c8eff0ed4210de000008/train/csharp