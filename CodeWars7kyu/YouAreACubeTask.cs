using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class YouAreACubeTask
    {
        public static bool YouAreACube(int value)
        {
            for (int i = 0; i * i * i <= value; i++)
            {
                if (i * i * i == value)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
//https://www.codewars.com/kata/57da5365a82a1998440000a9/train/csharp