using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class CogsTask
    {
        public static double CogRpm(int[] cogs)
        {
            if (cogs == null || cogs.Length == 0) 
            {
                return 0; 
            }

            decimal rpm = 1.0m; 

            for (int i = 0; i < cogs.Length - 1; i++)
            {
                rpm *= -(decimal)cogs[i] / cogs[i + 1]; 
            }

            return (double)Math.Round(rpm, 9);
        }
    }
}
//https://www.codewars.com/kata/59e1b9ce7997cbecb9000014/train/csharp