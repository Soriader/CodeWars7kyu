using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class AcrosticReaderTask
	{
		public static string ReadOut(string[] acrostic)
		{
			return string.Concat(acrostic.Select(x => x.First()));
		}
	}
}
//https://www.codewars.com/kata/59b843b58bcb7766660000f6/train/csharp