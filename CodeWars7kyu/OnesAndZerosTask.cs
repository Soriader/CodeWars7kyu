using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class OnesAndZerosTask
    {
        public static int binaryArrayToNumber(int[] BinaryArray)
        {
            int result = 0;

            for (int i = 0; i < BinaryArray.Length; i++)
            {
                if (BinaryArray[i] == 1)
                {
                    result += (int)Math.Pow(2, BinaryArray.Length - 1 - i);
                }

            }


            return result;
        }
    }
}
