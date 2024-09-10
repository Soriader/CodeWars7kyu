using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace CodeWars7kyu
{
	public class WhatIsMyGolfScoreTask
	{
		public static int GolfScoreCalculator(string par, string score)
		{
			var oneScore = score.ToCharArray();
			var onePar = par.ToCharArray();

			int result = 0;

			for (int i = 0; i < oneScore.Length; i++)
			{
				result += (oneScore[i] - '0') - (onePar[i] - '0');
			}
			return result;

		}
	}
}
//https://www.codewars.com/kata/59f7a0a77eb74bf96b00006a/train/csharp