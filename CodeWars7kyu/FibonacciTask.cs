using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class FibonacciTask
	{
		public static int Fib(int n)
		{
			int actualNum = 2;
			int actualNum2 = 0;
			int iterator = 2;
			int fibonacciResult = 0;
			int fibonacciResult2 = 1;
			bool whatIsThePoint = true;

			if (n == 0) 
			{
				return fibonacciResult;
			}

			if (n == 1 || n == 2)
			{
				return 1;
			}


			while (iterator < n)
			{
				if (whatIsThePoint) 
				{
					fibonacciResult = actualNum + actualNum2;
					whatIsThePoint = false;

				}
				else
				{
					fibonacciResult2 = actualNum + actualNum2;
					whatIsThePoint = true;

				}

				actualNum = fibonacciResult2;
				actualNum2 = fibonacciResult;

				iterator++;
			}

			if (fibonacciResult > fibonacciResult2) 
			{
				return fibonacciResult;
			}
			else
			{
				return fibonacciResult2;
			}


		}
	}
}
//https://www.codewars.com/kata/57a1d5ef7cb1f3db590002af/train/csharp