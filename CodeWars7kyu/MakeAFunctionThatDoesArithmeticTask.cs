using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class MakeAFunctionThatDoesArithmeticTask
    {
        public static double Arithmetic(double a, double b, string op)
        {

            switch (op)
            {
                case "add":
                    {
                        return a + b;
                    }
                case "subtract":
                    {
                        return a - b;
                    }
                case "divide":
                    {
                        return a / b;
                    }
                case "multiply":
                    {
                        return a * b;
                    }
                default:
                    {
                        throw new NotImplementedException();
                    }
            }
        }
    }
}
//https://www.codewars.com/kata/583f158ea20cfcbeb400000a/train/csharp