using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class SumofNumbersFrom0ToNTask
    {
        public static string ShowSequence(int n)
        {
            if(n == 0)
            {
                return "0=0";
            }

            if(n < 0)
            {
                return $"{n}<0";
            }

            int start = 0;
            int sum = 0;
            string result = "";

            while (start < n)
            {
                if(start == n) 
                {
                    break;
                }
                result += $"{start}+";
                start++;
                sum += start;
            }

            if (start == n)
            {
                result += $"{start} = {sum}";
            }

            return result;
        }
    }
}
//https://www.codewars.com/kata/56e9e4f516bcaa8d4f001763/train/csharp