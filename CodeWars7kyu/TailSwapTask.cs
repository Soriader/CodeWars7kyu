using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class TailSwapTask
	{
		public static string[] TailSwap(string[] arr)
		{
			List<string> result = new List<string>();

			string a = arr[0]; 
			string b = arr[1]; 

			var checkA = a.ToCharArray();
			var checkB = b.ToCharArray();

			var whereIsColonA = WhereIsColon(checkA);
			var whereIsColonB = WhereIsColon(checkB);

			string afterColonA = "";
			string afterColonB = "";

			for (int i = whereIsColonA + 1; i < a.Length; i++)
			{
				afterColonA += a[i];
			}

			for (int i = whereIsColonB + 1; i < b.Length; i++)
			{
				afterColonB+= b[i];
			}

			string resultA = "";
			string resultB = "";

			for (int i = 0; i < a.Length; i++)
			{
				if(i > whereIsColonA)
				{
					break;
				}

				resultA += a[i];
			}

			for (int i = 0; i < b.Length; i++)
			{
				if (i > whereIsColonB)
				{
					break;
				}

				resultB += b[i];
			}

			result.Add(resultA + afterColonB);
			result.Add(resultB + afterColonA);

			return result.ToArray();

		}

		public static int WhereIsColon(char[] x)
		{
			int colon = 0;

			for (int i = 0; i < x.Length; i++)
			{
				if (x[i] == ':')
				{
					colon = i;
				}
			}

			return colon;
		}
	}
}
//https://www.codewars.com/kata/5868812b15f0057e05000001/train/csharp
