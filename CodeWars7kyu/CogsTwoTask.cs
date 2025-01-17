using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class CogsTwoTask
    {
        public static double[] CogRpm(int[] cogs, int n)
        {
            if (cogs == null || cogs.Length == 0)
            {
                return null;
            }

            decimal rpm = 1.0m;

            int numCogs = cogs.Length;

            for (int i = n; i > 0; i--)
            {
                rpm *= -(decimal)cogs[i] / cogs[i - 1];
            }
            decimal firstCogRpm = rpm;

            rpm = 1.0m;
            for (int i = n; i < numCogs - 1; i++)
            {
                rpm *= -(decimal)cogs[i] / cogs[i + 1];
            }
            decimal lastCogRpm = rpm;

            return new[] { (double)firstCogRpm, (double)lastCogRpm };
        }
    }
}
//https://www.codewars.com/kata/59e72bdcfc3c4974190000d9/train/csharp