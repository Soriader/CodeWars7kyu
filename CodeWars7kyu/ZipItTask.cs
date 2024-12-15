using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class ZipItTask
	{
		public static object[] ZipIt(object[] a, object[] b, Func<object, object, object> fn)
		{
			int length = Math.Min(a.Length, b.Length);

			object[] result = new object[length];

			for (int i = 0; i < length; i++)
			{
				result[i] = fn(a[i], b[i]);
			}

			return result;
		}
	}
}
//https://www.codewars.com/kata/56aaf25213edd3a88a000002/train/csharp