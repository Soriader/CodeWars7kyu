using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public static class HeadTailInitLastTask
	{
		public static TSource Head<TSource>(this List<TSource> list)
		{
			return list.First();
		}

		public static List<TSource> Tail<TSource>(this List<TSource> list)
		{
			return list.Skip(1).ToList();
		}

		public static List<TSource> Init<TSource>(this List<TSource> list)
		{
			return list.Take(list.Count - 1).ToList();
		}

		public static TSource GetLast<TSource>(this List<TSource> list)
		{
			return list.Last();
		}
	}
}
//https://www.codewars.com/kata/54592a5052756d5c5d0009c3/train/csharp