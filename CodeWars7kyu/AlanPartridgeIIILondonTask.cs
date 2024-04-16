using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class AlanPartridgeIIILondonTask
    {
        public static string Alan(string[] x)
        {
            string[] stations = { "Rejection", "Disappointment", "Backstabbing Central", "Shattered Dreams Parkway" };

            foreach (string station in stations)
            {
                if (!x.Contains(station))
                {
                    return "No, seriously, run. You will miss it.";
                }
            }

            return "Smell my cheese you mother!";
        }
    }
}
//https://www.codewars.com/kata/580a41b6d6df740d6100030c/train/csharp