using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
	public class DrivingLicenceTask
	{
		public string Driver(params string[] data)
		{
			var surname = data[2].Length >= 5 ? data[2].Substring(0, 5).ToUpper() : data[2].ToUpper().PadRight(5, '9');
			var birthYear = data[3].Split('-')[2];
			var decade = birthYear[2].ToString(); 

			string monthOfBirth = "";
			var checkTheMonth = data[3].Split('-');
			string monthString = checkTheMonth[1].Length > 3 ? checkTheMonth[1].Substring(0, 3).ToUpper() : checkTheMonth[1].ToUpper();
			string monthNumber = DateTime.ParseExact(monthString, "MMM", System.Globalization.CultureInfo.InvariantCulture).Month.ToString("D2");

			if (data[4] == "F")
			{
				monthOfBirth = (int.Parse(monthNumber) + 50).ToString();
			}
			else
			{
				monthOfBirth = monthNumber;
			}

			var dateWithinTheMonthOfBirth = int.Parse(checkTheMonth[0]).ToString("D2");

			var theYearDigit = birthYear[3].ToString();

			var firstNameLetter = data[0].Substring(0, 1).ToUpper();
			var secondNameLetter = data[1].Length > 0 ? data[1].Substring(0, 1).ToUpper() : "9";

			var arbitraryDigit = "9";
			var checkDigits = "AA";
			return surname + decade + monthOfBirth + dateWithinTheMonthOfBirth + theYearDigit + firstNameLetter + secondNameLetter + arbitraryDigit + checkDigits;
		}
	}
}
//https://www.codewars.com/kata/586a1af1c66d18ad81000134/train/csharp