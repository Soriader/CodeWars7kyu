﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class IsSquareTask
    {
        public static bool IsSquare(int n)
        {
            double squareRoot = Math.Sqrt(n);
            return squareRoot == (int)squareRoot;
        }
    }
}
//https://www.codewars.com/kata/54c27a33fb7da0db0100040e/train/csharp