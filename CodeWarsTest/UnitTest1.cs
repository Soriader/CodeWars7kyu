using CodeWars7kyu;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Reflection;
using System.Text;
using static CodeWars7kyu.DisemvowelTrollsTask;

namespace CodeWarsTest
{
    public class Tests
    {

        [TestFixture]
        public class KataTest
        {
			public class Tests
            {
                [Test]
                public void PredictYourAgeTest()
                {
                    Assert.AreEqual(86, PredictYourAgeTask.PredictAge(65, 60, 75, 55, 60, 63, 64, 45));
                    Assert.AreEqual(79, PredictYourAgeTask.PredictAge(32, 54, 76, 65, 34, 63, 64, 45));
                }

                [Test]
                public void ConvertAnArrayOfStringsToArrayOfNumbersTest()
                {
                    Assert.AreEqual(new double[] { 1.1, 2.2, 3.3 }, ConvertAnArrayOfStringsToArrayOfNumbersTask.ToDoubleArray(new string[] { "1.1", "2.2", "3.3" }));

                }

                [Test]
                public void SwitcherooTest()
                {
                    Assert.AreEqual("bac", SwitcherooTask.Switcheroo("abc"));
                    Assert.AreEqual("bbbacccabbb", SwitcherooTask.Switcheroo("aaabcccbaaa"));
                    Assert.AreEqual("ccccc", SwitcherooTask.Switcheroo("ccccc"));
                }

                [Test]
                public static void PartsOfAListTest()
                {
                    String[] s1 = new String[] { "cdIw", "tzIy", "xDu", "rThG" };
                    string[][] expected = new string[][] 
                    {
    
                        new string[] { "cdIw", "tzIy xDu rThG" },
    
                        new string[] { "cdIw tzIy", "xDu rThG" },
    
                        new string[] { "cdIw tzIy xDu", "rThG" }

                    };
                    CollectionAssert.AreEqual(expected, PartsOfAListTask.Partlist(s1));
                }

                [Test]
                public void LargestPairSumInArrayTest()
                {
                    Assert.AreEqual(-16, LargestPairSumInArrayTask.LargestPairSum(new int[] { -8, -8, -16, -18, -19 }));
                    Assert.AreEqual(0, LargestPairSumInArrayTask.LargestPairSum(new int[] { -100, -29, -24, -19, 19 }));
                    Assert.AreEqual(10, LargestPairSumInArrayTask.LargestPairSum(new int[] { 1, 2, 3, 4, 6, -1, 2 }));
                    Assert.AreEqual(42, LargestPairSumInArrayTask.LargestPairSum(new int[] { 10, 14, 2, 23, 19 }));
                }

                [Test]
                public void OddOrEvenTest()
                {
                    Assert.AreEqual("even", OddOrEvenTask.OddOrEven(new int[] { 0 }));
                    Assert.AreEqual("odd", OddOrEvenTask.OddOrEven(new int[] { 1 }));
                    Assert.AreEqual("even", OddOrEvenTask.OddOrEven(new int[] { }));
                }

                [Test]
				public void DeodorantEvaporatorTest()
				{
					Assert.AreEqual(22, DeodorantEvaporatorTask.Evaporator(10, 10, 10));
				}
				[Test]
				public void BuildASquareTest()
				{
					Assert.AreEqual("", BuildASquareTask.GenerateShape(0));
					Assert.AreEqual("+", BuildASquareTask.GenerateShape(1));
					Assert.AreEqual("++\n++", BuildASquareTask.GenerateShape(2));
					Assert.AreEqual("+++\n+++\n+++", BuildASquareTask.GenerateShape(3));
				}

				[Test]
				public void MostDigitsTest()
				{
					Assert.AreEqual(100, MostDigitsTask.FindLongest(new int[] { 1, 10, 100 }));
					Assert.AreEqual(9000, MostDigitsTask.FindLongest(new int[] { 9000, 8, 800 }));
					Assert.AreEqual(900, MostDigitsTask.FindLongest(new int[] { 8, 900, 500 }));
				}

				[Test]
				public void AlphabetWarTest()
				{
					Assert.AreEqual("Right side wins!", AlphabetWarTask.AlphabetWar("z"));
					Assert.AreEqual("Let's fight again!", AlphabetWarTask.AlphabetWar("zdqmwpbs"));
					Assert.AreEqual("Right side wins!", AlphabetWarTask.AlphabetWar("zzzzs"));
					Assert.AreEqual("Left side wins!", AlphabetWarTask.AlphabetWar("wwwwwwz"));
				}

				[Test]
                public void PowerOfTwoTest()
                {
                    Assert.AreEqual(true, PowerOfTwoTask.PowerOfTwo(4096));
                    Assert.AreEqual(true, PowerOfTwoTask.PowerOfTwo(2));
                    Assert.AreEqual(false, PowerOfTwoTask.PowerOfTwo(9));

                }

