using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class PasswordSystemTask
	{
		public static string HelpZoom(int[] key)
		{
			int length = key.Length;

			int n = (int)Math.Sqrt(length);

			if (n * n != length)
			{
				return "No";
			}

			int[] firstHalf = new int[length / 2];
			int[] secondHalf = new int[length / 2];

			for (int i = 0; i < length / 2; i++)
			{
				firstHalf[i] = key[i];
				secondHalf[i] = key[length - 1 - i];
			}

			if (firstHalf.SequenceEqual(secondHalf))
			{
				return "Yes";
			}

			return "No";
		}
	}
}
//https://www.codewars.com/kata/57a23e3753ba332b8e0008da/train/csharp