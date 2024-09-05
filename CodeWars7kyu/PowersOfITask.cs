using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class PowersOfITask
	{
		public static string Pofi(int n)
		{
			switch (n % 4)
			{
				case 0:
					return "1";     
				case 1:
					return "i";     
				case 2:
					return "-1";    
				case 3:
					return "-i";    
			}

			return "1";

		}
	}
}
//https://www.codewars.com/kata/5a97387e5ee396e70a00016d/train/csharp