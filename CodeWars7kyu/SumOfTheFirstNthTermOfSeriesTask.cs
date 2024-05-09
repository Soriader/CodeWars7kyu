using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class SumOfTheFirstNthTermOfSeriesTask
    {
        public static string SeriesSum(int n)
        {
            if (n == 0) return "0.00";
            if (n == 1) return "1.00";
            double sum = 1.0; 
            double denominator = 4.0; 

            for (int i = 2; i <= n; i++)
            {
                sum += 1.0 / denominator; 
                denominator += 3.0; 
            }

            return sum.ToString("0.00").Replace(",", "."); 
        }
    }
}
//https://www.codewars.com/kata/555eded1ad94b00403000071/train/csharp
