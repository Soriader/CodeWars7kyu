using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class SortAndTransformTask
	{
		public static string SortTransform(int[] arr)
		{
			List<int> numbers = new List<int>(arr);

			var firstResult = numbers.Select((value, index) => new { value, index }) 
			.Where(x => x.index == 0 || x.index == 1 || x.index == numbers.Count - 2 || x.index == numbers.Count - 1)
			.Select(x => x.value)
			.SelectMany(x => new[] { x }).Select(n => (char)n).ToList();

			var secondResult = numbers.OrderBy(x => x).Select((value, index) => new { value, index })
			.Where(x => x.index == 0 || x.index == 1 || x.index == numbers.Count - 2 || x.index == numbers.Count - 1)
			.Select(x => x.value)
			.SelectMany(x => new[] { x }).Select(n => (char)n).ToList();

			var thirdResult = numbers.OrderByDescending(x => x).Select((value, index) => new { value, index })
			.Where(x => x.index == 0 || x.index == 1 || x.index == numbers.Count - 2 || x.index == numbers.Count - 1)
			.Select(x => x.value)
			.SelectMany(x => new[] { x }).Select(n => (char)n).ToList();

			var asciiChars = numbers.Select(n => (char)n).ToList();
			var sortedChars = asciiChars.OrderBy(c => c).ToList();

			var fourthResult = sortedChars
				.Where((value, index) => index == 0 || index == 1 || index == sortedChars.Count - 2 || index == sortedChars.Count - 1)
				.ToList();

			string result = "";

			foreach (var x in firstResult)
			{
				result += x.ToString();
			}
			result += "-";
			foreach (var x in secondResult) 
			{ 
				result += x.ToString(); 
			}
			result += "-";
			foreach (var x in thirdResult) 
			{ 
				result += x.ToString(); 
			}
			result += "-";

			foreach (var x in fourthResult) 
			{ 
				result += x.ToString();
			}

			return result;
		}
	}
}
//https://www.codewars.com/kata/57cc847e58a06b1492000264/train/csharp


//alternative
//public static string SortTransform(int[] arr)
//{
//	List<int> numbers = new List<int>(arr);

//	var firstResult = numbers.Where((_, index) => index == 0 || index == 1 || index == numbers.Count - 2 || index == numbers.Count - 1)
//							 .Select(n => (char)n);

//	var secondResult = numbers.OrderBy(x => x)
//							  .Where((_, index) => index == 0 || index == 1 || index == numbers.Count - 2 || index == numbers.Count - 1)
//							  .Select(n => (char)n);

//	var thirdResult = numbers.OrderByDescending(x => x)
//							 .Where((_, index) => index == 0 || index == 1 || index == numbers.Count - 2 || index == numbers.Count - 1)
//							 .Select(n => (char)n);

//	var fourthResult = numbers.Select(n => (char)n)
//							  .OrderBy(c => c)
//							  .Where((_, index) => index == 0 || index == 1 || index == numbers.Count - 2 || index == numbers.Count - 1);

//	string result = string.Join("-",
//		string.Concat(firstResult),
//		string.Concat(secondResult),
//		string.Concat(thirdResult),
//		string.Concat(fourthResult)
//	);

//	return result;
//}
