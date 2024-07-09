using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class ReverseTheBitsTask
    {
        public static long ReverseBits(long n)
        {
            string binaryString = Convert.ToString(n, 2);

            char[] binaryArray = binaryString.ToCharArray();

            Array.Reverse(binaryArray);

            string reversedBinaryString = new string(binaryArray);

            long reversedNumber = Convert.ToInt64(reversedBinaryString, 2);

            return reversedNumber;
        }
    }
}
//https://www.codewars.com/kata/5959ec605595565f5c00002b/train/csharp