using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class LowercaseStringsInArrayTask
    {
        public static object[] ArrayLowerCase(object[] arr)
        {

            var newArr = arr.Select(x =>
            {
                if (x is string str)
                {
                    return (object)str.ToLower();
                }
                return x; 
            }).ToArray();

            return newArr;
        }
    }
}
//https://www.codewars.com/kata/5729fa716c7d26dc84000040/train/csharp