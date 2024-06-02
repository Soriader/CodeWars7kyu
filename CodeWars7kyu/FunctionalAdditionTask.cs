using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class FunctionalAdditionTask
    {
        public static Func<double, double> Add(double n)
        {
            return x => x + n;
        }
    }
}
//https://www.codewars.com/kata/538835ae443aae6e03000547/train/csharp