                [Test]
                public void SumofNumbersFrom0ToNTest()
                {
                    Assert.AreEqual("0+1+2+3+4+5+6 = 21", SumofNumbersFrom0ToNTask.ShowSequence(6));
                    Assert.AreEqual("-5<0", SumofNumbersFrom0ToNTask.ShowSequence(-5));
                    Assert.AreEqual("0=0", SumofNumbersFrom0ToNTask.ShowSequence(0));
                }

                [Test]
                public void MaximumProductTest()
                {
                    Assert.AreEqual(200, MaximumProductTask.AdjacentElementsProduct(new int[] { 40, 5, 8 }));
                    Assert.AreEqual(6, MaximumProductTask.AdjacentElementsProduct(new int[] { 6, 1, 2, 3, 0 }));
                    Assert.AreEqual(-14, MaximumProductTask.AdjacentElementsProduct(new int[] { -23, 4, -5, 99, -27, 329, -2, 7, -921 }));

                }

                [Test]
                public void SortArrayByStringLengthTest()
                {
                    Assert.AreEqual(new string[] { "I", "To", "Beg", "Life" }, SortArrayByStringLengthTask.SortByLength(new string[] { "Beg", "Life", "I", "To" }));
                    Assert.AreEqual(new string[] { "", "Pizza", "Brains", "Moderately" }, SortArrayByStringLengthTask.SortByLength(new string[] { "", "Moderately", "Brains", "Pizza" }));
                    Assert.AreEqual(new string[] { "Short", "Longer", "Longest" }, SortArrayByStringLengthTask.SortByLength(new string[] { "Longer", "Longest", "Short" }));
                }

                [Test]
                public void NoOdditiesHereTest()
                {
                    Assert.AreEqual(new int[] { 2, 4 }, NoOdditiesHereTask.NoOdds(new int[] { 1, 2, 3, 4, 5 }));
                }
                [Test]
                public void BumpsInTheRoadTest()
                {
                    Assert.AreEqual("Woohoo!", BumpsInTheRoadTask.Bump("n"));
                    Assert.AreEqual("Woohoo!", BumpsInTheRoadTask.Bump("nnn_n__n_n___nnnnn___n__nnn__"));
                    Assert.AreEqual("Car Dead", BumpsInTheRoadTask.Bump("_nnnnnnn_n__n______nn__nn_nnn"));
                    Assert.AreEqual("Car Dead", BumpsInTheRoadTask.Bump("nnnn____nnnnnn___nnnnnnnn_____nnnnnnn"));

                }
                [Test]
                public void JavaScriptArrayFilterTest()
                {
                    Assert.AreEqual(new int[] { 2 }, JavaScriptArrayFilterTask.GetEvenNumbers(new int[] { 1, 2 }));
                    Assert.AreEqual(new int[] { 2, 6, 8, 10 }, JavaScriptArrayFilterTask.GetEvenNumbers(new int[] { 2, 6, 8, 10 }));
                    Assert.AreEqual(new int[] { 12, 14 }, JavaScriptArrayFilterTask.GetEvenNumbers(new int[] { 12, 14, 15 }));
                    Assert.AreEqual(new int[] { }, JavaScriptArrayFilterTask.GetEvenNumbers(new int[] { 1, 3, 9 }));

                }

                [Test]
                public void AlanPartridgeIIILondonTest()
                {
                    Assert.AreEqual("Smell my cheese you mother!", AlanPartridgeIIILondonTask.Alan(new string[] { "Norwich", "Rejection", "Disappointment", "Backstabbing Central", "Shattered Dreams Parkway", "London" }));
                    Assert.AreEqual("No, seriously, run. You will miss it.", AlanPartridgeIIILondonTask.Alan(new string[] { "London", "Norwich" }));
                    Assert.AreEqual("Smell my cheese you mother!", AlanPartridgeIIILondonTask.Alan(new string[] { "Norwich", "Tooting", "Bank", "Rejection", "Disappointment", "Backstabbing Central", "Exeter", "Shattered Dreams Parkway", "Belgium", "London" }));
                }

                [Test]
                public void AnagramDetectionTest()
                {
                    Assert.AreEqual(true, AnagramDetectionTask.IsAnagram("foefet", "toffee"));
                    Assert.AreEqual(true, AnagramDetectionTask.IsAnagram("Buckethead", "DeathCubeK"));
                    Assert.AreEqual(true, AnagramDetectionTask.IsAnagram("Twoo", "Woot"));
                    Assert.AreEqual(false, AnagramDetectionTask.IsAnagram("apple", "pale"));

                }

                [Test]
                public void PartridgeWatchTest()
                {
                    Assert.AreEqual("Mine's a Pint!", PartridgeWatchTask.Part(new String[] { "Grouse", "Partridge", "Pheasant" }));
                    Assert.AreEqual("Mine's a Pint!!!!!!!!", PartridgeWatchTask.Part(new String[] { "Grouse", "Partridge", "Pheasant", "Goose", "Starling", "Robin", "Thrush", "Emu", "PearTree", "Chat", "Dan", "Square", "Toblerone", "Lynn", "AlphaPapa", "BMW", "Graham", "Tool", "Nomad", "Finger", "Hamster" }));
                    Assert.AreEqual("Lynn, I've pierced my foot on a spike!!", PartridgeWatchTask.Part(new string[] { "Pheasant", "Goose", "Starling", "Robin" }));
                }

