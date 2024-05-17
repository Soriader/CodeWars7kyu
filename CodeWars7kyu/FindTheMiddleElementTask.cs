using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class FindTheMiddleElementTask
    {
        public static int Gimme(double[] inputArray)
        {
            double[] sortedArray = (double[])inputArray.Clone();

            Array.Sort(sortedArray);

            double middleValue = sortedArray[1];

            return Array.IndexOf(inputArray, middleValue);
        }
    }
}
//https://www.codewars.com/kata/545a4c5a61aa4c6916000755/train/csharp