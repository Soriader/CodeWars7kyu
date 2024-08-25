using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class MakingCopiesTask
	{
		public static List<T> Copy<T>(List<T> lst)
		{
			if (lst == null)
			{
				throw new ArgumentNullException(nameof(lst), "The list cannot be null.");
			}

			return new List<T>(lst);
		}
	}
}
//https://www.codewars.com/kata/53d2697b7152a5e13d000b82/train/csharp