using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class PaddedNumbersTask
    {
        public static string Solution(int value)
        {
            string result = "";
            int iterator = 0;

            if(value.ToString().Length != 5)
            {
                var addZero = 5 - value.ToString().Length;
                
                while(addZero != iterator)
                {
                    result += "0";
                    iterator++;
                }
            }

            return $"Value is {result + value}";
        }
    }
}
//https://www.codewars.com/kata/51c89385ee245d7ddf000001/train/csharp