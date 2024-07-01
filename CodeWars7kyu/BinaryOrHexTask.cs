using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodeWars7kyu
{
    public class BinaryOrHexTask
    {
        public static string EvensAndOdds(int num)
        {
            if(num%2 == 0)
            {
                return Convert.ToString(num, 2);
            }
            else
            {
                return Convert.ToString(num, 16);
            }

        }
    }
}
//https://www.codewars.com/kata/583ade15666df5a64e000058/train/csharp