                [Test]
                public static void TheCouponCodeTest()
                {
                    Assert.AreEqual(true, TheCouponCodeTask.CheckCoupon("123", "123", "September 5, 2014", "October 1, 2014"));
                    Assert.AreEqual(false, TheCouponCodeTask.CheckCoupon("123a", "123", "September 5, 2014", "October 1, 2014"));

                }

                [Test]
                public void SortedYesOrNoTest()
                {
                    Assert.AreEqual("yes, ascending", SortedYesOrNoTask.IsSortedAndHow(new[] { 1, 2 }));
                    Assert.AreEqual("yes, descending", SortedYesOrNoTask.IsSortedAndHow(new[] { 15, 7, 3, -8 }));
                    Assert.AreEqual("no", SortedYesOrNoTask.IsSortedAndHow(new[] { 4, 2, 30 }));
                }

                [Test]
                public void RowSumOddNumbersTest()
                {
                    Assert.AreEqual(1, SumOfOddNumbersTask.RowSumOddNumbers(1));
                    Assert.AreEqual(74088, SumOfOddNumbersTask.RowSumOddNumbers(42));
                }

                [Test]
                public void ReverseLetterTest()
                {
                    Assert.AreEqual("nahsirk", ReverseLetterTask.ReverseLetter("krishan"));

                    Assert.AreEqual("nortlu", ReverseLetterTask.ReverseLetter("ultr53o?n"));

                    Assert.AreEqual("cba", ReverseLetterTask.ReverseLetter("ab23c"));

                    Assert.AreEqual("nahsirk", ReverseLetterTask.ReverseLetter("krish21an"));

                }

                [Test]
                public void MultipleOf5Test()
                {
                    Assert.AreEqual(0, MultipleOf5Task.RoundToNext5(0));
                    Assert.AreEqual(5, MultipleOf5Task.RoundToNext5(1));
                    Assert.AreEqual(5, MultipleOf5Task.RoundToNext5(3));
                    Assert.AreEqual(5, MultipleOf5Task.RoundToNext5(5));
                    Assert.AreEqual(10, MultipleOf5Task.RoundToNext5(7));
                    Assert.AreEqual(40, MultipleOf5Task.RoundToNext5(39));

                }


                [Test]
                public void CreateFactorialmethodTest()
                {
                    Assert.AreEqual(1, CreateFactorialmethodTask.Factorial(0));
                    Assert.AreEqual(1, CreateFactorialmethodTask.Factorial(1));
                    Assert.AreEqual(2, CreateFactorialmethodTask.Factorial(2));
                    Assert.AreEqual(6, CreateFactorialmethodTask.Factorial(3));
                    Assert.AreEqual(24, CreateFactorialmethodTask.Factorial(4));
                    Assert.AreEqual(120, CreateFactorialmethodTask.Factorial(5));
                }

                [Test]
                public void FindTheCapitalsTest()
                {
                    Assert.AreEqual(FindTheCapitalsTask.Capitals("CodEWaRs"), new int[] { 0, 3, 4, 6 });
                }

                [Test]
                public void SumOfAnglesTest()
                {
                    Assert.AreEqual(180, SumOfAnglesTask.Angle(3));
                    Assert.AreEqual(360, SumOfAnglesTask.Angle(4));
                }

                [Test]
                public void SumOfASequenceTest()
                {
                    Assert.AreEqual(12, SumOfASequenceTask.SequenceSum(2, 6, 2));
                    Assert.AreEqual(15, SumOfASequenceTask.SequenceSum(1, 5, 1));
                    Assert.AreEqual(5, SumOfASequenceTask.SequenceSum(1, 5, 3));
                    Assert.AreEqual(45, SumOfASequenceTask.SequenceSum(0, 15, 3));
                    Assert.AreEqual(0, SumOfASequenceTask.SequenceSum(16, 15, 3));
                    Assert.AreEqual(26, SumOfASequenceTask.SequenceSum(2, 24, 22));
                    Assert.AreEqual(2, SumOfASequenceTask.SequenceSum(2, 2, 2));
                    Assert.AreEqual(2, SumOfASequenceTask.SequenceSum(2, 2, 1));
                    Assert.AreEqual(35, SumOfASequenceTask.SequenceSum(1, 15, 3));
                    Assert.AreEqual(0, SumOfASequenceTask.SequenceSum(15, 1, 3));
                }

