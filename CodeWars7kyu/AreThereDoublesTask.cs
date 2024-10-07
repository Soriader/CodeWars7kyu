using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class AreThereDoublesTask
    {
		public static bool DoubleCheck(string strng) 
		{
			strng = strng.ToLower();

			for (int i = 0; i < strng.Length - 1; i++) 
			{
				if (strng[i] == strng[i + 1])
				{
					return true;
				}
			}
			return false;	
		}
		
	}
}
//https://www.codewars.com/kata/56a24b4d9f3671584d000039/train/csharp