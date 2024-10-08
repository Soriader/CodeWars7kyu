using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodeWars7kyu
{
    public class SharedBitCounterTask
    {
		public static bool SharedBits(int a, int b)
		{
			string aToBit = Convert.ToString(a, 2).PadLeft(32, '0');
			string bToBit = Convert.ToString(b, 2).PadLeft(32, '0');

			int iterator = 0;

			for (int i = 0; i < aToBit.Length; i++)
			{
				if (aToBit[i] == '1' && bToBit[i] == '1')
				{
					iterator++;
				}
			}

			return iterator >= 2;
		}
	}
}
//https://www.codewars.com/kata/58a5aeb893b79949eb0000f1/train/csharp