                [Test]
                public void SumOfMinimumsTest()
                {
                    Assert.AreEqual(26, SumOfMinimumsTask.SumOfMinimums(new int[3, 5] { { 1, 2, 3, 4, 5 }, { 5, 6, 7, 8, 9 }, { 20, 21, 34, 56, 100 } }));
                    Assert.AreEqual(9, SumOfMinimumsTask.SumOfMinimums(new int[3, 5] { { 7, 9, 8, 6, 2 }, { 6, 3, 5, 4, 3 }, { 5, 8, 7, 4, 5 } }));
                    Assert.AreEqual(76, SumOfMinimumsTask.SumOfMinimums(new int[4, 4] { { 11, 12, 14, 54 }, { 67, 89, 90, 56 }, { 7, 9, 4, 3 }, { 9, 8, 6, 7 } }));
                }

                [Test]
                public void ShortestWordTest()
                {
                    Assert.AreEqual(3, ShortestWordTask.FindShort("bitcoin take over the world maybe who knows perhaps"));
                    Assert.AreEqual(3, ShortestWordTask.FindShort("turns out random test cases are easier than writing out basic ones"));
                    Assert.AreEqual(2, ShortestWordTask.FindShort("Let's travel abroad shall we"));
                }

                [Test]
                public void AlternateCapitalizationTest()
                {
                    Assert.AreEqual(new string[2] { "AbCdEf", "aBcDeF" }, AlternateCapitalizationTask.Capitalize("abcdef"));
                    Assert.AreEqual(new string[2] { "CoDeWaRs", "cOdEwArS" }, AlternateCapitalizationTask.Capitalize("codewars"));
                    Assert.AreEqual(new string[2] { "AbRaCaDaBrA", "aBrAcAdAbRa" }, AlternateCapitalizationTask.Capitalize("abracadabra"));
                    Assert.AreEqual(new string[2] { "CoDeWaRrIoRs", "cOdEwArRiOrS" }, AlternateCapitalizationTask.Capitalize("codewarriors"));
                }

                [Test]
                public void TwoFightersOneWinnerTest()
                {
                    Assert.AreEqual("Lew", TwoFightersOneWinnerTask.DeclareWinner(new TwoFightersOneWinnerTask.Fighter("Lew", 10, 2), new TwoFightersOneWinnerTask.Fighter("Harry", 5, 4), "Lew"));
                    Assert.AreEqual("Harry", TwoFightersOneWinnerTask.DeclareWinner(new TwoFightersOneWinnerTask.Fighter("Lew", 10, 2), new TwoFightersOneWinnerTask.Fighter("Harry", 5, 4), "Harry"));
                    Assert.AreEqual("Harald", TwoFightersOneWinnerTask.DeclareWinner(new TwoFightersOneWinnerTask.Fighter("Harald", 20, 5), new TwoFightersOneWinnerTask.Fighter("Harry", 5, 4), "Harry"));
                    Assert.AreEqual("Harald", TwoFightersOneWinnerTask.DeclareWinner(new TwoFightersOneWinnerTask.Fighter("Harald", 20, 5), new TwoFightersOneWinnerTask.Fighter("Harry", 5, 4), "Harald"));
                    Assert.AreEqual("Harald", TwoFightersOneWinnerTask.DeclareWinner(new TwoFightersOneWinnerTask.Fighter("Jerry", 30, 3), new TwoFightersOneWinnerTask.Fighter("Harald", 20, 5), "Jerry"));
                    Assert.AreEqual("Harald", TwoFightersOneWinnerTask.DeclareWinner(new TwoFightersOneWinnerTask.Fighter("Jerry", 30, 3), new TwoFightersOneWinnerTask.Fighter("Harald", 20, 5), "Harald"));

                }

                [Test]
                public static void PerfectSquareTest()
                {
                    Assert.AreEqual(-1, PerfectSquareTask.FindNextSquare(155));
                    Assert.AreEqual(144, PerfectSquareTask.FindNextSquare(121));
                    Assert.AreEqual(676, PerfectSquareTask.FindNextSquare(625));
                    Assert.AreEqual(320356, PerfectSquareTask.FindNextSquare(319225));
                }

                [Test]
                public void SumDigitsTest()
                {
                    Assert.AreEqual(1, SumDigitsTask.SumDigits(10));
                    Assert.AreEqual(18, SumDigitsTask.SumDigits(99));
                    Assert.AreEqual(5, SumDigitsTask.SumDigits(-32));

                }

                [Test]
                public void FixStringCaseTest()
                {
                    Assert.AreEqual("code", FixStringCaseTask.Solve("code"));
                    Assert.AreEqual("CODE", FixStringCaseTask.Solve("CODe"));
                    Assert.AreEqual("code", FixStringCaseTask.Solve("COde"));
                    Assert.AreEqual("code", FixStringCaseTask.Solve("Code"));

                }

                [Test]
                public void FormTheMinimumTest()
                {
                    Assert.AreEqual(13, FormTheMinimumTask.MinValue(new int[] { 1, 3, 1 }));
                    Assert.AreEqual(457, FormTheMinimumTask.MinValue(new int[] { 4, 7, 5, 7 }));
                    Assert.AreEqual(148, FormTheMinimumTask.MinValue(new int[] { 4, 8, 1, 4 }));
                    Assert.AreEqual(579, FormTheMinimumTask.MinValue(new int[] { 5, 7, 9, 5, 7 }));
                }


