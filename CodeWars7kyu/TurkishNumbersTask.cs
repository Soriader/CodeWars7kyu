using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class TurkishNumbersTask
	{
		public static string GetTurkishNumber(int num)
		{
			Dictionary<int, string> unit = new Dictionary<int, string>
	{
		{ 0, "sıfır" },
		{ 1, "bir" },
		{ 2, "iki" },
		{ 3, "üç" },
		{ 4, "dört" },
		{ 5, "beş" },
		{ 6, "altı" },
		{ 7, "yedi" },
		{ 8, "sekiz" },
		{ 9, "dokuz" }
	};

			Dictionary<int, string> tens = new Dictionary<int, string>
	{
		{ 10, "on" },
		{ 20, "yirmi" },
		{ 30, "otuz" },
		{ 40, "kırk" },
		{ 50, "elli" },
		{ 60, "altmış" },
		{ 70, "yetmiş" },
		{ 80, "seksen" },
		{ 90, "doksan" }
	};

			if (num < 10)
				return unit[num]; 

			if (num % 10 == 0)
				return tens[num];

			int tenPart = (num / 10) * 10; 
			int unitPart = num % 10; 

			return $"{tens[tenPart]} {unit[unitPart]}";

		}
	}
}
//https://www.codewars.com/kata/5ebd53ea50d0680031190b96/train/csharp