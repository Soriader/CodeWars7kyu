using CodeWars7kyu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class SpecialNumberFiveTask
    {
        public static string SpecialNumber(int number)
        {
            var check = number.ToString().ToCharArray();


            foreach (var item in check)
            {
                var condition = item.ToString().Any(x => x == '0' || x == '1' || x == '2' || x == '3' || x == '4' || x == '5');

                if (condition == false)
                {
                    return "NOT!!";
                }
            }

            return "Special!!";
        }
    }
}
//https://www.codewars.com/kata/5a55f04be6be383a50000187/train/csharp