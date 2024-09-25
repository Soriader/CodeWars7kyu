using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class RockPaperScissorsLizardSpockTask
	{
		public enum Value { Scissors, Paper, Rock, Lizard, Spock }
		public enum Ordering { LT, EQ, GT }

		public static Ordering Rpsls(Value a, Value b)
		{
			if (a == b)
			{
				return Ordering.EQ;
			}

			if ((a == Value.Scissors && (b == Value.Paper || b == Value.Lizard)) ||
			   (a == Value.Paper && (b == Value.Rock || b == Value.Spock)) ||
			   (a == Value.Rock && (b == Value.Scissors || b == Value.Lizard)) ||
			   (a == Value.Lizard && (b == Value.Spock || b == Value.Paper)) ||
			   (a == Value.Spock && (b == Value.Scissors || b == Value.Rock)))
			{
				return Ordering.GT;
			}

			return Ordering.LT;
		}
	}
}
//https://www.codewars.com/kata/57d29ccda56edb4187000052/train/csharp