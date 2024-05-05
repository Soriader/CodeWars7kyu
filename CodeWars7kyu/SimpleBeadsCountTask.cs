using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class SimpleBeadsCountTask
    {
        public static int CountRedBeads(int n)
        {
            if(n < 2) return 0;

            return (n - 1) * 2;


        }
    }
}
//https://www.codewars.com/kata/58712dfa5c538b6fc7000569/train/csharp

//2 - 2
//    3 - 4 
//    4 - 6
//    5 - 8
//    6 - 10 
//    7 - 12 