                [Test]
                public void FactorialTest()
                {
                    Assert.AreEqual(1, FactorialTask.Factorial(0));
                    Assert.AreEqual(1, FactorialTask.Factorial(1));
                    Assert.AreEqual(2, FactorialTask.Factorial(2));
                    Assert.AreEqual(6, FactorialTask.Factorial(3));
                }

                [Test]
                public void CheckTheExamTest()
                {
                    Assert.AreEqual(7, CheckTheExamTask.CheckExam(new string[] { "a", "a", "c", "b" }, new string[] { "a", "a", "b", "" }));
                    Assert.AreEqual(6, CheckTheExamTask.CheckExam(new string[] { "a", "a", "b", "b" }, new string[] { "a", "c", "b", "d" }));
                    Assert.AreEqual(0, CheckTheExamTask.CheckExam(new string[] { "b", "c", "b", "a" }, new string[] { "", "a", "a", "c" }));
                }

                [Test]
                public void RemoveAnchorFromURLTest()
                {
                    Assert.AreEqual("www.codewars.com", RemoveAnchorFromURLTask.RemoveUrlAnchor("www.codewars.com#about"));
                    Assert.AreEqual("www.codewars.com/katas/?page=1", RemoveAnchorFromURLTask.RemoveUrlAnchor("www.codewars.com/katas/?page=1#about"));
                    Assert.AreEqual("www.codewars.com/katas/", RemoveAnchorFromURLTask.RemoveUrlAnchor("www.codewars.com/katas/"));
                }


                [Test]
                public void JadenCasingStringTest()
                {
                    Assert.AreEqual("How Can Mirrors Be Real If Our Eyes Aren't Real", JadenCasingStringTask.ToJadenCase("How can mirrors be real if our eyes aren't real"));
                }
                [Test]
                public void SmallEnoughTest()
                {
                    Assert.AreEqual(true, SmallEnoughTask.SmallEnough(new int[] { 66, 101 }, 200));
                    Assert.AreEqual(false, SmallEnoughTask.SmallEnough(new int[] { 78, 117, 110, 99, 104, 117, 107, 115 }, 100));
                    Assert.AreEqual(true, SmallEnoughTask.SmallEnough(new int[] { 101, 45, 75, 105, 99, 107 }, 107));
                    Assert.AreEqual(true, SmallEnoughTask.SmallEnough(new int[] { 80, 117, 115, 104, 45, 85, 112, 115 }, 120));
                }

                [Test]
                public void TestingNumerationTest()
                {
                    Assert.AreEqual(new List<string>(), TestingNumerationTask.Number(new List<string>()));
                    Assert.AreEqual(new List<string> { "1: a", "2: b", "3: c" }, TestingNumerationTask.Number(new List<string> { "a", "b", "c" }));
                    Assert.AreEqual(new List<string> { "1: ", "2: ", "3: ", "4: ", "5: " }, TestingNumerationTask.Number(new List<string> { "", "", "", "", "" }));
                }


                [Test]
                public void SquareEveryDigitTest()
                {
                    Assert.AreEqual(811181, SquareEveryDigitTask.SquareDigits(9119));
                    Assert.AreEqual(0, SquareEveryDigitTask.SquareDigits(0));
                }


                [Test]
                public void MoneyTest()
                {
                    Assert.AreEqual(0, MoneyTask.CalculateYears(1000, 0.05, 0.18, 1000));
                    Assert.AreEqual(14, MoneyTask.CalculateYears(1000, 0.01625, 0.18, 1200));

                }

                [Test]
                public void SortNumbersTest()
                {
                    Assert.AreEqual(new int[] { 1, 2, 3, 5, 10 }, SortNumbersTask.SortNumbers(new int[] { 1, 2, 3, 10, 5 }));
                    Assert.AreEqual(new int[] { }, SortNumbersTask.SortNumbers(new int[] { }));
                    Assert.AreEqual(new int[] { 2, 10, 20 }, SortNumbersTask.SortNumbers(new int[] { 20, 2, 10 }));
                    Assert.AreEqual(new int[] { 1, 2, 3, 5, 10 }, SortNumbersTask.SortNumbers(new int[] { 1, 2, 3, 10, 5 }));
                    Assert.AreEqual(new int[] { 1, 2, 3, 5, 10 }, SortNumbersTask.SortNumbers(new int[] { 1, 2, 3, 10, 5 }));
                }

                [Test]
                public void ExesAndOhsTest()
                {
                    Assert.AreEqual(true, ExesAndOhsTask.XO("xo"));
                    Assert.AreEqual(true, ExesAndOhsTask.XO("xxOo"));
                    Assert.AreEqual(false, ExesAndOhsTask.XO("xxxm"));
                    Assert.AreEqual(false, ExesAndOhsTask.XO("Oo"));
                    Assert.AreEqual(false, ExesAndOhsTask.XO("ooom"));
                }

