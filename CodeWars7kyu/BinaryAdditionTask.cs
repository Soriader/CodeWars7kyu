﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class BinaryAdditionTask
    {
        public static string AddBinary(int a, int b)
        {
            int sum = a + b;
            string binary = Convert.ToString(sum, 2);
            return binary;
        }
    }
}
//https://www.codewars.com/kata/551f37452ff852b7bd000139/train/csharp