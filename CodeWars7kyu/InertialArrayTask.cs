using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class InertialArrayTask
    {
        public static Boolean IsInertial(Int32[] arr) 
        { 
            if(arr.Max() % 2 != 0) 
            {
                return false;
            }

            bool haveEven = false;
            var evenNumbers = new List<int>();

            foreach (var i in arr) 
            {
                if(i % 2 != 0)
                {
                    haveEven = true;
                    evenNumbers.Add(i);
                }
            }

            if (!haveEven)
            {
                return false;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < evenNumbers.Count; j++)
                {
                    if (arr[i] > evenNumbers[j] && !evenNumbers.Contains(arr[i]) && arr[i] != arr.Max())
                    {
                        haveEven = false;
                    }
                }
            }

            if(haveEven == false)
            {
                return false;
            }

            return true;
        }

    }
}
//https://www.codewars.com/kata/59a151c53f64cdd94c00008f/train/csharp