                [Test]
                public void PeopleInTheBusTest()
                {

                    Assert.AreEqual(5, PeopleInTheBusTask.Number(new List<int[]>() { new[] { 10, 0 }, new[] { 3, 5 }, new[] { 5, 8 } }));
                    Assert.AreEqual(17, PeopleInTheBusTask.Number(new List<int[]>() { new[] { 3, 0 }, new[] { 9, 1 }, new[] { 4, 10 }, new[] { 12, 2 }, new[] { 6, 1 }, new[] { 7, 10 } }));
                    Assert.AreEqual(21, PeopleInTheBusTask.Number(new List<int[]>() { new[] { 3, 0 }, new[] { 9, 1 }, new[] { 4, 8 }, new[] { 12, 2 }, new[] { 6, 1 }, new[] { 7, 8 } }));
                }

                [Test]
                public static void TwoToOneSortedStringTest()
                {
                    Assert.AreEqual("aehrsty", TwoToOneSortedStringTask.Longest("aretheyhere", "yestheyarehere"));
                    Assert.AreEqual("abcdefghilnoprstu", TwoToOneSortedStringTask.Longest("loopingisfunbutdangerous", "lessdangerousthancoding"));
                    Assert.AreEqual("acefghilmnoprstuy", TwoToOneSortedStringTask.Longest("inmanylanguages", "theresapairoffunctions"));
                }

                [Test]
                public void SumOfNumbersInSequenceTest()
                {
                    Assert.AreEqual(1, SumOfNumbersInSequenceTask.GetSum(0, 1));
                    Assert.AreEqual(-1, SumOfNumbersInSequenceTask.GetSum(0, -1));
                }


                [Test]
                public void FindTheStrayNumberTest()
                {
                    Assert.AreEqual(2, FindTheStrayNumberTask.Stray(new int[] { 1, 1, 2 }));
                }

                [Test]
                public void ListFilteringTest()
                {
                    var list = new List<object>() { 1, 2, "a", "b" };
                    var expected = new List<int>() { 1, 2 };
                    var actual = ListFilteringTask.GetIntegersFromList(list);
                    Assert.IsTrue(expected.SequenceEqual(actual));
                }

                [Test]
                public static void GrowthOfAPopulationTest()
                {
                    Assert.AreEqual(15, GrowthOfAPopulationTask.NbYear(1500, 5, 100, 5000));
                    Assert.AreEqual(10, GrowthOfAPopulationTask.NbYear(1500000, 2.5, 10000, 2000000));
                    Assert.AreEqual(94, GrowthOfAPopulationTask.NbYear(1500000, 0.25, 1000, 2000000));
                }

                [Test]
                public void HighestAndLowestTest()
                {
                    Assert.AreEqual("42 -9", HighestAndLowestTask.HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));
                    Assert.AreEqual("3 1", HighestAndLowestTask.HighAndLow("1 2 3"));

                }

                [Test]
                public static void RemoveTheMinimumTest()
                {
                    Assert.AreEqual(new List<int> { 2, 3, 4, 5 }, RemoveTheMinimumTask.RemoveSmallest(new List<int> { 1, 2, 3, 4, 5 }));
                    Assert.AreEqual(new List<int> { 5, 3, 2, 4 }, RemoveTheMinimumTask.RemoveSmallest(new List<int> { 5, 3, 2, 1, 4 }));
                    Assert.AreEqual(new List<int> { 2, 3, 1, 1 }, RemoveTheMinimumTask.RemoveSmallest(new List<int> { 1, 2, 3, 1, 1 }));
                    Assert.AreEqual(new List<int>(), RemoveTheMinimumTask.RemoveSmallest(new List<int>()));
                }

                [Test]
                public void SumTwoSmallestNumbersTest()
                {
                    Assert.AreEqual(13, SumTwoSmallestNumbersTask.SumTwoSmallestNumbers(new int[] { 5, 8, 12, 19, 22 }));
                    Assert.AreEqual(7, SumTwoSmallestNumbersTask.SumTwoSmallestNumbers(new int[] { 19, 5, 42, 2, 77 }));
                    Assert.AreEqual(3453455, SumTwoSmallestNumbersTask.SumTwoSmallestNumbers(new int[] { 10, 343445353, 3453445, 2147483647 }));
                }

                [Test]
                public void BinaryAdditionTest()
                {
                    Assert.AreEqual("11", BinaryAdditionTask.AddBinary(1, 2), "Should return \"11\" for 1 + 2");
                }

                [Test]
                public void DescendingOrderTest()
                {
                    Assert.AreEqual(0, DescendingOrderTask.DescendingOrder(0));
                    Assert.AreEqual(54421, DescendingOrderTask.DescendingOrder(42145));
                    Assert.AreEqual(987654321, DescendingOrderTask.DescendingOrder(123456789));
                }

