using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class NaughtyOrNiceTask
	{
		public string Name { get; set; }
		public bool WasNice { get; set; }

		public NaughtyOrNiceTask(string name, bool wasNice)
		{
			Name = name;
			WasNice = wasNice;
		}

		public static IEnumerable<string> GetNiceNames(IEnumerable<NaughtyOrNiceTask> people)
		{
			return people.Where(x => x.WasNice).Select(x => x.Name);

		}

		public static IEnumerable<string> GetNaughtyNames(IEnumerable<NaughtyOrNiceTask> people)
		{
			return people.Where(x => !x.WasNice).Select(x => x.Name);
		}
	}
}
//https://www.codewars.com/kata/52a6b34e43c2484ac10000cd/train/csharp