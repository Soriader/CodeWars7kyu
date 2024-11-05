using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class IsTuringEquationTask
	{
		public static bool IsTuringEquation(string str)
		{
			string[] parts = str.Split('=');
			string leftSide = parts[0];
			string result = parts[1].TrimStart('0'); ;

			string[] operands = leftSide.Split('+');
			string first = operands[0].TrimStart('0');
			string second = operands[1].TrimStart('0'); ; 

			var newFirst = new string(first.Reverse().ToArray()).TrimStart('0');
			var newSecond = new string(second.Reverse().ToArray()).TrimStart('0');
			var newResult = new string(result.Reverse().ToArray()).TrimStart('0');

			newFirst = string.IsNullOrEmpty(newFirst) ? "0" : newFirst;
			newSecond = string.IsNullOrEmpty(newSecond) ? "0" : newSecond;
			newResult = string.IsNullOrEmpty(newResult) ? "0" : newResult;

			var newFirstToInt = int.Parse(newFirst);
			var newSecondToInt = int.Parse(newSecond);
			var newResultToInt = int.Parse(newResult);

			return newFirstToInt + newSecondToInt == newResultToInt;

		}
	}
}
//https://www.codewars.com/kata/5a1e6323ffe75f71ae000026/train/csharp