                [Test]
                public void OnesAndZerosTest()
                {
                    Assert.AreEqual(0, OnesAndZerosTask.binaryArrayToNumber(new int[] { 0, 0, 0, 0 }));
                    Assert.AreEqual(15, OnesAndZerosTask.binaryArrayToNumber(new int[] { 1, 1, 1, 1 }));
                    Assert.AreEqual(6, OnesAndZerosTask.binaryArrayToNumber(new int[] { 0, 1, 1, 0 }));
                    Assert.AreEqual(5, OnesAndZerosTask.binaryArrayToNumber(new int[] { 0, 1, 0, 1 }));
                }

                [Test]
                public void CountTheDivisorsOfANumberTest()
                {
                    Assert.AreEqual(1, CountTheDivisorsOfANumberTask.Divisors(1));
                    Assert.AreEqual(4, CountTheDivisorsOfANumberTask.Divisors(10));
                    Assert.AreEqual(2, CountTheDivisorsOfANumberTask.Divisors(11));
                    Assert.AreEqual(8, CountTheDivisorsOfANumberTask.Divisors(54));
                }

                [Test]
                public void ValidatePinTest()
                {
                    Assert.AreEqual(false, ValidatePinTask.ValidatePin("1"), "Wrong output for \"1\"");
                    Assert.AreEqual(false, ValidatePinTask.ValidatePin("12"), "Wrong output for \"12\"");
                    Assert.AreEqual(false, ValidatePinTask.ValidatePin("123"), "Wrong output for \"123\"");
                    Assert.AreEqual(false, ValidatePinTask.ValidatePin("12345"), "Wrong output for \"12345\"");
                    Assert.AreEqual(false, ValidatePinTask.ValidatePin("1234567"), "Wrong output for \"1234567\"");
                    Assert.AreEqual(false, ValidatePinTask.ValidatePin("-1234"), "Wrong output for \"-1234\"");
                    Assert.AreEqual(false, ValidatePinTask.ValidatePin("1.234"), "Wrong output for \"1.234\"");
                    Assert.AreEqual(false, ValidatePinTask.ValidatePin("-1.234"), "Wrong output for \"-1.234\"");
                    Assert.AreEqual(false, ValidatePinTask.ValidatePin("00000000"), "Wrong output for \"00000000\"");
                    Assert.AreEqual(false, ValidatePinTask.ValidatePin("a234"), "Wrong output for \"a234\"");
                    Assert.AreEqual(false, ValidatePinTask.ValidatePin(".234"), "Wrong output for \".234\"");
                    Assert.AreEqual(true, ValidatePinTask.ValidatePin("1234"), "Wrong output for \"1234\"");
                    Assert.AreEqual(true, ValidatePinTask.ValidatePin("0000"), "Wrong output for \"0000\"");
                    Assert.AreEqual(true, ValidatePinTask.ValidatePin("1111"), "Wrong output for \"1111\"");
                    Assert.AreEqual(true, ValidatePinTask.ValidatePin("123456"), "Wrong output for \"123456\"");
                    Assert.AreEqual(true, ValidatePinTask.ValidatePin("098765"), "Wrong output for \"098765\"");
                    Assert.AreEqual(true, ValidatePinTask.ValidatePin("000000"), "Wrong output for \"000000\"");
                    Assert.AreEqual(true, ValidatePinTask.ValidatePin("090909"), "Wrong output for \"090909\"");
                }

                [Test]
                public static void IsSquareTest()
                {
                    Assert.AreEqual(false, IsSquareTask.IsSquare(-1), "negative numbers aren't square numbers");
                    Assert.AreEqual(false, IsSquareTask.IsSquare(3), "3 isn't a square number");
                    Assert.AreEqual(true, IsSquareTask.IsSquare(4), "4 is a square number");
                    Assert.AreEqual(true, IsSquareTask.IsSquare(25), "25 is a square number");
                    Assert.AreEqual(false, IsSquareTask.IsSquare(26), "26 isn't a square number");
                }

                [Test]
                public void GetTheMiddleCharacterTest()
                {
                    Assert.AreEqual("es", GetTheMiddleCharacterTask.GetMiddle("test"));
                    Assert.AreEqual("t", GetTheMiddleCharacterTask.GetMiddle("testing"));
                    Assert.AreEqual("dd", GetTheMiddleCharacterTask.GetMiddle("middle"));
                    Assert.AreEqual("A", GetTheMiddleCharacterTask.GetMiddle("A"));
                }

                [Test]
                public void StringEndsWithTest()
                {
                    Assert.AreEqual(true, StringEndsWithTask.Solution("samurai", "ai"));
                    Assert.AreEqual(false, StringEndsWithTask.Solution("sumo", "omo"));
                    Assert.AreEqual(false, StringEndsWithTask.Solution("ails", "fails"));
                    Assert.AreEqual(true, StringEndsWithTask.Solution("ninja", "ja"));
                    Assert.AreEqual(true, StringEndsWithTask.Solution("!@#$%^&*() :-)", ":-)"));
                }

