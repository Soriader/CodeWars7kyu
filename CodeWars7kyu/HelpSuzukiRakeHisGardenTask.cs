using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class HelpSuzukiRakeHisGardenTask
    {
        public static string RakeGarden(string garden)
        {
            var cleanGarden = garden.Split(' ');
            StringBuilder resultBuilder = new StringBuilder();

            foreach (var item in cleanGarden)
            {
                if (item == "gravel" || item == "rock")
                {
                    resultBuilder.Append(item).Append(" ");
                }
                else
                {
                    resultBuilder.Append("gravel").Append(" ");
                }
            }

            return resultBuilder.ToString().Trim();
        }
    }
}
//https://www.codewars.com/kata/571c1e847beb0a8f8900153d/train/csharp