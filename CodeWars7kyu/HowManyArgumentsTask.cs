using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class HowManyArgumentsTask
    {

        public static int CountArgs(params object[] args)
        {
            //return args.Length;
            return args.Count();
        }
    }
}
//https://www.codewars.com/kata/5c44b0b200ce187106452139/train/csharp