                [Test]
                public void IsTriangleTest()
                {
                    Assert.IsTrue(IsTriangleTask.IsTriangle(5, 7, 10));
                }

                [Test]
                public void CategorizeNewMemberTest()
                {
                    Assert.AreEqual(new[] { "Open", "Senior", "Open", "Senior" }, CategorizeNewMemberTask.OpenOrSenior(new[] { new[] { 45, 12 }, new[] { 55, 21 }, new[] { 19, 2 }, new[] { 104, 20 } }));
                    Assert.AreEqual(new[] { "Open", "Open", "Open", "Open" }, CategorizeNewMemberTask.OpenOrSenior(new[] { new[] { 3, 12 }, new[] { 55, 1 }, new[] { 91, -2 }, new[] { 54, 23 } }));
                    Assert.AreEqual(new[] { "Senior", "Open", "Open", "Open" }, CategorizeNewMemberTask.OpenOrSenior(new[] { new[] { 59, 12 }, new[] { 45, 21 }, new[] { -12, -2 }, new[] { 12, 12 } }));
                }

                [Test]
                public void DisemvowelTrollsTest()
                {
                    Assert.AreEqual("Ths wbst s fr lsrs LL!", Kata.Disemvowel("This website is for losers LOL!"));
                    Assert.AreEqual("Wht r y,  cmmnst?", Kata.Disemvowel("What are you, a communist?"));
                    Assert.AreEqual("N ffns bt,\nYr wrtng s mng th wrst 'v vr rd", Kata.Disemvowel("No offense but,\nYour writing is among the worst I've ever read"));
                }

                [Test]
                public void VowelCountTest()
                {
                    Assert.AreEqual(5, VowelCountTask.GetVowelCount("abracadabra"));
                }

                [Test]
                public static void MinMaxTest()
                {
                    Assert.AreEqual(new int[] { -1, 20 }, MinMaxTask.minMax(new int[] { 1, 2, 5, -1, 12, 20 }));
                    Assert.AreEqual(new int[] { 1, 5 }, MinMaxTask.minMax(new int[] { 1, 2, 3, 4, 5 }));
                    Assert.AreEqual(new int[] { -3, 5 }, MinMaxTask.minMax(new int[] { 1, 2, -3, 4, 5 }));
                }

                [Test]
                public static void PrinterErrorTest()
                {
                    Assert.AreEqual("3/56", PrinterErrorTask.PrinterError("aaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz"));
                }

                [Test]
                public void IsIsogramTest()
                {
                    Assert.AreEqual(expected: true, actual: IsIsogramTask.IsIsogram("Dermatoglyphics"));
                    Assert.AreEqual(expected: true, actual: IsIsogramTask.IsIsogram("isogram"));
                    Assert.AreEqual(expected: false, actual: IsIsogramTask.IsIsogram("moose"));
                    Assert.AreEqual(expected: false, actual: IsIsogramTask.IsIsogram("isIsogram"));
                }

                [Test]
                public static void AccumTest()
                {
                    Assert.AreEqual("N-Yy-Fff-Ffff-Sssss-Gggggg-Eeeeeee-Yyyyyyyy-Yyyyyyyyy-Llllllllll-Bbbbbbbbbbb", AccumTask.Accum("NyffsGeyylB"));
                    Assert.AreEqual("M-Jj-Ttt-Kkkk-Uuuuu-Bbbbbb-Ooooooo-Vvvvvvvv-Qqqqqqqqq-Rrrrrrrrrr-Uuuuuuuuuuu", AccumTask.Accum("MjtkuBovqrU"));
                    Assert.AreEqual("E-Vv-Iii-Dddd-Jjjjj-Uuuuuu-Nnnnnnn-Oooooooo-Kkkkkkkkk-Mmmmmmmmmm-Mmmmmmmmmmm", AccumTask.Accum("EvidjUnokmM"));
                }
                [Test]
                public void ReverseWordsTest()
                {
                    Assert.AreEqual("sihT si na !elpmaxe", ReverseWordsTask.ReverseWords("This is an example!"));
                }

                [Test]
                public void FriendOrFoeTest()
                {
                    string[] expected = { "Ryan", "Mark" };
                    string[] names = { "Ryan", "Kieran", "Mark", "Jimmy" };
                    CollectionAssert.AreEqual(expected, FriendOrFoeTask.FriendOrFoe(names));
                }
                [Test]
                public void MakeComplementTest()
                {
                    Assert.That(MakeComplementTask.MakeComplement("ATGC"), Is.EqualTo("TACG"));
                    Assert.That(MakeComplementTask.MakeComplement("AAGG"), Is.EqualTo("TTCC"));
                    Assert.That(MakeComplementTask.MakeComplement("ATTGC"), Is.EqualTo("TAACG"));
                }

            }
        }
    }
}