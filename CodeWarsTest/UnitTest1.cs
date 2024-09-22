using CodeWars7kyu;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Reflection;
using System.Text;
using static CodeWars7kyu.WhoIsOnlineTask.User;
using static CodeWars7kyu.WhoIsOnlineTask;
using static CodeWars7kyu.MakingCopiesTask;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
				public void DrivingLicenceTest()
				{
					DrivingLicenceTask test2 = new DrivingLicenceTask();
					string[] data2 = new string[] { "Johanna", "", "Gibbs", "13-Dec-1981", "F" };
					Assert.AreEqual("GIBBS862131J99AA", test2.Driver(data2));

					DrivingLicenceTask test = new DrivingLicenceTask();
					string[] data = new string[] { "Andrew", "Robert", "Lee", "02-September-1981", "M" };
					Assert.AreEqual("LEE99809021AR9AA", test.Driver(data));
				}

				[Test]
				public void EncodeDecodeTest()
				{
					Assert.AreEqual("Gug hgs g cgt", EncodeDecodeTask.Encode("Ala has a cat"));
					Assert.AreEqual("GBCE", EncodeDecodeTask.Encode("ABCD"));
					Assert.AreEqual("Gug hgs g cgt", EncodeDecodeTask.Encode("Ala has a cat"));
					Assert.AreEqual("agedyropulik", EncodeDecodeTask.Encode("gaderypoluki"));
                    Assert.AreEqual("Ala has a cat", EncodeDecodeTask.Decode("Gug hgs g cgt"));
                    Assert.AreEqual("gaderypoluki", EncodeDecodeTask.Decode("agedyropulik"));
                    Assert.AreEqual("ABCD", EncodeDecodeTask.Decode("GBCE"));
                }

				[Test]
				public void GetNthNodeTest()
				{
					GetNthNodeTask head = new GetNthNodeTask(1);
					head.Next = new GetNthNodeTask(2);
					head.Next.Next = new GetNthNodeTask(3);

					GetNthNodeTask result = GetNthNodeTask.GetNth(head, 0);
					Assert.AreEqual(1, result.Data);

					result = GetNthNodeTask.GetNth(head, 1);
					Assert.AreEqual(2, result.Data);

					result = GetNthNodeTask.GetNth(head, 2);
					Assert.AreEqual(3, result.Data);
				}

				[Test]
				public void PairsOfIntegersFromTest()
				{
					Act(2, 4, new[] { (2, 2), (2, 3), (2, 4), (3, 3), (3, 4), (4, 4) });
					Act(0, 1, new[] { (0, 0), (0, 1), (1, 1) });
					Act(0, 0, new[] { (0, 0) });

					static void Act(int m, int n, (int, int)[] expected)
					{
						var msg = $"Invalid answer for m: {m}, n: {n}";
						var actual = PairsOfIntegersFromTask.GeneratePairs(m, n).ToArray();
						CollectionAssert.AreEqual(Format(expected), Format(actual), msg);
					}

					static string Format((int, int)[] xs) => string.Join(", ", xs);
				}

				[Test]
				public void NextPalindromicNumberTest()
				{
					Assert.AreEqual(22, NextPalindromicNumberTask.NextPal(11));
					Assert.AreEqual(191, NextPalindromicNumberTask.NextPal(188));
					Assert.AreEqual(202, NextPalindromicNumberTask.NextPal(191));
					Assert.AreEqual(2552, NextPalindromicNumberTask.NextPal(2541));
				}

				[Test]
				public void BirthdayICakeTest()
				{
					Assert.AreEqual("That was close!", BirthdayICakeTask.Cake(900, "abcdef"));
					Assert.AreEqual("Fire!", BirthdayICakeTask.Cake(56, "ifkhchlhfd"));
					Assert.AreEqual("Fire!", BirthdayICakeTask.Cake(256, "aaaaaddddr"));
				}

				[Test]
                public void FloatPrecisionTest()
                {
					Assert.AreEqual(2.34, FloatPrecisionTask.Round(2.34));
					Assert.AreEqual(5.68, FloatPrecisionTask.Round(5.678));
				}

				[Test]
				public void MostValuableCharacterTest()
				{
					Assert.AreEqual('a', MostValuableCharacterTask.Solve("a"));
					Assert.AreEqual('a', MostValuableCharacterTask.Solve("aa"));
					Assert.AreEqual('b', MostValuableCharacterTask.Solve("bcd"));
					Assert.AreEqual('x', MostValuableCharacterTask.Solve("axyzxyz"));
					Assert.AreEqual('a', MostValuableCharacterTask.Solve("dcbadcba"));
					Assert.AreEqual('c', MostValuableCharacterTask.Solve("aabccc"));
					Assert.AreEqual('e', MostValuableCharacterTask.Solve("efgefg"));
					Assert.AreEqual('e', MostValuableCharacterTask.Solve("efghijefghi"));
					Assert.AreEqual('a', MostValuableCharacterTask.Solve("acefacef"));
					Assert.AreEqual('a', MostValuableCharacterTask.Solve("acefacefacef"));
				}

				[Test]
				public static void CountTheDigitTest()
				{
					Assert.AreEqual(4700, CountTheDigitTask.NbDig(5750, 0));
					Assert.AreEqual(9481, CountTheDigitTask.NbDig(11011, 2));
					Assert.AreEqual(7733, CountTheDigitTask.NbDig(12224, 8));
				}

				[Test]
				public void SuzukiNeedsHelpLiningUpTest()
				{
					string students = "Tadashi Takahiro Takao Takashi Takayuki Takehiko Takeo Takeshi Takeshi";
					string[] expected = { "Takehiko", "Takayuki", "Takahiro", "Takeshi", "Takeshi", "Takashi", "Tadashi", "Takeo", "Takao" };
					Assert.AreEqual(expected, SuzukiNeedsHelpLiningUpTask.LineupStudents(students));
				}

				[Test]
				public void HeadTailInitLastTest()
				{
					Assert.AreEqual(5, HeadTailInitLastTask.Head(new List<int> { 5, 1 }));
					Assert.AreEqual(new List<int> { 2, 3 }, HeadTailInitLastTask.Tail(new List<int> { 1, 2, 3 }));
					Assert.AreEqual(new List<int> { 1, 5, 7 }, HeadTailInitLastTask.Init(new List<int> { 1, 5, 7, 9 }));
					Assert.AreEqual(2, HeadTailInitLastTask.GetLast(new List<int> { 7, 2 }));
				}

				[Test]
				public void RemoveAllExclamationMarksFromSentenceExceptAtTheEndTest()
				{
					Assert.AreEqual("Hi!", RemoveAllExclamationMarksFromSentenceExceptAtTheEndTask.Remove("Hi!"));
					Assert.AreEqual("Hi!!!", RemoveAllExclamationMarksFromSentenceExceptAtTheEndTask.Remove("Hi!!!"));
					Assert.AreEqual("Hi", RemoveAllExclamationMarksFromSentenceExceptAtTheEndTask.Remove("!Hi"));
					Assert.AreEqual("Hi!", RemoveAllExclamationMarksFromSentenceExceptAtTheEndTask.Remove("!Hi!"));
					Assert.AreEqual("Hi Hi!", RemoveAllExclamationMarksFromSentenceExceptAtTheEndTask.Remove("Hi! Hi!"));
					Assert.AreEqual("Hi", RemoveAllExclamationMarksFromSentenceExceptAtTheEndTask.Remove("Hi"));
				}

				[Test]
				public void ProductOfLargestPairTest()
				{
					Assert.AreEqual(218842, ProductOfLargestPairTask.MaxProduct(new int[] { 56, 335, 195, 443, 6, 494, 252 }));
					Assert.AreEqual(194740, ProductOfLargestPairTask.MaxProduct(new int[] { 154, 428, 455, 346 }));
					Assert.AreEqual(187827, ProductOfLargestPairTask.MaxProduct(new int[] { 39, 135, 47, 275, 37, 108, 265, 457, 2, 133, 316, 330, 153, 253, 321, 411 }));
					Assert.AreEqual(87984, ProductOfLargestPairTask.MaxProduct(new int[] { 136, 376, 10, 146, 105, 63, 234 }));
					Assert.AreEqual(218536, ProductOfLargestPairTask.MaxProduct(new int[] { 354, 463, 165, 62, 472, 53, 347, 293, 252, 378, 420, 398, 255, 89 }));
					Assert.AreEqual(192672, ProductOfLargestPairTask.MaxProduct(new int[] { 346, 446, 26, 425, 432, 349, 123, 269, 285, 93, 75, 14 }));
					Assert.AreEqual(95680, ProductOfLargestPairTask.MaxProduct(new int[] { 134, 320, 266, 299 }));
					Assert.AreEqual(139496, ProductOfLargestPairTask.MaxProduct(new int[] { 114, 424, 53, 272, 128, 215, 25, 329, 272, 313, 100, 24, 252 }));
					Assert.AreEqual(174750, ProductOfLargestPairTask.MaxProduct(new int[] { 375, 56, 337, 466, 203 }));
				}

				[Test]
				public void MoveAllVowelsTest()
				{
					Assert.That(MoveAllVowelsTask.MoveVowel("day"), Is.EqualTo("dya"));
					Assert.That(MoveAllVowelsTask.MoveVowel("apple"), Is.EqualTo("pplae"));
					Assert.That(MoveAllVowelsTask.MoveVowel("peace"), Is.EqualTo("pceae"));
					Assert.That(MoveAllVowelsTask.MoveVowel("maker"), Is.EqualTo("mkrae"));
				}

				[Test]
				public void TheRejectFunctionTest()
				{
					Assert.AreEqual(new int[] { 1, 3, 5 }, TheRejectFunctionTask.Reject(new int[] { 1, 2, 3, 4, 5, 6 }, (n) => n % 2 == 0));
				}

				[Test]
				public static void ScalingSquaredStringsTest()
				{
                    
					string a = "abcd\nefgh\nijkl\nmnop";
					string r = "aabbccdd\naabbccdd\naabbccdd\neeffgghh\neeffgghh\neeffgghh\niijjkkll\n"
							+ "iijjkkll\niijjkkll\nmmnnoopp\nmmnnoopp\nmmnnoopp";
					testing(ScalingSquaredStringsTask.Scale(a, 2, 3), r);
					testing(ScalingSquaredStringsTask.Scale("", 5, 5), "");
                    testing(ScalingSquaredStringsTask.Scale("Kj\nSH", 1, 2), "Kj\nKj\nSH\nSH");


						static void testing(string actual, string expected)
					{
						Assert.AreEqual(expected, actual);
					}
				}

				[Test]
				public void NumberPairsTest()
				{
					int[] arr1 = new int[] { 13, 64, 5, 7, 88 };
					int[] arr2 = new int[] { 23, 4, 53, 17, 80 };
					Assert.AreEqual(NumberPairsTask.GetLargerNumbers(arr1, arr2), new int[] { 23, 64, 53, 17, 88 });
				}
				[Test]
				public void FindTheIndexOfTest()
				{
					Assert.AreEqual(3, FindTheIndexOfTask.SecondSymbol("Hello world!!", 'l'), "Find the index of the second symbol \"l\" in the string");
					Assert.AreEqual(7, FindTheIndexOfTask.SecondSymbol("Hello world!!", 'o'), "Find the index of the second symbol \"o\" in the string");
					Assert.AreEqual(-1, FindTheIndexOfTask.SecondSymbol("Hello world!!", 'A'), "The symbol \"A\" is not in the string");
					Assert.AreEqual(-1, FindTheIndexOfTask.SecondSymbol("", 'q'), "The symbol \"q\" is not in the string");
					Assert.AreEqual(-1, FindTheIndexOfTask.SecondSymbol("Hello", '!'), "The symbol \"!\" is not in the string");
					Assert.AreEqual(-1, FindTheIndexOfTask.SecondSymbol("lHgMvSCkzgRgmSUtfSWnWENGgADkfLaYMbrjjzJp", 'l'));
				}

				[Test]
				public void WhatIsMyGolfScoreTest()
				{
					Assert.That(WhatIsMyGolfScoreTask.GolfScoreCalculator("453454444344544443", "354445334534445348"), Is.EqualTo(3));
					Assert.That(WhatIsMyGolfScoreTask.GolfScoreCalculator("333333333333333333", "444444444444444444"), Is.EqualTo(18));
				}

				[Test]
				public void Recursion101Test()
				{
					Assert.AreEqual((6, 7), Recursion101Task.Solve(6, 19));
					Assert.AreEqual((0, 1), Recursion101Task.Solve(2, 1));
					Assert.AreEqual((0, 1), Recursion101Task.Solve(22, 5));
					Assert.AreEqual((2, 2), Recursion101Task.Solve(2, 10));
					Assert.AreEqual((1019, 1442), Recursion101Task.Solve(8796203, 7556));
					Assert.AreEqual((19394, 19394), Recursion101Task.Solve(19394, 19394));

				}

				[Test]
				public void GeometricProgressionSequenceTest()
				{
					Assert.AreEqual("2, 6, 18, 54, 162", GeometricProgressionSequenceTask.GeometricSequenceElements(2, 3, 5));
					Assert.AreEqual("2, 4, 8, 16, 32, 64, 128, 256, 512, 1024", GeometricProgressionSequenceTask.GeometricSequenceElements(2, 2, 10));
					Assert.AreEqual("1, -2, 4, -8, 16, -32, 64, -128, 256, -512", GeometricProgressionSequenceTask.GeometricSequenceElements(1, -2, 10));
				}

				[Test]
				public static void FindTheLongestGapTest()
				{
					Assert.AreEqual(2, FindTheLongestGapTask.Gap(9));
					Assert.AreEqual(4, FindTheLongestGapTask.Gap(529));
					Assert.AreEqual(1, FindTheLongestGapTask.Gap(20));
					Assert.AreEqual(0, FindTheLongestGapTask.Gap(15));
				}

				[Test]
				public void SprayingTreesTest()
				{
					Assert.AreEqual("It is Wednesday today, Robert, you have to work, you must spray 10 trees and you need 20 dollars to buy liquid", SprayingTreesTask.Task("Wednesday", 10, 2));
					Assert.AreEqual("It is Monday today, James, you have to work, you must spray 4 trees and you need 12 dollars to buy liquid", SprayingTreesTask.Task("Monday", 4, 3));
					Assert.AreEqual("It is Friday today, William, you have to work, you must spray 5 trees and you need 20 dollars to buy liquid", SprayingTreesTask.Task("Friday", 5, 4));
					Assert.AreEqual("It is Tuesday today, John, you have to work, you must spray 6 trees and you need 6 dollars to buy liquid", SprayingTreesTask.Task("Tuesday", 6, 1));
					Assert.AreEqual("It is Thursday today, Michael, you have to work, you must spray 5 trees and you need 15 dollars to buy liquid", SprayingTreesTask.Task("Thursday", 5, 3));
				}

				[Test]
				public static void ClassFunctionFactoryTest()
				{
					Func<int[], int[]> threes = ClassFunctionFactoryTask.Factory(3);
					int[] myArr = new int[] { 1, 2, 3 };
					testing(threes(myArr), new int[] { 3, 6, 9 });
					Func<int[], int[]> fives = ClassFunctionFactoryTask.Factory(5);
					testing(fives(myArr), new int[] { 5, 10, 15 });

					static void testing(int[] expected, int[] actual)
					{
						Assert.AreEqual(expected, actual);
					}

				}

				[Test]
				public void CompleteThePatternTest()
				{
					Assert.AreEqual("1", CompleteThePatternTask.Pattern(1));
					Assert.AreEqual("12\n2", CompleteThePatternTask.Pattern(2));
					Assert.AreEqual("12345\n2345\n345\n45\n5", CompleteThePatternTask.Pattern(5));
				}

				[Test]
				public void HappyBirthdayDarlingTest()
				{
					Assert.AreEqual("32? That's just 20, in base 16!", HappyBirthdayDarlingTask.WomensAge(32));
					Assert.AreEqual("39? That's just 21, in base 19!", HappyBirthdayDarlingTask.WomensAge(39));
					Assert.AreEqual("22? That's just 20, in base 11!", HappyBirthdayDarlingTask.WomensAge(22));
					Assert.AreEqual("65? That's just 21, in base 32!", HappyBirthdayDarlingTask.WomensAge(65));
					Assert.AreEqual("83? That's just 21, in base 41!", HappyBirthdayDarlingTask.WomensAge(83));
				}

				[Test]
				public void PowersOfITest()
				{
					int i = 4;
					Assert.AreEqual("1", PowersOfITask.Pofi(0));
					Assert.AreEqual("i", PowersOfITask.Pofi(1));
					Assert.AreEqual("-1", PowersOfITask.Pofi(2));
					Assert.AreEqual("-i", PowersOfITask.Pofi(3));
					Assert.AreEqual("1", PowersOfITask.Pofi(i));
					Assert.AreEqual("i", PowersOfITask.Pofi(i + 1));
					Assert.AreEqual("-1", PowersOfITask.Pofi(i + 2));
					Assert.AreEqual("-i", PowersOfITask.Pofi(i + 3));
					i += 4;
					Assert.AreEqual("1", PowersOfITask.Pofi(i));
					Assert.AreEqual("i", PowersOfITask.Pofi(i + 1));
					Assert.AreEqual("-1", PowersOfITask.Pofi(i + 2));
					Assert.AreEqual("-i", PowersOfITask.Pofi(i + 3));
				}

				[Test]
				public void PossibilitiesArrayTest()
				{
					Assert.AreEqual(true, PossibilitiesArrayTask.IsAllPossibilities(new int[] { 0, 1, 2, 3 }));
					Assert.AreEqual(false, PossibilitiesArrayTask.IsAllPossibilities(new int[] { 1, 2, 3, 4 }));
				}

				[Test]
				public void DifferenceBetweenYaersTest()
				{
					Assert.AreEqual(18, DifferenceBetweenYaersTask.HowManyYears("1997/10/10", "2015/10/10"));
					Assert.AreEqual(25, DifferenceBetweenYaersTask.HowManyYears("1990/10/10", "2015/10/10"));
					Assert.AreEqual(25, DifferenceBetweenYaersTask.HowManyYears("2015/10/10", "1990/10/10"));
					Assert.AreEqual(23, DifferenceBetweenYaersTask.HowManyYears("1992/10/24", "2015/10/24"));
					Assert.AreEqual(18, DifferenceBetweenYaersTask.HowManyYears("2018/10/10", "2000/10/10"));
					Assert.AreEqual(0, DifferenceBetweenYaersTask.HowManyYears("2000/10/10", "2000/10/10"));
				}

				[Test]
				public void TriangularNumbersTest()
				{
					Assert.AreEqual(true, TriangularNumbersTask.IsTriangular(6));
				}

				[Test]
				public void SlapheadTest()
				{
					Assert.AreEqual(new string[] { "----------", "Unicorn!" }, SlapheadTask.Bald("/---------"));
					Assert.AreEqual(new string[] { "--------", "Homer!" }, SlapheadTask.Bald("/-----/-"));
					Assert.AreEqual(new string[] { "---------------", "Careless!" }, SlapheadTask.Bald("--/--/---/-/---"));
				}

				[Test]
				public void UniqueSumTest()
				{
					Assert.AreEqual(6, UniqueSumTask.UniqueSum(new List<int>() { 1, 2, 3 }));
					Assert.AreEqual(12, UniqueSumTask.UniqueSum(new List<int>() { 1, 3, 8, 1, 8 }));
					Assert.AreEqual(-1, UniqueSumTask.UniqueSum(new List<int>() { -1, -1, 5, 2, -7 }));
				}

				[Test]
				public void pushTests()
				{
					Assert.AreEqual(1, LinkedListsPushBuildOneTwoThreeTask.Push(null, 1).Data, "Should be able to create a new linked list with push().");
					Assert.AreEqual(null, LinkedListsPushBuildOneTwoThreeTask.Push(null, 1).Next, "Should be able to create a new linked list with push().");
					Assert.AreEqual(2, LinkedListsPushBuildOneTwoThreeTask.Push(new LinkedListsPushBuildOneTwoThreeTask(1), 2).Data, "Should be able to prepend a node to an existing node.");
					Assert.AreEqual(1, LinkedListsPushBuildOneTwoThreeTask.Push(new LinkedListsPushBuildOneTwoThreeTask(1), 2).Next.Data, "Should be able to prepend a node to an existing node.");

					Assert.AreEqual(1, LinkedListsPushBuildOneTwoThreeTask.BuildOneTwoThree().Data, "First node should should have 1 as data.");
					Assert.AreEqual(2, LinkedListsPushBuildOneTwoThreeTask.BuildOneTwoThree().Next.Data, "Second node should should have 2 as data.");
					Assert.AreEqual(3, LinkedListsPushBuildOneTwoThreeTask.BuildOneTwoThree().Next.Next.Data, "Third node should should have 3 as data.");
					Assert.AreEqual(null, LinkedListsPushBuildOneTwoThreeTask.BuildOneTwoThree().Next.Next.Next, "Third node should be the tail of the linked list");
				}

				[Test]
				public static void MovesInSquaredStringsTest()
				{
					Console.WriteLine("Fixed Tests VertMirror");
					testing(MovesInSquaredStringsTask.Oper(MovesInSquaredStringsTask.VertMirror, "hSgdHQ\nHnDMao\nClNNxX\niRvxxH\nbqTVvA\nwvSyRu"),
						"QHdgSh\noaMDnH\nXxNNlC\nHxxvRi\nAvVTqb\nuRySvw");
					testing(MovesInSquaredStringsTask.Oper(MovesInSquaredStringsTask.VertMirror, "IzOTWE\nkkbeCM\nWuzZxM\nvDddJw\njiJyHF\nPVHfSx"),
						"EWTOzI\nMCebkk\nMxZzuW\nwJddDv\nFHyJij\nxSfHVP");

					Console.WriteLine("Fixed Tests HorMirror");
					testing(MovesInSquaredStringsTask.Oper(MovesInSquaredStringsTask.HorMirror, "lVHt\nJVhv\nCSbg\nyeCt"), "yeCt\nCSbg\nJVhv\nlVHt");
					testing(MovesInSquaredStringsTask.Oper(MovesInSquaredStringsTask.HorMirror, "njMK\ndbrZ\nLPKo\ncEYz"), "cEYz\nLPKo\ndbrZ\nnjMK");

					static void testing(string actual, string expected)
					{
						Assert.AreEqual(expected, actual);
					}
				}

				[Test]
				public void CompleteSeriesTest()
				{
					Assert.AreEqual(new int[] { 0, 1 }, CompleteSeriesTask.CompleteSeries(new int[] { 0, 1 }));
					Assert.AreEqual(new int[] { 0, 1, 2, 3, 4, 5, 6 }, CompleteSeriesTask.CompleteSeries(new int[] { 1, 4, 6 }));
					Assert.AreEqual(new int[] { 0, 1, 2, 3, 4, 5 }, CompleteSeriesTask.CompleteSeries(new int[] { 3, 4, 5 }));
					Assert.AreEqual(new int[] { 0, 1, 2 }, CompleteSeriesTask.CompleteSeries(new int[] { 2, 1 }));
					Assert.AreEqual(new int[] { 0 }, CompleteSeriesTask.CompleteSeries(new int[] { 1, 4, 4, 6 }));
				}

				[Test]
				public void TheOfficeSabbaticalTest()
				{
					Assert.AreEqual("Sabbatical! Boom!", TheOfficeSabbaticalTask.Sabb("Can I have a sabbatical?", 5, 5));
					Assert.AreEqual("Back to your desk, boy.", TheOfficeSabbaticalTask.Sabb("Why are you shouting?", 7, 2));
					Assert.AreEqual("Sabbatical! Boom!", TheOfficeSabbaticalTask.Sabb("What do you mean I cant learn to code??", 8, 9));
					Assert.AreEqual("Back to your desk, boy.", TheOfficeSabbaticalTask.Sabb("Please calm down", 9, 1));
				}

				[Test]
				public void TheOldSwitcherooTest()
                {
					Assert.AreEqual("123", TheOldSwitcherooTask.Encode("abc"));
					Assert.AreEqual("1234", TheOldSwitcherooTask.Encode("ABCD"));
					Assert.AreEqual("2626262626", TheOldSwitcherooTask.Encode("ZzzzZ"));
					Assert.AreEqual("123-#@5", TheOldSwitcherooTask.Encode("abc-#@5"));
					Assert.AreEqual("208919 919 1 1215147 1920189147!! 161251195 [51431545] @30181853201225", TheOldSwitcherooTask.Encode("this is a long string!! Please [encode] @C0RrEctly"));
				}

				[Test]
				public void WhatDominatesYourArrayTest()
				{
					Assert.AreEqual(3, WhatDominatesYourArrayTask.WhoDominates(new int[] { 3, 4, 3, 2, 3, 1, 3, 3 }));
					Assert.AreEqual(-1, WhatDominatesYourArrayTask.WhoDominates(new int[] { 1, 2, 3, 4, 5 }));
					Assert.AreEqual(-1, WhatDominatesYourArrayTask.WhoDominates(new int[] { 1, 1, 1, 2, 2, 2 }));
					Assert.AreEqual(2, WhatDominatesYourArrayTask.WhoDominates(new int[] { 1, 1, 1, 2, 2, 2, 2 }));
				}

				[Test]
				public void MonotoneTravelTest()
				{
					Assert.AreEqual(true, MonotoneTravelTask.IsMonotone(new int[] { 1, 2, 3, 3, 4, 5 }));
					Assert.AreEqual(false, MonotoneTravelTask.IsMonotone(Enumerable.Range(1, 5).Reverse().ToArray()));
					Assert.AreEqual(true, MonotoneTravelTask.IsMonotone(new int[] { }));
					Assert.AreEqual(true, MonotoneTravelTask.IsMonotone(new int[] { 5, 5, 5, 5, 5 }));


				}

				[Test]
				public void RemoveWordsFromTheSentenceIfItContainsOneExclamationMarkTest()
				{
					Assert.AreEqual("", RemoveWordsFromTheSentenceIfItContainsOneExclamationMarkTask.Remove("Hi!"));
					Assert.AreEqual("", RemoveWordsFromTheSentenceIfItContainsOneExclamationMarkTask.Remove("!Hi"));
					Assert.AreEqual("", RemoveWordsFromTheSentenceIfItContainsOneExclamationMarkTask.Remove("Hi! Hi! Hi!"));
					Assert.AreEqual("", RemoveWordsFromTheSentenceIfItContainsOneExclamationMarkTask.Remove("Hi! !Hi Hi!"));
					Assert.AreEqual("", RemoveWordsFromTheSentenceIfItContainsOneExclamationMarkTask.Remove("Hi! Hi!"));
					Assert.AreEqual("!Hi!", RemoveWordsFromTheSentenceIfItContainsOneExclamationMarkTask.Remove("!Hi!"));
					Assert.AreEqual("Hi!!!", RemoveWordsFromTheSentenceIfItContainsOneExclamationMarkTask.Remove("Hi!!!"));
					Assert.AreEqual("Hi", RemoveWordsFromTheSentenceIfItContainsOneExclamationMarkTask.Remove("Hi Hi! Hi!"));
					Assert.AreEqual("Hi hi hI", RemoveWordsFromTheSentenceIfItContainsOneExclamationMarkTask.Remove("Hi hi hI"));
					Assert.AreEqual("Hi!!", RemoveWordsFromTheSentenceIfItContainsOneExclamationMarkTask.Remove("Hi! Hi!! Hi!"));
					Assert.AreEqual("!Hi!", RemoveWordsFromTheSentenceIfItContainsOneExclamationMarkTask.Remove("Hi! !Hi! Hi!"));
					Assert.AreEqual("!Hi! !Hi!", RemoveWordsFromTheSentenceIfItContainsOneExclamationMarkTask.Remove("!Hi! ! !Hi!"));
					Assert.AreEqual("!!!Hi !!hi!!!", RemoveWordsFromTheSentenceIfItContainsOneExclamationMarkTask.Remove("!!!Hi !!hi!!! !hi"));
				}

				[Test]
				public void MoveAllExclamationMarksToTheEndOfTheSentenceTest()
				{
					Assert.AreEqual("Hi!", MoveAllExclamationMarksToTheEndOfTheSentenceTask.Remove("Hi!"));
					Assert.AreEqual("Hi Hi!!", MoveAllExclamationMarksToTheEndOfTheSentenceTask.Remove("Hi! Hi!"));
					Assert.AreEqual("Hi Hi Hi!!!", MoveAllExclamationMarksToTheEndOfTheSentenceTask.Remove("Hi! Hi! Hi!"));
					Assert.AreEqual("Hi Hi Hi!!!", MoveAllExclamationMarksToTheEndOfTheSentenceTask.Remove("Hi! !Hi Hi!"));
					Assert.AreEqual("Hi Hi Hi!!!", MoveAllExclamationMarksToTheEndOfTheSentenceTask.Remove("Hi! !Hi Hi!"));
					Assert.AreEqual("Hi Hi Hi!!!!", MoveAllExclamationMarksToTheEndOfTheSentenceTask.Remove("Hi! Hi!! Hi!"));
				}

				[Test]
				public static void EasyWallpaperTest()
				{
					Assert.AreEqual("sixteen", EasyWallpaperTask.WallPaper(6.3, 4.5, 3.29));
					Assert.AreEqual("seventeen", EasyWallpaperTask.WallPaper(6.3, 5.8, 3.13));
					Assert.AreEqual("zero", EasyWallpaperTask.WallPaper(7.9, 0, 5.4));
				}

				[Test]
				public void SaveFilesTest()
				{
					Assert.AreEqual(3, ComputerProblemSeriesHardDiskDriveTask.Save(new int[] { 4, 4, 4, 3, 3 }, 12));
					Assert.AreEqual(2, ComputerProblemSeriesHardDiskDriveTask.Save(new int[] { 4, 4, 4, 3, 3 }, 11));
					Assert.AreEqual(6, ComputerProblemSeriesHardDiskDriveTask.Save(new int[] { 4, 8, 15, 16, 23, 42 }, 108));
					Assert.AreEqual(1, ComputerProblemSeriesHardDiskDriveTask.Save(new int[] { 13 }, 13));
					Assert.AreEqual(4, ComputerProblemSeriesHardDiskDriveTask.Save(new int[] { 1, 2, 3, 4 }, 250));
					Assert.AreEqual(1, ComputerProblemSeriesHardDiskDriveTask.Save(new int[] { 100 }, 500));
					Assert.AreEqual(0, ComputerProblemSeriesHardDiskDriveTask.Save(new int[] { 11, 13, 15, 17, 19 }, 8));
					Assert.AreEqual(0, ComputerProblemSeriesHardDiskDriveTask.Save(new int[] { 45 }, 12));
				}
				[Test]
				public void CatDogTest()
				{
					Assert.AreEqual((1, 1), CatDogTask.OwnedCatAndDog(15, 15));
					Assert.AreEqual((2, 2), CatDogTask.OwnedCatAndDog(24, 24));
					Assert.AreEqual((10, 10), CatDogTask.OwnedCatAndDog(56, 64));
				}

				[Test]
				public void OdderThanTheRestTest()
				{
					Assert.AreEqual(3, OdderThanTheRestTask.OddOne(new List<int> { 2, 4, 6, 7, 10 }));
					Assert.AreEqual(4, OdderThanTheRestTask.OddOne(new List<int> { 2, 16, 98, 10, 13, 78 }));
					Assert.AreEqual(4, OdderThanTheRestTask.OddOne(new List<int> { 4, -8, 98, -12, -7, 90, 100 }));
					Assert.AreEqual(-1, OdderThanTheRestTask.OddOne(new List<int> { 2, 4, 6, 8 }));
				}

				[Test]
				public void FilterCoffeeTest()
                {
					Assert.AreEqual("1,2,2", FilterCoffeeTask.Search(3, new int[] { 6, 1, 2, 9, 2 }));
					Assert.AreEqual("3,7,7,9,14", FilterCoffeeTask.Search(14, new int[] { 7, 3, 23, 9, 14, 20, 7 }));
					Assert.AreEqual("", FilterCoffeeTask.Search(0, new int[] { 6, 1, 2, 9, 2 }));

				}
				[Test]
				public void GCDSumTest()
				{
					Assert.AreEqual((3, 3), GCDSumTask.Solve(6, 3));
					Assert.AreEqual((2, 6), GCDSumTask.Solve(8, 2));
					Assert.AreEqual((-1, -1), GCDSumTask.Solve(10, 3));
					Assert.AreEqual((4, 8), GCDSumTask.Solve(12, 4));
					Assert.AreEqual((-1, -1), GCDSumTask.Solve(12, 5));
					Assert.AreEqual((10, 40), GCDSumTask.Solve(50, 10));
					Assert.AreEqual((-1, -1), GCDSumTask.Solve(50, 4));
					Assert.AreEqual((5, 5), GCDSumTask.Solve(10, 5));
					Assert.AreEqual((5, 95), GCDSumTask.Solve(100, 5));
					Assert.AreEqual((5, 995), GCDSumTask.Solve(1000, 5));

				}

				[Test]
				public void ThePonyExpressTest()
				{
					Assert.AreEqual(1, ThePonyExpressTask.Riders(new int[] { 18, 15 }));
					Assert.AreEqual(2, ThePonyExpressTask.Riders(new int[] { 43, 23, 40, 13 }));
					Assert.AreEqual(3, ThePonyExpressTask.Riders(new int[] { 33, 8, 16, 47, 30, 30, 46 }));
					Assert.AreEqual(4, ThePonyExpressTask.Riders(new int[] { 6, 24, 6, 8, 28, 8, 23, 47, 17, 29, 37, 18, 40, 49 }));
				}

				[Test]
				public void MakingCopiesTest()
				{
					Assert.AreEqual(new int[] { 1, 2, 3, 4 }.ToList(), MakingCopiesTask.Copy(new int[] { 1, 2, 3, 4 }.ToList()));

				}

				[Test]
				public void RemoveAllExclamationMarksFromTheEndTest()
				{
					Assert.AreEqual("!!!Hi !!hi !hi", RemoveAllExclamationMarksFromTheEndTask.Remove("!!!Hi !!hi!!! !hi"));
					Assert.AreEqual("Hi", RemoveAllExclamationMarksFromTheEndTask.Remove("Hi!"));
					Assert.AreEqual("!Hi", RemoveAllExclamationMarksFromTheEndTask.Remove("!Hi!"));
				}

				[Test]
				public void ReverseListTest()
				{
					Assert.AreEqual(new int[0], ReverseListTask.ReverseList(new int[0]));
					Assert.AreEqual(new int[] { 3, 2, 1 }, ReverseListTask.ReverseList(new int[] { 1, 2, 3 }));
				}

				[Test]
				public void NameArrayCappingTest()
				{
					Assert.AreEqual(new string[] { "Expected" }, NameArrayCappingTask.CapMe(new string[] { "ExPeCteD" }));
				}

				[Test]
				public void FindSumOfDiagonalsTest()
				{
					Assert.AreEqual(12, FindSumOfDiagonalsTask.DiagonalSum(new int[,] { { 12 } }));
					Assert.AreEqual(5, FindSumOfDiagonalsTask.DiagonalSum(new int[2, 2] { { 1, 2 }, { 3, 4 } }));
					Assert.AreEqual(15, FindSumOfDiagonalsTask.DiagonalSum(new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }));
					Assert.AreEqual(34, FindSumOfDiagonalsTask.DiagonalSum(new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } }));
				}

				[Test]
				public void DigitalCypherTwoTest()
				{
					Assert.AreEqual("scout", DigitalCypherTwoTask.Decode(new int[] { 20, 12, 18, 30, 21 }, 1939));
					Assert.AreEqual("masterpiece", DigitalCypherTwoTask.Decode(new int[] { 14, 10, 22, 29, 6, 27, 19, 18, 6, 12, 8 }, 1939));
				}

				[Test]
				public void FibonacciTest()
				{
					Assert.AreEqual(5, FibonacciTask.Fib(5));
					Assert.AreEqual(55, FibonacciTask.Fib(10));
				}

				[Test]
				public void MultiplyWordInStringTest()
				{
					Assert.AreEqual("is-is-is", MultiplyWordInStringTask.ModifyMultiply("is very easy to resolve that kata", 0, 3), "should return 'is-is-is'");
					Assert.AreEqual("cheap-cheap-cheap-cheap", MultiplyWordInStringTask.ModifyMultiply("Talk is cheap Show me the code", 2, 4), "should return 'cheap-cheap-cheap'");
					Assert.AreEqual("think-think-think-think-think-think", MultiplyWordInStringTask.ModifyMultiply("Everyone in this country should learn how to program because it teaches you how to think", 15, 6), "should return is-is-is");
					Assert.AreEqual("ignorance-ignorance-ignorance-ignorance-ignorance-ignorance-ignorance-ignorance", MultiplyWordInStringTask.ModifyMultiply("Is sloppiness in code caused by ignorance or apathy? I don't know and I don't care.", 6, 8), "should return 'ignorance-ignorance-ignorance-ignorance-ignorance-ignorance-ignorance-ignorance'");
					Assert.AreEqual("around-around-around-around-around", MultiplyWordInStringTask.ModifyMultiply("Everything happening around me is very random. I am enjoying the phase, as the journey is far more enjoyable than the destination.", 2, 5), "should return'around-around-around-around-around'");
				}

				[Test]
				public void MaxMinArraysTest()
				{
					Assert.That(MaxMinArraysTask.Solve(new List<int> { 15, 11, 10, 7, 12 }), Is.EqualTo(new List<int> { 15, 7, 12, 10, 11 }));
					Assert.That(MaxMinArraysTask.Solve(new List<int> { 91, 75, 86, 14, 82 }), Is.EqualTo(new List<int> { 91, 14, 86, 75, 82 }));
					Assert.That(MaxMinArraysTask.Solve(new List<int> { 84, 79, 76, 61, 78 }), Is.EqualTo(new List<int> { 84, 61, 79, 76, 78 }));
					Assert.That(MaxMinArraysTask.Solve(new List<int> { 52, 77, 72, 44, 74, 76, 40 }), Is.EqualTo(new List<int> { 77, 40, 76, 44, 74, 52, 72 }));
					Assert.That(MaxMinArraysTask.Solve(new List<int> { 1, 6, 9, 4, 3, 7, 8, 2 }), Is.EqualTo(new List<int> { 9, 1, 8, 2, 7, 3, 6, 4 }));
					Assert.That(MaxMinArraysTask.Solve(new List<int> { 78, 79, 52, 87, 16, 74, 31, 63, 80 }), Is.EqualTo(new List<int> { 87, 16, 80, 31, 79, 52, 78, 63, 74 }));
				}

				[Test]
				public static void TestFixed()
				{
					void Tester(string day, int num, bool expected)
					{
						bool submitted = SelectiveFearOfNumbersTask.AmIAfraid(day, num);
						string message = $"day = \"{day}\"\n  num = {num}";
						Assert.AreEqual(expected, submitted, message);
					}

					Tester("Monday", 13, false);
					Tester("Sunday", -666, true);
					Tester("Tuesday", 2, false);
					Tester("Tuesday", 965, true);
					Tester("Friday", 2, true);
				}

				[Test]
				public void SeeYouNextHappyYearTest()
				{
					SeeYouNextHappyYearTask kata = new SeeYouNextHappyYearTask();

					Assert.AreEqual(kata.NextHappyYear(1001), 1023);
					Assert.AreEqual(kata.NextHappyYear(1123), 1203);
					Assert.AreEqual(kata.NextHappyYear(2001), 2013);
					Assert.AreEqual(kata.NextHappyYear(2334), 2340);
					Assert.AreEqual(kata.NextHappyYear(3331), 3401);
					Assert.AreEqual(kata.NextHappyYear(2342), 2345);
					Assert.AreEqual(kata.NextHappyYear(1987), 2013);
					Assert.AreEqual(kata.NextHappyYear(2013), 2014);
					Assert.AreEqual(kata.NextHappyYear(3000), 3012);
				}

				[Test]
				public void FixMyPhoneNumbersTest()
				{
					Assert.AreEqual("02078834982", FixMyPhoneNumbersTask.IsItANum("S:)0207ERGQREG88349F82!efRF)"));
					Assert.AreEqual("Not a phone number", FixMyPhoneNumbersTask.IsItANum("sjfniebienvr12312312312ehfWh"));
					Assert.AreEqual("Not a phone number", FixMyPhoneNumbersTask.IsItANum("0192387415456"));
					Assert.AreEqual("02084564165", FixMyPhoneNumbersTask.IsItANum("v   uf  f 0tt2eg qe0b 8rtyq4eyq564()(((((165"));
					Assert.AreEqual("Not a phone number", FixMyPhoneNumbersTask.IsItANum("stop calling me no I have never been in an accident"));
				}

				[Test]
				public void GhostbustersWhitespaceRemovalTest()
				{
					Assert.AreEqual("Factory", GhostbustersWhitespaceRemovalTask.GhostBusters("Factor y"), "Nope, there may still be a ghost in the building. Try again.");
					Assert.AreEqual("Office", GhostbustersWhitespaceRemovalTask.GhostBusters("O  f fi ce"), "Nope, there may still be a ghost in the building. Try again.");
					Assert.AreEqual("You just wanted my autograph didn't you?", GhostbustersWhitespaceRemovalTask.GhostBusters("BusStation"), "Nope, as there were no ghosts in the BusStation you need to return a witty retort.");
				}

				[Test]
                public void WeHaveLiftoffTest()
                {
					Assert.AreEqual("10 9 8 7 6 5 4 3 2 1 liftoff!", WeHaveLiftoffTask.Liftoff(new List<int> { 2, 8, 10, 9, 1, 3, 4, 7, 6, 5 }));

				}
				[Test]
				public void VeryEvenNumbersTest()
				{
					Assert.AreEqual(true, VeryEvenNumbersTask.IsVeryEvenNumber(4));
					Assert.AreEqual(true, VeryEvenNumbersTask.IsVeryEvenNumber(0));
					Assert.AreEqual(true, VeryEvenNumbersTask.IsVeryEvenNumber(400000220));
					Assert.AreEqual(false, VeryEvenNumbersTask.IsVeryEvenNumber(12));
					Assert.AreEqual(true, VeryEvenNumbersTask.IsVeryEvenNumber(222));
					Assert.AreEqual(false, VeryEvenNumbersTask.IsVeryEvenNumber(5));
					Assert.AreEqual(false, VeryEvenNumbersTask.IsVeryEvenNumber(45));
					Assert.AreEqual(false, VeryEvenNumbersTask.IsVeryEvenNumber(1234));
				}

				[Test]
				public void TwoNumbersArePositiveTest()
				{
					Assert.AreEqual(true, TwoNumbersArePositiveTask.TwoArePositive(2, 4, -3), "(2, 4, -3)");
					Assert.AreEqual(true, TwoNumbersArePositiveTask.TwoArePositive(-4, 6, 8), "(-4, 6, 8)");
					Assert.AreEqual(true, TwoNumbersArePositiveTask.TwoArePositive(4, -6, 9), "(4, -6, 9)");
					Assert.AreEqual(true, TwoNumbersArePositiveTask.TwoArePositive(4, 6, 0), "(4, 6, 0)");
					Assert.AreEqual(false, TwoNumbersArePositiveTask.TwoArePositive(-4, 6, 0), "(-4, 6, 0)");
					Assert.AreEqual(false, TwoNumbersArePositiveTask.TwoArePositive(4, 6, 10), "(4, 6, 10)");
					Assert.AreEqual(false, TwoNumbersArePositiveTask.TwoArePositive(-14, -3, -4), "(-14, -3, -4)");
				}

				[Test]
				public void MaximumGapTest()
                {
					Assert.AreEqual(4, MaximumGapTask.MaxGap(new int[] { 13, 10, 2, 9, 5 }));
					Assert.AreEqual(8, MaximumGapTask.MaxGap(new int[] { 13, 3, 5 }));
					Assert.AreEqual(168, MaximumGapTask.MaxGap(new int[] { 24, 299, 131, 14, 26, 25 }));
					Assert.AreEqual(767, MaximumGapTask.MaxGap(new int[] { -7, -42, -809, -14, -12 }));
					Assert.AreEqual(0, MaximumGapTask.MaxGap(new int[] { 1, 1, 1 }));
					Assert.AreEqual(576, MaximumGapTask.MaxGap(new int[] { -54, 37, 0, 64, -15, 640, 0 }));

				}

				[Test]
				public void SpeedControlTest()
				{
					Assert.AreEqual(41, SpeedControlTask.Gps(20, new double[] { 0.0, 0.23, 0.46, 0.69, 0.92, 1.15, 1.38, 1.61 }));
					Assert.AreEqual(219, SpeedControlTask.Gps(12, new double[] { 0.0, 0.11, 0.22, 0.33, 0.44, 0.65, 1.08, 1.26, 1.68, 1.89, 2.1, 2.31, 2.52, 3.25 }));
					Assert.AreEqual(80, SpeedControlTask.Gps(20, new double[] { 0.0, 0.18, 0.36, 0.54, 0.72, 1.05, 1.26, 1.47, 1.92, 2.16, 2.4, 2.64, 2.88, 3.12, 3.36, 3.6, 3.84 }));
					Assert.AreEqual(90, SpeedControlTask.Gps(14, new double[] { 0.0, 0.01, 0.36, 0.6, 0.84, 1.05, 1.26, 1.47, 1.68, 1.89, 2.1, 2.31, 2.52, 2.73, 2.94, 3.15 }));
					Assert.AreEqual(72, SpeedControlTask.Gps(17, new double[] { 0.0, 0.02, 0.36, 0.54, 0.72, 0.9, 1.08, 1.26, 1.44, 1.62, 1.8 }));
					Assert.AreEqual(72, SpeedControlTask.Gps(12, new double[] { 0.0, 0.24, 0.48, 0.72, 0.96, 1.2, 1.44, 1.68, 1.92, 2.16, 2.4 }));
					Assert.AreEqual(88, SpeedControlTask.Gps(17, new double[] { 0.0, 0.02, 0.44, 0.66, 0.88, 1.1, 1.32, 1.54, 1.76 }));
					Assert.AreEqual(76, SpeedControlTask.Gps(16, new double[] { 0.0, 0.2, 0.4, 0.6, 0.8, 1.0, 1.32, 1.54, 1.76, 1.98, 2.2, 2.42, 2.76, 2.99, 3.22, 3.45 }));
					Assert.AreEqual(82, SpeedControlTask.Gps(17, new double[] { 0.0, 0.01, 0.36, 0.75, 1.0, 1.25, 1.5, 1.75, 2.0, 2.25, 2.5, 2.75, 3.0, 3.25, 3.5, 3.75, 4.0, 4.25, 4.5, 4.75 }));
					Assert.AreEqual(58, SpeedControlTask.Gps(19, new double[] { 0.0, 0.2, 0.4, 0.69, 0.92, 1.15, 1.38, 1.61, 1.92, 2.16, 2.4, 2.64, 2.88, 3.12, 3.36 }));
					Assert.AreEqual(0, SpeedControlTask.Gps(19, new double[] { }));
					Assert.AreEqual(0, SpeedControlTask.Gps(19, new double[] { 0.0 }));
				}

				[Test]
				public void FindAllOccurrencesTest()
				{
					Assert.AreEqual(new int[] { 2, 4 }, FindAllOccurrencesTask.FindAll(new int[] { 6, 9, 3, 4, 3, 82, 11 }, 3));
					Assert.AreEqual(new int[] { 1, 9 }, FindAllOccurrencesTask.FindAll(new int[] { 10, 16, 20, 6, 14, 11, 20, 2, 17, 16, 14 }, 16));
					Assert.AreEqual(new int[] { 0, 1, 8 }, FindAllOccurrencesTask.FindAll(new int[] { 20, 20, 10, 13, 15, 2, 7, 2, 20, 3, 18, 2, 3, 2, 16, 10, 9, 9, 7, 5, 15, 5 }, 20));
				}

				[Test]
				public void BrokenPhotocopierTest()
				{
					Assert.AreEqual("0", BrokenPhotocopierTask.Broken("1"));
					Assert.AreEqual("01111111010010000001100110111", BrokenPhotocopierTask.Broken("10000000101101111110011001000"));
					Assert.AreEqual("011101", BrokenPhotocopierTask.Broken("100010"));
				}

				[Test]
				public void AreaOfACircleTest()
				{
					Assert.AreEqual(3.141, AreaOfACircleTask.CalculateAreaOfCircle(1), 0.01);
					Assert.AreEqual(5881.248, AreaOfACircleTask.CalculateAreaOfCircle(43.2673), 0.01);
					Assert.AreEqual(14526.724, AreaOfACircleTask.CalculateAreaOfCircle(68), 0.01);
					Assert.Throws<ArgumentException>(() => AreaOfACircleTask.CalculateAreaOfCircle(0));
					Assert.Throws<ArgumentException>(() => AreaOfACircleTask.CalculateAreaOfCircle(-1));


				}

				[Test]
				public void CalculateTwoPeopleIndividualAgesTest()
				{
					Assert.AreEqual(new double[] { 14, 10 }, CalculateTwoPeopleIndividualAgesTask.GetAges(24, 4), "it returns {14, 10} when passed 24, 4");
					Assert.AreEqual(new double[] { 38.5, 24.5 }, CalculateTwoPeopleIndividualAgesTask.GetAges(63, 14), "it returns {38.5, 24.5} when passed 63, 14");
					Assert.AreEqual(null, CalculateTwoPeopleIndividualAgesTask.GetAges(63, -14), "it returns null when passed 63, -14");
				}

				[Test]
				public void CorrectTheTimeStringTest()
				{
					Assert.AreEqual("09:10:01", CorrectTheTimeStringTask.Correct("09:10:01"));
					Assert.AreEqual("12:10:10", CorrectTheTimeStringTask.Correct("11:70:10"));
					Assert.AreEqual("20:40:39", CorrectTheTimeStringTask.Correct("19:99:99"));
					Assert.AreEqual("00:01:01", CorrectTheTimeStringTask.Correct("24:01:01"));
					Assert.AreEqual("04:01:01", CorrectTheTimeStringTask.Correct("52:01:01"));

					Assert.AreEqual(null, CorrectTheTimeStringTask.Correct("001122"));
					Assert.AreEqual(null, CorrectTheTimeStringTask.Correct("00;11;22"));
					Assert.AreEqual(null, CorrectTheTimeStringTask.Correct("0a:1c:22"));

					Assert.AreEqual("", CorrectTheTimeStringTask.Correct(""));

					Assert.AreEqual(null, CorrectTheTimeStringTask.Correct(null));

				}

				[Test]
				public void RegexpBasicsIsItAVowelTest()
				{
					Assert.AreEqual(false, RegexpBasicsIsItAVowelTask.Vowel(""));
					Assert.AreEqual(true, RegexpBasicsIsItAVowelTask.Vowel("a"));
					Assert.AreEqual(true, RegexpBasicsIsItAVowelTask.Vowel("E"));
					Assert.AreEqual(false, RegexpBasicsIsItAVowelTask.Vowel("ou"));
					Assert.AreEqual(false, RegexpBasicsIsItAVowelTask.Vowel("z"));
					Assert.AreEqual(false, RegexpBasicsIsItAVowelTask.Vowel("lol"));

				}

				[Test]
				public void lastDigitsOfANumberTest()
				{
					Assert.AreEqual(new[] { 1 }, lastDigitsOfANumberTask.LastDigit(1, 1));
					Assert.AreEqual(new[] { 3, 7, 6, 7 }, lastDigitsOfANumberTask.LastDigit(123767, 4));
					Assert.AreEqual(new[] { 0 }, lastDigitsOfANumberTask.LastDigit(0, 1));
					Assert.AreEqual(new[] { 5, 6, 4, 7, 8, 6, 7, 5, 8, 5 }, lastDigitsOfANumberTask.LastDigit(34625647867585, 10));
					Assert.AreEqual(new int[] { }, lastDigitsOfANumberTask.LastDigit(1234, 0));
					Assert.AreEqual(new int[] { }, lastDigitsOfANumberTask.LastDigit(24134, -4));
					Assert.AreEqual(new[] { 1, 3, 4, 3 }, lastDigitsOfANumberTask.LastDigit(1343, 5));
				}

				[Test]
				public void FindTheLuckyNumbersTest()
				{
					Assert.AreEqual(new int[] { 7, 70, 17 }, FindTheLuckyNumbersTask.FilterLucky(new int[] { 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17 }));
					Assert.AreEqual(new int[] { }, FindTheLuckyNumbersTask.FilterLucky(new int[] { }));
				}

				[Test]
				public void UnscrambledEggsTest()
				{
					Assert.AreEqual("code here", UnscrambledEggsTask.UnscrambleEggs("ceggodegge heggeregge"));
					Assert.AreEqual("FUN KATA", UnscrambledEggsTask.UnscrambleEggs("FeggUNegg KeggATeggA"));
				}

				[Test]
				public void GenericTests()
				{
					Assert.AreEqual("c:**,h:*,i:*,a:*,g:*,o:*", InterviewQuestionTask.GetStrings("Chicago"));
					Assert.AreEqual("b:*,a:*,n:*,g:*,k:**,o:*", InterviewQuestionTask.GetStrings("Bangkok"));
					Assert.AreEqual("l:*,a:**,s:**,v:*,e:*,g:*", InterviewQuestionTask.GetStrings("Las Vegas"));
				}

				[Test]
				public void LetterboxPaintSquadTest()
				{
					Assert.AreEqual(new int[] { 1, 9, 6, 3, 0, 1, 1, 1, 1, 1 }, LetterboxPaintSquadTask.PaintLetterBoxes(125, 132).ToArray());
				}

				[Test]
				public void DotCalculatorTest()
				{
					Assert.AreEqual("....................", DotCalculatorTask.Calculator("..... + ..............."));
					Assert.AreEqual("..", DotCalculatorTask.Calculator("..... - ..."));
					Assert.AreEqual("....", DotCalculatorTask.Calculator("..... - ."));
					Assert.AreEqual("...............", DotCalculatorTask.Calculator("..... * ..."));
					Assert.AreEqual("..........", DotCalculatorTask.Calculator("..... * .."));
					Assert.AreEqual("..", DotCalculatorTask.Calculator("..... // .."));
					Assert.AreEqual(".....", DotCalculatorTask.Calculator("..... // ."));
					Assert.AreEqual("", DotCalculatorTask.Calculator(". // .."));
					Assert.AreEqual("", DotCalculatorTask.Calculator(". - ."));
				}

				[Test]
				public void SampleTest()
				{
					Assert.AreEqual(true, NiceArrayTask.IsNice(new int[] { 2, 10, 9, 3 }));
					Assert.AreEqual(false, NiceArrayTask.IsNice(new int[] { 3, 4, 5, 7 }));
				}

				[Test]
				public static void PreviousMultipleOfThreeTest() 
                { 
					Assert.AreEqual(null, PreviousMultipleOfThreeTask.PreviousMultipleOfThree(1));
					Assert.AreEqual(null, PreviousMultipleOfThreeTask.PreviousMultipleOfThree(25));
					Assert.AreEqual(36, PreviousMultipleOfThreeTask.PreviousMultipleOfThree(36));
					Assert.AreEqual(12, PreviousMultipleOfThreeTask.PreviousMultipleOfThree(1244));
					Assert.AreEqual(9, PreviousMultipleOfThreeTask.PreviousMultipleOfThree(952406));
				}

				[Test]
				public static void AllInclusiveTest()
				{
					List<string> a = new List<string>() { "bsjq", "qbsj", "sjqb", "twZNsslC", "jqbs" };
					testing(AllInclusiveTask.ContainAllRots("bsjq", a), true);
					a = new List<string>() { };
					testing(AllInclusiveTask.ContainAllRots("", a), true);
					a = new List<string>() { "bsjq", "qbsj" };
					testing(AllInclusiveTask.ContainAllRots("", a), true);
					a = new List<string>() { "TzYxlgfnhf", "yqVAuoLjMLy", "BhRXjYA", "YABhRXj", "hRXjYAB", "jYABhRX", "XjYABhR", "ABhRXjY" };
					testing(AllInclusiveTask.ContainAllRots("XjYABhR", a), false);

					static void testing(bool actual, bool expected)
					{
						Assert.AreEqual(expected, actual);
					}
				}

				[Test]
				public void JumpingNumberTest()
				{
					Assert.That(JumpingNumberTask.JumpingNumber(00000079), Is.EqualTo("Not!!"));
					Assert.That(JumpingNumberTask.JumpingNumber(98789876), Is.EqualTo("Jumping!!"));
				}

				[Test]
				public void SumAListButIgnoreAnyDuplicatesTest()
				{
					Assert.AreEqual(5, SumAListButIgnoreAnyDuplicatesTask.SumNoDuplicates(new int[] { 1, 1, 2, 3 }));
					Assert.AreEqual(3, SumAListButIgnoreAnyDuplicatesTask.SumNoDuplicates(new int[] { 1, 1, 2, 2, 3 }));
				}

				[Test]
				public void HellsKitchenTest()
				{
					Assert.AreEqual("WH@T!!!! F*CK!!!! D@MN!!!! C@K*!!!!", HellsKitchenTask.Gordon("What feck damn cake"));
					Assert.AreEqual("@R*!!!! Y**!!!! ST*!!!! P*D!!!!", HellsKitchenTask.Gordon("are you stu pid"));
					Assert.AreEqual("*!!!! @M!!!! @!!!! CH*F!!!!", HellsKitchenTask.Gordon("i am a chef"));
				}

				[Test]
				public static void NthRootOfANumberTest()
				{
					double actual1 = NthRootOfANumberTask.FindRoot(4, 2);
					double actual2 = NthRootOfANumberTask.FindRoot(8, 3);
					Assert.AreEqual(2, actual2, 1e-9);
					Assert.AreEqual(2, actual1, 1e-9);
				}

				[Test]
				public void EvenOrOddWhichIsGreaterTest()
				{
					Assert.AreEqual("Odd is greater than Even", EvenOrOddWhichIsGreaterTask.EvenOrOdd("123"));
					Assert.AreEqual("Even is greater than Odd", EvenOrOddWhichIsGreaterTask.EvenOrOdd("12"));
					Assert.AreEqual("Even and Odd are the same", EvenOrOddWhichIsGreaterTask.EvenOrOdd("112"));
				}

				[Test]
				public void CalculateMeanAndConcatenateStringTest()
				{
					var lst1 = new[] { 'u', '6', 'd', '1', 'i', 'w', '6', 's', 't', '4', 'a', '6', 'g', '1', '2', 'w', '8', 'o', '2', '0' };
					Assert.AreEqual(new object[] { 3.6, "udiwstagwo" }, CalculateMeanAndConcatenateStringTask.Mean(lst1));

					var lst2 = new[] { '0', 'c', '7', 'x', '6', '2', '3', '5', 'w', '7', '0', 'y', 'v', 'u', 'h', 'i', 'n', 'u', '0', '0' };
					Assert.AreEqual(new object[] { 3.0, "cxwyvuhinu" }, CalculateMeanAndConcatenateStringTask.Mean(lst2));

					var lst3 = new[] { '0', 'u', 'a', 'y', '0', 'a', '9', 'q', '3', 'v', 'g', '7', '6', '4', 'y', 'd', '8', '6', '0', 'd' };
					Assert.AreEqual(new object[] { 4.3, "uayaqvgydd" }, CalculateMeanAndConcatenateStringTask.Mean(lst3));

					var lst4 = new[] { 's', 'n', '9', 'l', '0', 'm', 'i', 'z', '9', '7', 'y', '4', 'z', '3', '3', 'k', '4', '1', '0', 'k' };
					Assert.AreEqual(new object[] { 4.0, "snlmizyzkk" }, CalculateMeanAndConcatenateStringTask.Mean(lst4));

					var lst5 = new[] { '5', 'v', 'u', 'k', '8', '4', '9', 'b', '9', 'g', '5', 'z', '3', 'f', '6', 'u', 'i', '6', '6', 't' };
					Assert.AreEqual(new object[] { 6.1, "vukbgzfuit" }, CalculateMeanAndConcatenateStringTask.Mean(lst5));

					var lst6 = new[] { '1', '1', '1', '1', '1', '1', '1', '1', '1', '0', 'a', 'a', 'd', 'd', 'g', 'q', 'u', 'v', 'y', 'y' };
					Assert.AreEqual(new object[] { 0.9, "aaddgquvyy" }, CalculateMeanAndConcatenateStringTask.Mean(lst6));

					var lst7 = new[] { '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', 'a', 'a', 'd', 'd', 'g', 'q', 'u', 'v', 'y', 'y' };
					Assert.AreEqual(new object[] { 1.0, "aaddgquvyy" }, CalculateMeanAndConcatenateStringTask.Mean(lst7));
				}

				[Test]
				public void PartialWordSearchingTest()
				{
					Assert.AreEqual(new string[] { "ab", "abc", "zab" }, PartialWordSearchingTask.WordSearch("ab", new string[] { "za", "ab", "abc", "zab", "zbc" }));
					Assert.AreEqual(new string[] { "ab", "abc", "zab" }, PartialWordSearchingTask.WordSearch("aB", new string[] { "za", "ab", "abc", "zab", "zbc" }));
					Assert.AreEqual(new string[] { "aB", "Abc", "zAB" }, PartialWordSearchingTask.WordSearch("ab", new string[] { "za", "aB", "Abc", "zAB", "zbc" }));
					Assert.AreEqual(new string[] { "Empty" }, PartialWordSearchingTask.WordSearch("abcd", new string[] { "za", "aB", "Abc", "zAB", "zbc" }));
				}

				[Test]
                public void SearchForLettersTest() 
                {
					Assert.AreEqual("11000000000000000000000001", SearchForLettersTask.Change("a **&  bZ"));
					Assert.AreEqual("10000010000000000101000000", SearchForLettersTask.Change("!!a$%&RgTT"));

				}

				[Test]
				public void WhoIsOnlineTest()
				{
					User[] friends = new User[]
					{
		new User("David", UserStatus.Online, 10),
		new User("Lucy", UserStatus.Offline, 22),
		new User("Bob", UserStatus.Online, 104)
					};
					var expected = new Dictionary<UserStatus, IEnumerable<string>>
	  {
		{UserStatus.Online, new[] {"David"}},
		{UserStatus.Offline, new[] {"Lucy"}},
		{UserStatus.Away, new[] {"Bob"}}
	  };
					Assert.That(User.WhosOnline(friends), Is.EqualTo(expected));
				}

				[Test]
				public void HeronFormulaTest()
				{

					Assert.AreEqual(6.0, HeronFormulaTask.Heron(3, 4, 5));
					Assert.AreEqual(24.0, HeronFormulaTask.Heron(6, 8, 10));

				}

				[Test]
				public void IsNDivisibleTest()
				{
					Assert.AreEqual(false, IsNDivisibleTask.IsDivisible(3, 3, 4));
					Assert.AreEqual(true, IsNDivisibleTask.IsDivisible(12, 3, 4));

				}

				[Test]
                public void ReturnSubstringTest() 
                {
					Assert.AreEqual(2, ReturnSubstringTask.SubstringCount("abcdeb", "b"));
					Assert.AreEqual(1, ReturnSubstringTask.SubstringCount("abcdeb", "a"));
					Assert.AreEqual(3, ReturnSubstringTask.SubstringCount("ccddeeccddeecc", "cc"));

				}


				[Test]
				public void CountConsonantsTest()
				{
					Assert.AreEqual(0, CountConsonantsTask.ConsonantCount(""));
					Assert.AreEqual(0, CountConsonantsTask.ConsonantCount("aaaaa"));
					Assert.AreEqual(7, CountConsonantsTask.ConsonantCount("helLo world"));
					Assert.AreEqual(0, CountConsonantsTask.ConsonantCount("012456789"));
					Assert.AreEqual(2, CountConsonantsTask.ConsonantCount("012345_Cb"));
				}

				[Test]
				public void EnumerableMagicFiveTest()
				{
					Assert.AreEqual(true, EnumerableMagicFiveTask.One(new int[] { 1, 2, 3, 4, 5 }, v => v < 2));
					Assert.AreEqual(false, EnumerableMagicFiveTask.One(new int[] { 1, 2, 3, 4, 5 }, v => v % 2 != 0));
					Assert.AreEqual(false, EnumerableMagicFiveTask.One(new int[] { 1, 2, 3, 4, 5 }, v => v > 5));
				}

				[Test]
				public void ProductOfMaximumsOfArrayTest()
				{
					Assert.AreEqual(20, ProductOfMaximumsOfArrayTask.MaxProduct(new int[] { 4, 3, 5 }, 2));
					Assert.AreEqual(720,ProductOfMaximumsOfArrayTask.MaxProduct(new int[] { 10, 8, 7, 9 }, 3));
					Assert.AreEqual(288, ProductOfMaximumsOfArrayTask.MaxProduct(new int[] { 8, 6, 4, 6 }, 3));
					Assert.AreEqual(9600, ProductOfMaximumsOfArrayTask.MaxProduct(new int[] { 10, 2, 3, 8, 1, 10, 4 }, 5));
					Assert.AreEqual(247895375, ProductOfMaximumsOfArrayTask.MaxProduct(new int[] { 13, 12, -27, -302, 25, 37, 133, 155, -14 }, 5));
					Assert.AreEqual(4, ProductOfMaximumsOfArrayTask.MaxProduct(new int[] { -4, -27, -15, -6, -1 }, 2));
					Assert.AreEqual(136, ProductOfMaximumsOfArrayTask.MaxProduct(new int[] { -17, -8, -102, -309 }, 2));
					Assert.AreEqual(-30, ProductOfMaximumsOfArrayTask.MaxProduct(new int[] { 10, 3, -27, -1 }, 3));
					Assert.AreEqual(-253344, ProductOfMaximumsOfArrayTask.MaxProduct(new int[] { 14, 29, -28, 39, -16, -48 }, 4));
					Assert.AreEqual(1, ProductOfMaximumsOfArrayTask.MaxProduct(new int[] { 1 }, 1));
				}

				[Test]
                public void DryingPotatoesTest()
                {
					Assert.AreEqual(114, DryingPotatoesTask.Potatoes(82, 127, 80));
					Assert.AreEqual(100, DryingPotatoesTask.Potatoes(93, 129, 91));

				}

				[Test]
				public void HelpBobCountTest()
				{
					Assert.AreEqual(7, HelpBobCountTask.CountLettersAndDigits("n!!ice!!123"));
				}

				[Test]
				public void PlusMinusCountTest()
				{
					Assert.AreEqual(1, PlusMinusCountTask.CatchSignChange(new int[] { 2, 6, 3, 0, 5, -3 }));
					Assert.AreEqual(1, PlusMinusCountTask.CatchSignChange(new int[] { -2, -2, -5, -4, 5, 2, 0, 6, 0 }));
					Assert.AreEqual(2, PlusMinusCountTask.CatchSignChange(new int[] { 3, 7, -6, 2, 3, 1, 1 }));
                    Assert.AreEqual(2, PlusMinusCountTask.CatchSignChange(new int[] { -1, 2, 2, 0, 2, -8, -1 }));
					Assert.AreEqual(3, PlusMinusCountTask.CatchSignChange(new int[] { -47, 84, -30, -11, -5, 74, 77 }));
                    Assert.AreEqual(4, PlusMinusCountTask.CatchSignChange(new int[] { -8, 4, -1, 5, -3, -3, -2, -2 }));

				}

				[Test]
				public void TailSwapTest()
				{
					Assert.AreEqual(new[] { "a:d", "c:b" }, TailSwapTask.TailSwap(new[] { "a:b", "c:d" }));
					Assert.AreEqual(new[] { "1:4", "3:2" }, TailSwapTask.TailSwap(new[] { "1:2", "3:4" }));
					Assert.AreEqual(new[] { "abc:456", "cde:123" }, TailSwapTask.TailSwap(new[] { "abc:123", "cde:456" }));
					Assert.AreEqual(new[] { "a:xyz", "777:12345" }, TailSwapTask.TailSwap(new[] { "a:12345", "777:xyz" }));
					Assert.AreEqual(new[] { "(:]", "[:)" }, TailSwapTask.TailSwap(new[] { "(:)", "[:]" }));
					Assert.AreEqual(new[] { ",:,", ",:;" }, TailSwapTask.TailSwap(new[] { ",:;", ",:," }));
				}

				[Test]
                public void ChangingLettersTest()
                {
					Assert.AreEqual("HEllOWOrld!", ChangingLettersTask.Swap("HelloWorld!"));
					Assert.AreEqual("SUndAy", ChangingLettersTask.Swap("Sunday"));


				}

			    [Test]
				public void BasicSequencePracticeTest()
				{
					int input = 3;
					int[] expected = new int[] { 0, 1, 3, 6 };

					int[] actual = BasicSequencePracticeTask.SumOfN(input);

					Assert.AreEqual(expected, actual);

				}

				[Test]
				public void BasicCalculatorTest()
				{
					Assert.AreEqual(-4.8, BasicCalculatorTask.Execute(3.2, '-', 8));
					Assert.AreEqual(11.2, BasicCalculatorTask.Execute(3.2, '+', 8));
					Assert.AreEqual(0.4, BasicCalculatorTask.Execute(3.2, '/', 8));
					Assert.AreEqual(25.6, BasicCalculatorTask.Execute(3.2, '*', 8));
					Assert.Throws<ArgumentException>(() => BasicCalculatorTask.Execute(-3, 'w', 1));
				}


				[Test]
				public void ArrayLeadersTest()
                {
					Assert.AreEqual(new int[] { 4 }, ArrayLeadersTask.ArrayLeaders(new int[] { 1, 2, 3, 4, 0 }));
					Assert.AreEqual(new int[] { 17, 5, 2 }, ArrayLeadersTask.ArrayLeaders(new int[] { 16, 17, 4, 3, 5, 2 }));

				}

				[Test]
				public void InsertDashesTest()
				{
					Assert.AreEqual("4547-9-3", InsertDashesTask.InsertDash(454793));
					Assert.AreEqual("123456", InsertDashesTask.InsertDash(123456));
					Assert.AreEqual("1003-567", InsertDashesTask.InsertDash(1003567));
				}

				[Test]
				public void SayHelloTest()
				{
					Assert.AreEqual(SayHelloTask.Greet("Niks"), "hello Niks!");
					Assert.AreEqual(SayHelloTask.Greet(""), null);
					Assert.AreEqual(SayHelloTask.Greet(null), null);
				}

				[Test]
				public void LengthAndTwoTest()
				{
					Assertion(new object[] { true, false, true, false, true }, (5, true, false));
					Assertion(new object[] { "blue", "red", "blue", "red", "blue", "red", "blue", "red", "blue", "red", "blue", "red", "blue", "red", "blue", "red", "blue", "red", "blue", "red" }, (20, "blue", "red"));
					Assertion(new object[0], (0, "lemons", "apples"));

					void Assertion(object[] expected, (int, object, object) inputs)
                    {
                        object[] actual = LengthAndTwoTask.Alternate(inputs.Item1, inputs.Item2, inputs.Item3);
                        Assert.AreEqual(
                          expected,
                          actual,

                          $"\n  n = {inputs.Item1}" +
                          $"\n  firstValue = {inputs.Item2}" +
                          $"\n  secondValue = {inputs.Item3}\n" +
                          $"\n  Expected = [{string.Join(", ", expected)}]" +
                          $"\n  Actual = [{string.Join(", ", actual)}]\n"

                        );
                    }
				}

				[Test]
				public void BasicTests()
				{
					var scores = new int[] { 49, 3, 5, 300, 7 };
					Assert.AreEqual(73, AverageScoresTask.Average(scores));

					scores = new int[] { 90, 98, 89, 100, 100, 86, 94 };
					Assert.AreEqual(94, AverageScoresTask.Average(scores));
				}

				[Test]
				public void CleanUpTest()
				{
					Assert.AreEqual("Clean", CleanUpTask.Crap(new char[,] { { '_', '_', '_', '_' }, { '_', '_', '_', '@' }, { '_', '_', '@', '_' } }, 2, 2));
					Assert.AreEqual("Cr@p", CleanUpTask.Crap(new char[,] { { '_', '_', '_', '_' }, { '_', '_', '_', '@' }, { '_', '_', '@', '_' } }, 1, 1));
					Assert.AreEqual("Dog!!", CleanUpTask.Crap(new char[,] { { '_', '_' }, { '_', '@' }, { 'D', '_' } }, 2, 2));
				}

				[Test]
				public void FormattingDecimalPlacesTest()
				{
					Assert.AreEqual(10.12, FormattingDecimalPlacesTask.TwoDecimalPlaces(10.1289767789));
					Assert.AreEqual(-7488.83, FormattingDecimalPlacesTask.TwoDecimalPlaces(-7488.83485834983));

				}

				[Test]
                public void SampleTests()
                {
                    TestToValidSpacingTask(true, "Hello world");
                    TestToValidSpacingTask(false, " Hello world");
                    TestToValidSpacingTask(false, "Hello world ");
                    TestToValidSpacingTask(true, "Hello");
                    TestToValidSpacingTask(true, "Helloworld");

                    void TestToValidSpacingTask(bool solution, string input)
                    {
                        Assert.AreEqual(solution, ValidSpacingTask.ValidSpacing(input), $"Incorrect answer for input \"{input}\"");
                    }
                }

                [Test]
                public void ToTimeTest()
                {
                    Act(3600, "1 hour(s) and 0 minute(s)");
                    Act(3601, "1 hour(s) and 0 minute(s)");
                    Act(3500, "0 hour(s) and 58 minute(s)");
                    Act(323500, "89 hour(s) and 51 minute(s)");
                    Act(0, "0 hour(s) and 0 minute(s)");

                    static void Act(int seconds, string expected)
                    {
                        var actual = ToTimeTask.ToTime(seconds);
                        Console.WriteLine($"   Input: seconds = {seconds}\nExpected: {expected}\n  Actual: {actual}\n");
                        Assert.AreEqual(expected, actual, $"Input: seconds = {seconds}");
                    }
                }

                [Test]
                public void HowManyConsecutiveTest()
                {
                    Assert.AreEqual(2, HowManyConsecutiveTask.Consecutive(new int[] { 4, 8, 6 }));
                    Assert.AreEqual(0, HowManyConsecutiveTask.Consecutive(new int[] { 1, 2, 3, 4 }));
                    Assert.AreEqual(0, HowManyConsecutiveTask.Consecutive(new int[] { }));
                    Assert.AreEqual(0, HowManyConsecutiveTask.Consecutive(new int[] { 1 }));
                }

                [Test]
                public void SimpleRemoveDuplicatesTest()
                {
                    Assert.AreEqual(new int[] { 4, 6, 3 }, SimpleRemoveDuplicatesTask.solve(new int[] { 3, 4, 4, 3, 6, 3 }));
                    Assert.AreEqual(new int[] { 1, 2, 3 }, SimpleRemoveDuplicatesTask.solve(new int[] { 1, 2, 1, 2, 1, 2, 3 }));
                    Assert.AreEqual(new int[] { 1, 2, 3, 4 }, SimpleRemoveDuplicatesTask.solve(new int[] { 1, 2, 3, 4 }));
                    Assert.AreEqual(new int[] { 4, 5, 2, 1 }, SimpleRemoveDuplicatesTask.solve(new int[] { 1, 1, 4, 5, 1, 2, 1 }));
                }

                [Test]
                public void BasicMathTest()
                {
                    Test("10", "1plus2plus3plus4");
                    Test("-8", "1minus2minus3minus4");
                    Test("2", "1plus2plus3minus4");
                    Test("-2", "1minus2plus3minus4");
                    Test("-1", "1plus2minus3plus4minus5");

                     void Test(string solution, string input)
                    {
                        Assert.AreEqual(solution, BasicMathTask.Calculate(input), $"Incorrect answer for input \"{input}\"");
                    }
                }

                [Test]
                public void InitializeMyNameTest()
                {
                    Assert.AreEqual("Jack Ryan", InitializeMyNameTask.InitializeNames("Jack Ryan"));
                    Assert.AreEqual("Lois M. Lane", InitializeMyNameTask.InitializeNames("Lois Mary Lane"));
                    Assert.AreEqual("Dimitri", InitializeMyNameTask.InitializeNames("Dimitri"));
                    Assert.AreEqual("Alice B. C. Davis", InitializeMyNameTask.InitializeNames("Alice Betty Catherine Davis"));
                }

                [Test]
                public void HowManyArgumentsTest()
                {
                    Assert.AreEqual(3, HowManyArgumentsTask.CountArgs(1, 2, 3));
                    Assert.AreEqual(3, HowManyArgumentsTask.CountArgs(1, 2, "uhsaf uas"));
                    Assert.AreEqual(1, HowManyArgumentsTask.CountArgs(1));
                    Assert.AreEqual(4, HowManyArgumentsTask.CountArgs('a', 865, "asfhgajsf", new object[] { "dawdjio", null, new List<object>() }));
                    Assert.AreEqual(0, HowManyArgumentsTask.CountArgs());
                }

                [Test]
                public void RowWeightsTest()
                {
                    Assert.AreEqual(new int[] {0,0}, RowWeightsTask.RowWeights(new int[] {0}));
                    Assert.AreEqual(new int[] { 0, 1 }, RowWeightsTask.RowWeights(new int[] {0, 1, 0}));
                    Assert.AreEqual(new int[] { 62, 27 }, RowWeightsTask.RowWeights(new int[] { 13, 27,49 }));
                    Assert.AreEqual(new int[] { 150, 151 }, RowWeightsTask.RowWeights(new int[] { 100, 51, 50, 100 }));
                }

                [Test]
                public static void ReturnStringOfFirstCharactersTest()
                {
                    Assert.AreEqual("cia", ReturnStringOfFirstCharactersTask.MakeString("coding is awesome"));
                }

                [Test]
                public void EvensTimesLastTest()
                {
                    Assert.AreEqual(30, EvensTimesLastTask.EvenTimesLast(new int[] { 2, 3, 4, 5 }));
                    Assert.AreEqual(0, EvensTimesLastTask.EvenTimesLast(new int[] { 2, 3, 4, 5, 0 }));
                    Assert.AreEqual(-6, EvensTimesLastTask.EvenTimesLast(new int[] { 2, 3, 4, -1 }));
                    Assert.AreEqual(91, EvensTimesLastTask.EvenTimesLast(new[] { 7, 13 }));
                    Assert.AreEqual(49, EvensTimesLastTask.EvenTimesLast(new[] { 7 }));


                }

                [Test]
                public void BandNameGeneratorTest()
                {
                    Assert.AreEqual("The Knife", BandNameGeneratorTask.BandNameGenerator("knife"));
                    Assert.AreEqual("Tartart", BandNameGeneratorTask.BandNameGenerator("tart"));
                    Assert.AreEqual("Sandlesandles", BandNameGeneratorTask.BandNameGenerator("sandles"));
                    Assert.AreEqual("The Bed", BandNameGeneratorTask.BandNameGenerator("bed"));
                }

                [Test]
                public void CountAllTheSheepOnFarmTest()
                {
                    CountAllTheSheepOnFarmTask kata = new CountAllTheSheepOnFarmTask();
                    int[] friday = new int[] { 5, 1, 4 };
                    int[] saturday = new int[] { 5, 4 };
                    Assert.AreEqual(10, kata.lostSheep(friday, saturday, 29));
                }

                [Test]
                public void DiscoverTheOriginalPriceTest()
                {
                    Assert.AreEqual(100.00M, DiscoverTheOriginalPriceTask.DiscoverOriginalPrice(75M, 25M));
                }

                [Test]
                public void ReverseTheBitsTest()
                {
                    Assert.AreEqual(267, ReverseTheBitsTask.ReverseBits(417));
                    Assert.AreEqual(417, ReverseTheBitsTask.ReverseBits(267));
                    Assert.AreEqual(0, ReverseTheBitsTask.ReverseBits(0));
                    Assert.AreEqual(1087, ReverseTheBitsTask.ReverseBits(2017));
                    Assert.AreEqual(1023, ReverseTheBitsTask.ReverseBits(1023));
                    Assert.AreEqual(1, ReverseTheBitsTask.ReverseBits(1024));
                    Assert.AreEqual(long.MaxValue, ReverseTheBitsTask.ReverseBits(long.MaxValue));
                }

                [Test]
                public void ReturnTheMissingElementTest()
                {
                    Assert.AreEqual(8, ReturnTheMissingElementTask.GetMissingElement(new int[9] { 0, 5, 1, 3, 2, 9, 7, 6, 4 }));
                    Assert.AreEqual(3, ReturnTheMissingElementTask.GetMissingElement(new int[9] { 9, 2, 4, 5, 7, 0, 8, 6, 1 }));
                }

                [Test]
                public void CheckThreeAndTwoTest()
                {
                    Assert.AreEqual(true, CheckThreeAndTwoTask.CheckThreeAndTwo(new string[] { "a", "a", "a", "b", "b" }));
                    Assert.AreEqual(false, CheckThreeAndTwoTask.CheckThreeAndTwo(new string[] { "a", "c", "a", "c", "b" }));
                    Assert.AreEqual(false, CheckThreeAndTwoTask.CheckThreeAndTwo(new string[] { "a", "a", "a", "a", "a" }));
                }

                [Test]
                public void StrongNumberTest()
                {
                    Assert.AreEqual("STRONG!!!!", StrongNumberTask.StrongNumber(1));
                    Assert.AreEqual("STRONG!!!!", StrongNumberTask.StrongNumber(2));
                    Assert.AreEqual("STRONG!!!!", StrongNumberTask.StrongNumber(145));
                    Assert.AreEqual("Not Strong !!", StrongNumberTask.StrongNumber(7));
                    Assert.AreEqual("Not Strong !!", StrongNumberTask.StrongNumber(93));
                    Assert.AreEqual("Not Strong !!", StrongNumberTask.StrongNumber(185));
                }

                [Test]
                public void StantonMeasureTest()
                {
                    Assert.AreEqual(3, StantonMeasureTask.StantonMeasure(new int[] { 1, 4, 3, 2, 1, 2, 3, 2 }));
                }

                [Test]
                public void InspiringStringsTest()
                {
                    Assert.AreEqual("fgh", InspiringStringsTask.LongestWord("a b c d e fgh"));
                    Assert.AreEqual("three", InspiringStringsTask.LongestWord("one two three"));
                    Assert.AreEqual("grey", InspiringStringsTask.LongestWord("red blue grey"));
                }



                [Test]
                public void ByThreeOrNotTest()
                {
                    Assert.That(ByThreeOrNotTask.DivisibleByThree("1891009"), Is.EqualTo(false));
                    Assert.That(ByThreeOrNotTask.DivisibleByThree("00009"), Is.EqualTo(true));
                    Assert.That(ByThreeOrNotTask.DivisibleByThree("57"), Is.EqualTo(true));
                }

                [Test]
                public void BuildingStringsFromAHashTest()
                {
                    Assert.AreEqual("a = 1,b = 2", BuildingStringsFromAHashTask.StringifyDict(new Dictionary<char, int> { { 'a', 1 }, { 'b', 2 } }));
                    Assert.AreEqual("b = 1,c = 2,e = 3", BuildingStringsFromAHashTask.StringifyDict(new Dictionary<char, int> { { 'b', 1 }, { 'c', 2 }, { 'e', 3 } }));
                    Assert.AreEqual("", BuildingStringsFromAHashTask.StringifyDict(new Dictionary<char, int>()));
                }

                [Test]
                public void ElevatorDistanceTest()
                {
                    Assert.AreEqual(9, ElevatorDistanceTask.ElevatorDistance(new[] { 5, 2, 8 }));
                    Assert.AreEqual(2, ElevatorDistanceTask.ElevatorDistance(new[] { 1, 2, 3 }));
                    Assert.AreEqual(18, ElevatorDistanceTask.ElevatorDistance(new[] { 7, 1, 7, 1 }));

                }

                [Test]
                public void OrderedCountOfCharactersTest()
                {
                    var expected = new List<Tuple<char, int>>()
        {
            Tuple.Create('a', 5),
            Tuple.Create('b', 2),
            Tuple.Create('r', 2),
            Tuple.Create('c', 1),
            Tuple.Create('d', 1)
        };

                    var result = OrderedCountOfCharactersTask.OrderedCount("abracadabra");

                    CollectionAssert.AreEqual(expected, result);
                }

                    [Test]
                public static void LookingForABenefactorTest()
                {
                    static void Testing(long actual, long expected)
                    {
                        Assert.AreEqual(expected, actual);
                    }

                    double[] a = new double[] { 14, 30, 5, 7, 9, 11, 15 };
                    Testing(LookingForABenefactorTask.NewAvg(a, 100), 709);
                    a = new double[] { 14.0, 30.0, 5.0, 7.0, 9.0, 11.0, 16.0 };
                    Testing(LookingForABenefactorTask.NewAvg(a, 90), 628);
                }

                [Test]
                public void ResponsibleDrinkingTest()
                {
                    ResponsibleDrinkingTask drinkin = new ResponsibleDrinkingTask();
                    string expected = "10 glasses of water";
                    string actual = drinkin.Hydrate("1 shot, 5 beers, 2 shots, 1 glass of wine, 1 beer");
                    Assert.AreEqual(expected, actual);

                    string expected2 = "1 glass of water";
                    string actual2 = drinkin.Hydrate("1 beer");
                    Assert.AreEqual(expected, actual);
                }

                [Test]
                public void ShorterConcatTest()
                {
                    try
                    {
                        string input_a = "abcde";
                        string input_b = "fghi";
                        string expected = "fghiedcbafghi";

                        string actual = ShorterConcatTask.ShorterReverseLonger(input_a, input_b);

                        Assert.AreEqual(expected, actual);
                    }
                    catch (System.Exception ex)
                    {
                        Assert.Fail("There seems to be an error in your code. The exception message reads as follow: " + ex.Message);
                    }
                }

                    [Test]
                public void SortArraysTest()
                {
                    Assert.AreEqual("one,three,two", string.Join(",", SortArraysTask.SortMe(new[] { "one", "two", "three" })));
                }

                [Test]
                public void BinaryOrHexTest()
                {
                    Assert.AreEqual("10", BinaryOrHexTask.EvensAndOdds(2));
                    Assert.AreEqual("d", BinaryOrHexTask.EvensAndOdds(13));
                    Assert.AreEqual("2f", BinaryOrHexTask.EvensAndOdds(47));
                    Assert.AreEqual("0", BinaryOrHexTask.EvensAndOdds(0));
                    Assert.AreEqual("11001000000000", BinaryOrHexTask.EvensAndOdds(12800));
                }

                [Test]
                public void FireonTheBoatTest()
                {
                    Assert.AreEqual("Boat Rudder Mast Boat Hull Water ~~ Boat Deck Hull ~~ Propeller Deck ~~ Deck Boat Mast", FireonTheBoatTask.FireFight("Boat Rudder Mast Boat Hull Water Fire Boat Deck Hull Fire Propeller Deck Fire Deck Boat Mast"));
                    Assert.AreEqual("Mast Deck Engine Water ~~", FireonTheBoatTask.FireFight("Mast Deck Engine Water Fire"));
                    Assert.AreEqual("~~ Deck Engine Sail Deck ~~ ~~ ~~ Rudder ~~ Boat ~~ ~~ Captain", FireonTheBoatTask.FireFight("Fire Deck Engine Sail Deck Fire Fire Fire Rudder Fire Boat Fire Fire Captain"));
                }

                [Test]
                public void ConsecutiveItemsTest()
                {
                    Assert.AreEqual(false, ConsecutiveItemsTask.Consecutive(new int[] { 1, 3, 5, 7 }, 3, 7));
                    Assert.AreEqual(true, ConsecutiveItemsTask.Consecutive(new int[] { 1, 3, 5, 7 }, 3, 1));
                    Assert.AreEqual(true, ConsecutiveItemsTask.Consecutive(new int[] { 1, 6, 9, -3, 4, -78, 0 }, -3, 4));
                }
                [Test]
                public void SevenAteNineTest()
                {
                    Assert.AreEqual("77", SevenAteNineTask.SevenAteNine("797"));
                    Assert.AreEqual("7777", SevenAteNineTask.SevenAteNine("7979797"));
                    Assert.AreEqual("16556178612178977", SevenAteNineTask.SevenAteNine("165561786121789797"));

                }

                [Test]
                public void ExampleTests()
                {
                    Assert.AreEqual("Escaped!", CatAndMouseTask.CatMouse("C....m"));
                    Assert.AreEqual("Caught!", CatAndMouseTask.CatMouse("C..m"));
                    Assert.AreEqual("Escaped!", CatAndMouseTask.CatMouse("C.....m"));
                }

                [Test]
                public void CompareStringsBySumOfCharsTest()
                {
                    Assert.AreEqual(true, CompareStringsBySumOfCharsTask.Compare("AD", "BC"));
                    Assert.AreEqual(false, CompareStringsBySumOfCharsTask.Compare("AD", "DD"));

                }

                [Test]
                public void CharCodeCalculationTest()
                {
                    Assert.AreEqual(0, CharCodeCalculationTask.Calc(""));
                    Assert.AreEqual(6, CharCodeCalculationTask.Calc("abc"));
                    Assert.AreEqual(6, CharCodeCalculationTask.Calc("ABC"));
                    Assert.AreEqual(6, CharCodeCalculationTask.Calc("abcdef"));
                    Assert.AreEqual(6, CharCodeCalculationTask.Calc("ifkhchlhfd"));
                    Assert.AreEqual(6, CharCodeCalculationTask.Calc("jfmgklf8hglbe"));
                    Assert.AreEqual(12, CharCodeCalculationTask.Calc("jaam"));
                    Assert.AreEqual(18, CharCodeCalculationTask.Calc("AFHJD"));
                    Assert.AreEqual(18, CharCodeCalculationTask.Calc("CodeWars"));
                    Assert.AreEqual(24, CharCodeCalculationTask.Calc("FVJFVDF"));
                    Assert.AreEqual(24, CharCodeCalculationTask.Calc("AOUCUAOF"));
                    Assert.AreEqual(30, CharCodeCalculationTask.Calc("aaaaaddddr"));
                    Assert.AreEqual(36, CharCodeCalculationTask.Calc("XLdNDcAbUkMnkV"));
                    Assert.AreEqual(42, CharCodeCalculationTask.Calc("cSuLifxDQkOiypJsxOJSE"));
                    Assert.AreEqual(48, CharCodeCalculationTask.Calc("ZHAUnSGoIbgPSezhjePIbHFrHUOv"));
                    Assert.AreEqual(54, CharCodeCalculationTask.Calc("VFhSMbZETZVHxYiiYsBMrWuecDN"));
                    Assert.AreEqual(60, CharCodeCalculationTask.Calc("sphPoGbicTCLbiuUcwFMEGaFmy"));
                    Assert.AreEqual(72, CharCodeCalculationTask.Calc("oXoQKiCflHIHFyGizCYCuaHhX"));
                    Assert.AreEqual(84, CharCodeCalculationTask.Calc("sUuPmNnnJOOCAGOuyzmcHQGJhXHYgZLY"));
                }

                [Test]
                public void FindCountofMostFrequentItemInAnArrayTest()
                {
                    Assert.AreEqual(5, FindCountofMostFrequentItemInAnArrayTask.MostFrequentItemCount(new int[] { 3, -1, -1, -1, 2, 3, -1, 3, -1, 2, 4, 9, 3 }));
                }

                [Test]
                public void PaddedNumbersTest()
                {
                    Assert.AreEqual("Value is 00005", PaddedNumbersTask.Solution(5));
                }

                [Test]
                public void UniqueStringCharactersTest()
                {
                    Assert.That(UniqueStringCharactersTask.Solve("xyab", "xzca"), Is.EqualTo("ybzc"));
                    Assert.That(UniqueStringCharactersTask.Solve("xyabb", "xzca"), Is.EqualTo("ybbzc"));
                    Assert.That(UniqueStringCharactersTask.Solve("abcd", "xyz"), Is.EqualTo("abcdxyz"));
                    Assert.That(UniqueStringCharactersTask.Solve("xxx", "xzca"), Is.EqualTo("zca"));
                }

                [Test]
                public void NumberOfOccurrencesTest()
                {
                    Assert.AreEqual(2, NumberOfOccurrencesTask.NumberOfOccurrences(4, new int[] { 4, 0, 4 }));
                    Assert.AreEqual(0, NumberOfOccurrencesTask.NumberOfOccurrences(1, new int[] { 4, 0, 4 }));
                    Assert.AreEqual(1, NumberOfOccurrencesTask.NumberOfOccurrences(0, new int[] { 4, 0, 4 }));
                }

                [Test]
                public void SpecialNumberFiveTest()
                {
                    Assert.That(SpecialNumberFiveTask.SpecialNumber(00002), Is.EqualTo("Special!!"));
                    Assert.That(SpecialNumberFiveTask.SpecialNumber(00003), Is.EqualTo("Special!!"));
                    Assert.That(SpecialNumberFiveTask.SpecialNumber(00011), Is.EqualTo("Special!!"));
                    Assert.That(SpecialNumberFiveTask.SpecialNumber(00055), Is.EqualTo("Special!!"));
                    Assert.That(SpecialNumberFiveTask.SpecialNumber(25432), Is.EqualTo("Special!!"));
                    Assert.That(SpecialNumberFiveTask.SpecialNumber(02783), Is.EqualTo("NOT!!"));
                    Assert.That(SpecialNumberFiveTask.SpecialNumber(00006), Is.EqualTo("NOT!!"));
                    Assert.That(SpecialNumberFiveTask.SpecialNumber(00009), Is.EqualTo("NOT!!"));
                    Assert.That(SpecialNumberFiveTask.SpecialNumber(00026), Is.EqualTo("NOT!!"));
                }

                [Test]
                public void SumOfIntegersInStringTest()
                {
                    Assert.AreEqual(16, SumOfIntegersInStringTask.SumOfIntegersInString("12.4"));
                    Assert.AreEqual(3, SumOfIntegersInStringTask.SumOfIntegersInString("h3ll0w0rld"));
                    Assert.AreEqual(1, SumOfIntegersInStringTask.SumOfIntegersInString("Our company made approximately 1 million in gross revenue last quarter."));
                    Assert.AreEqual(18, SumOfIntegersInStringTask.SumOfIntegersInString("C4t5 are 4m4z1ng."));
                    Assert.AreEqual(3635, SumOfIntegersInStringTask.SumOfIntegersInString("The30quick20brown10f0x1203jumps914ov3r1349the102l4zy dog"));
                }

                [Test]
                public void AlternateCaseTest()
                {
                    Assert.AreEqual("ABC", AlternateCaseTask.AlternateCase("abc"));
                    Assert.AreEqual("abc", AlternateCaseTask.AlternateCase("ABC"));
                    Assert.AreEqual("hELLO wORLD", AlternateCaseTask.AlternateCase("Hello World"));
                }

                [Test]
                public void ARuleOfDivisibilityBySevenTest()
                {
                    Assert.AreEqual(new long[] { 10, 2 }, ARuleOfDivisibilityBySevenTask.Seven(1021));
                    Assert.AreEqual(new long[] { 7, 2 }, ARuleOfDivisibilityBySevenTask.Seven(1603));
                    Assert.AreEqual(new long[] { 35, 1 }, ARuleOfDivisibilityBySevenTask.Seven(371));
                    Assert.AreEqual(new long[] { 42, 1 }, ARuleOfDivisibilityBySevenTask.Seven(483));
                }

                [Test]
                public void ReturnTheFirstMMultiplesOfNTest()
                {
                    Assert.AreEqual(new double[] { 5, 10, 15 }, ReturnTheFirstMMultiplesOfNTask.Multiples(3, 5));
                }

                [Test]
                public void ToLeetSpeakTest()
                {
                    Assert.AreEqual("1337", ToLeetSpeakTask.ToLeetSpeak("LEET"));
                    Assert.AreEqual("(0D3W@R$", ToLeetSpeakTask.ToLeetSpeak("CODEWARS"));
                    Assert.AreEqual("#3110 W0R1D", ToLeetSpeakTask.ToLeetSpeak("HELLO WORLD"));
                    Assert.AreEqual("10R3M !P$UM D010R $!7 @M37", ToLeetSpeakTask.ToLeetSpeak("LOREM IPSUM DOLOR SIT AMET"));
                    Assert.AreEqual("7#3 QU!(K 8R0WN F0X JUMP$ 0V3R 7#3 1@2Y D06", ToLeetSpeakTask.ToLeetSpeak("THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG"));
                }

                [Test]
                public void BuildingBlocksTest()
                {
                    BuildingBlocksTask b = new BuildingBlocksTask(new int[] { 2, 2, 2 });
                    Assert.AreEqual(2, b.GetWidth());
                    Assert.AreEqual(2, b.GetLength());
                    Assert.AreEqual(2, b.GetHeight());
                    Assert.AreEqual(8, b.GetVolume());
                    Assert.AreEqual(24, b.GetSurfaceArea());
                }

                [Test]
                public void DifferenceOfSquaresTest()
                {
                    Assert.AreEqual(170, DifferenceOfSquaresTask.DifferenceOfSquares(5));
                    Assert.AreEqual(2640, DifferenceOfSquaresTask.DifferenceOfSquares(10));
                    Assert.AreEqual(25164150, DifferenceOfSquaresTask.DifferenceOfSquares(100));
                }

                [Test]
                public void LastSurvivorTest()
                {
                    {
                        string letters = "abc";
                        int[] coords = { 1, 1 };
                        string expected = "a";
                        string actual = LastSurvivorTask.LastSurvivor(letters, coords);
                        Assert.AreEqual(expected, actual);
                    }

                    {
                        string letters = "kbc";
                        int[] coords = { 0, 1 };
                        string expected = "b";
                        string actual = LastSurvivorTask.LastSurvivor(letters, coords);
                        Assert.AreEqual(expected, actual);
                    }

                    {
                        string letters = "zbk";
                        int[] coords = { 2, 1 };
                        string expected = "z";
                        string actual = LastSurvivorTask.LastSurvivor(letters, coords);
                        Assert.AreEqual(expected, actual);
                    }

                    {
                        string letters = "c";
                        int[] coords = { };
                        string expected = "c";
                        string actual = LastSurvivorTask.LastSurvivor(letters, coords);
                        Assert.AreEqual(expected, actual);
                    }

                    {
                        string letters = "foiflxtpicahhkqjswjuyhmypkrdbwnmwbrrvdycqespfvdviucjoyvskltqaqirtjqulprjjoaiagobpftywabqjdmiofpsr";
                        int[] coords = { 8, 59, 52, 93, 21, 40, 88, 85, 59, 10, 82, 18, 74, 59, 51, 47, 75, 49, 23, 56, 1, 33, 39, 33, 34, 44, 25, 0, 51, 25, 36, 32, 57, 10, 57, 12, 51, 55, 24, 55, 31, 49, 6, 15, 10, 48, 27, 29, 38, 30, 35, 42, 23, 32, 9, 39, 39, 36, 8, 29, 2, 33, 14, 3, 13, 25, 9, 25, 18, 10, 1, 2, 20, 8, 2, 11, 5, 7, 0, 10, 10, 8, 12, 3, 5, 1, 7, 7, 5, 1, 4, 0, 4, 0, 0, 1 };
                        string expected = "d";
                        string actual = LastSurvivorTask.LastSurvivor(letters, coords);
                        Assert.AreEqual(expected, actual);
                    }
                }


                [Test]
                public void FindTheVowelsTest()
                {
                    Assert.AreEqual(new int[] { }, FindTheVowelsTask.VowelIndices("mmm"));
                    Assert.AreEqual(new int[] { 1, 5 }, FindTheVowelsTask.VowelIndices("apple"));
                    Assert.AreEqual(new int[] { 2, 4 }, FindTheVowelsTask.VowelIndices("super"));
                    Assert.AreEqual(new int[] { 1, 3, 6 }, FindTheVowelsTask.VowelIndices("orange"));
                    Assert.AreEqual(new int[] { 2, 4, 7, 9, 12, 14, 16, 19, 21, 24, 25, 27, 29, 31, 32, 33 }, FindTheVowelsTask.VowelIndices("supercalifragilisticexpialidocious"));
                }

                [Test]
                public void SplitInPartsTest()
                {
                    string str = "HelloKata";
                    Assert.AreEqual("HelloKata", SplitInPartsTask.SplitInParts(str, 9));

                    string str1 = "HelloKata";
                    Assert.AreEqual("H e l l o K a t a", SplitInPartsTask.SplitInParts(str1, 1));
                }

                [Test]
                public void LongestVowelChainTest()
                {
                    Assert.AreEqual(2, LongestVowelChainTask.Solve("codewarriors"));
                    Assert.AreEqual(3, LongestVowelChainTask.Solve("suoidea"));
                    Assert.AreEqual(3, LongestVowelChainTask.Solve("ultrarevolutionariees"));
                    Assert.AreEqual(1, LongestVowelChainTask.Solve("strengthlessnesses"));
                    Assert.AreEqual(2, LongestVowelChainTask.Solve("cuboideonavicuare"));
                    Assert.AreEqual(5, LongestVowelChainTask.Solve("chrononhotonthuooaos"));
                    Assert.AreEqual(8, LongestVowelChainTask.Solve("iiihoovaeaaaoougjyaw"));
                }

                [Test]
                public void NumbersToLettersTest()
                {
                    string expected1 = "codewars";

                    string actual1 = NumbersToLettersTask.Switcher(new string[] { "24", "12", "23", "22", "4", "26", "9", "8" });

                    Assert.AreEqual(expected1, actual1);

                    string expected2 = "btswmdsbd kkw";

                    string actual2 = NumbersToLettersTask.Switcher(new string[] { "25", "7", "8", "4", "14", "23", "8", "25", "23", "29", "16", "16", "4" });

                    Assert.AreEqual(expected2, actual2);

                    string expected3 = "wc";

                    string actual3 = NumbersToLettersTask.Switcher(new string[] { "4", "24" });

                    Assert.AreEqual(expected3, actual3);
                }

                [Test]
                public void SmallestValueOfAnArrayTest()
                {
                    Assert.AreEqual(1, SmallestValueOfAnArrayTask.FindSmallest(new int[] { 5, 4, 3, 2, 1 }, "value"));
                    Assert.AreEqual(4, SmallestValueOfAnArrayTask.FindSmallest(new int[] { 5, 4, 3, 2, 1 }, "index"));
                }

                [Test]
                public void LargestElementsTest()
                {
                    Assert.AreEqual(new List<int> { 9, 10 }, LargestElementsTask.Largest(2, new List<int> { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }));
                    Assert.AreEqual(new List<int> { 5, 5, 5 }, LargestElementsTask.Largest(3, new List<int> { 5, 1, 5, 2, 3, 1, 2, 3, 5 }));
                    Assert.AreEqual(new List<int> { 3, 5, 9, 13, 22, 50, 63 }, LargestElementsTask.Largest(7, new List<int> { 9, 1, 50, 22, 3, 13, 2, 63, 5 }));
                    Assert.AreEqual(new List<int> { }, LargestElementsTask.Largest(0, new List<int> { 1, 2, 3, 4, 8, 7, 6, 5 }));
                }

                [Test]
                public void NthSmallestElementTest()
                {
                    Assert.AreEqual(2, NthSmallestElementTask.NthSmallest(new int[] { 3, 1, 2 }, 2));
                    Assert.AreEqual(7, NthSmallestElementTask.NthSmallest(new int[] { 15, 20, 7, 10, 4, 3 }, 3));
                    Assert.AreEqual(2, NthSmallestElementTask.NthSmallest(new int[] { 2, 169, 13, -5, 0, -1 }, 4));
                    Assert.AreEqual(2, NthSmallestElementTask.NthSmallest(new int[] { 2, 1, 3, 3, 1, 2 }, 3));
                }

                [Test]
                public void TheOldSwitcheroTest()
                {
                    Assert.AreEqual("th3s 6s my str15ng", TheOldSwitcheroTask.Vowel2Index("this is my string"));
                    Assert.AreEqual("C2d4w6rs 10s th15 b18st s23t25 27n th32 w35rld", TheOldSwitcheroTask.Vowel2Index("Codewars is the best site in the world"));
                    Assert.AreEqual("T2m4rr7w 10s g1415ng t20 b23 r2627n29ng", TheOldSwitcheroTask.Vowel2Index("Tomorrow is going to be raining"));
                }

                [Test]
                public void LoveVsFriendshipTest()
                {
                    Assert.AreEqual(100, LoveVsFriendshipTask.WordsToMarks("attitude"));
                    Assert.AreEqual(75, LoveVsFriendshipTask.WordsToMarks("friends"));
                    Assert.AreEqual(66, LoveVsFriendshipTask.WordsToMarks("family"));
                    Assert.AreEqual(96, LoveVsFriendshipTask.WordsToMarks("knowledge"));

                }

                [Test]
                public void FindTheNthDigitOfANumberTest()
                {
                    Assert.AreEqual(5, FindTheNthDigitOfANumberTask.FindDigit(5673, 4));
                    Assert.AreEqual(2, FindTheNthDigitOfANumberTask.FindDigit(129, 2));
                    Assert.AreEqual(8, FindTheNthDigitOfANumberTask.FindDigit(-2825, 3));
                    Assert.AreEqual(0, FindTheNthDigitOfANumberTask.FindDigit(-456, 4));
                    Assert.AreEqual(0, FindTheNthDigitOfANumberTask.FindDigit(0, 20));
                    Assert.AreEqual(-1, FindTheNthDigitOfANumberTask.FindDigit(65, 0));
                    Assert.AreEqual(-1, FindTheNthDigitOfANumberTask.FindDigit(24, -8));
                }

                [Test]
                public void WordValuesTest()
                {
                    Assert.AreEqual(new int[] { 88, 12, 225 }, WordValuesTask.WordValue(new string[] { "codewars", "abc", "xyz" }));
                    Assert.AreEqual(new int[] { 12, 24, 18, 24 }, WordValuesTask.WordValue(new string[] { "abc abc", "abc abc", "abc", "abc" }));

                }

                [Test]
                public void UnluckyDaysTest()
                {
                    Assert.AreEqual(1, UnluckyDaysTask.UnluckyDays(1586));
                    Assert.AreEqual(3, UnluckyDaysTask.UnluckyDays(1001));
                    Assert.AreEqual(2, UnluckyDaysTask.UnluckyDays(2819));
                    Assert.AreEqual(2, UnluckyDaysTask.UnluckyDays(2792));
                    Assert.AreEqual(2, UnluckyDaysTask.UnluckyDays(2723));
                    Assert.AreEqual(1, UnluckyDaysTask.UnluckyDays(1909));
                    Assert.AreEqual(2, UnluckyDaysTask.UnluckyDays(1812));
                    Assert.AreEqual(2, UnluckyDaysTask.UnluckyDays(1618));
                    Assert.AreEqual(1, UnluckyDaysTask.UnluckyDays(2132));
                    Assert.AreEqual(3, UnluckyDaysTask.UnluckyDays(2065));
                }

                [Test]
                public void AutomorphicNumberTest()
                {
                    Assert.AreEqual("Automorphic", AutomorphicNumberTask.Automorphic(1));
                    Assert.AreEqual("Automorphic", AutomorphicNumberTask.Automorphic(6));
                    Assert.AreEqual("Automorphic", AutomorphicNumberTask.Automorphic(625));
                    Assert.AreEqual("Not!!", AutomorphicNumberTask.Automorphic(3));
                    Assert.AreEqual("Not!!", AutomorphicNumberTask.Automorphic(95));
                    Assert.AreEqual("Not!!", AutomorphicNumberTask.Automorphic(225));
                }


                [Test]
                public void RemoveAllTheMarkedElementsOfAListTest()
                {

                    CollectionAssert.AreEqual(new int[] { 2, 2, 4 }, RemoveAllTheMarkedElementsOfAListTask.Remove(new int[] { 1, 1, 2, 3, 1, 2, 3, 4 }, new int[] { 1, 3 }));
                    CollectionAssert.AreEqual(new int[] { 5, 6, 7, 8 }, RemoveAllTheMarkedElementsOfAListTask.Remove(new int[] { 1, 1, 2, 3, 1, 2, 3, 4, 4, 3, 5, 6, 7, 2, 8 }, new int[] { 1, 3, 4, 2 }));

                }

                [Test]
                public void TheOfficeIIBoredomScoreTest()
                {
                    Assert.AreEqual("kill me now", TheOfficeIIBoredomScoreTask.Boredom(new Dictionary<string, string>() { { "Tim", "accounts" }, { "Jim", "trading" }, { "Sandy", "regulation" }, { "Andy", "accounts" }, { "Katie", "finance" }, { "Laura", "IS" } }));
                    Assert.AreEqual("i can handle this", TheOfficeIIBoredomScoreTask.Boredom(new Dictionary<string, string>() { { "Jim", "pissing about" }, { "Tim", "regulation" }, { "Andy", "IS" }, { "Laura", "pissing about" }, { "Alex", "canteen" }, { "John", "canteen" } }));
                    Assert.AreEqual("party time!!", TheOfficeIIBoredomScoreTask.Boredom(new Dictionary<string, string>() { { "Andy", "pissing about" }, { "Tim", "accounts" }, { "Smith", "pissing about" }, { "Randy", "pissing about" }, { "Sandy", "IS" }, { "Laura", "pissing about" } }));
                }

                [Test]
                public void IndexedCapitalizationTest()
                {
                    Assert.AreEqual("aBCdeF", IndexedCapitalizationTask.Capitalize("abcdef", new List<int> { 1, 2, 5 }));
                    Assert.AreEqual("aBCdeF", IndexedCapitalizationTask.Capitalize("abcdef", new List<int> { 1, 2, 5, 100 }));
                    Assert.AreEqual("aBCdeF", IndexedCapitalizationTask.Capitalize("abcdef", new List<int> { 1, 100, 2, 5 }));
                    Assert.AreEqual("cOdEwArs", IndexedCapitalizationTask.Capitalize("codewars", new List<int> { 1, 3, 5, 50 }));
                    Assert.AreEqual("abRacaDabRA", IndexedCapitalizationTask.Capitalize("abracadabra", new List<int> { 2, 6, 9, 10 }));
                    Assert.AreEqual("codewArriors", IndexedCapitalizationTask.Capitalize("codewarriors", new List<int> { 5 }));
                    Assert.AreEqual("Indexinglessons", IndexedCapitalizationTask.Capitalize("indexinglessons", new List<int> { 0 }));
                }


                [Test]
                public void DigitalCypherTest()
                {
                    Assert.AreEqual(new int[] { 20, 12, 18, 30, 21 }, DigitalCypherTask.Encode("scout", 1939));
                    Assert.AreEqual(new int[] { 14, 10, 22, 29, 6, 27, 19, 18, 6, 12, 8 }, DigitalCypherTask.Encode("masterpiece", 1939));

                }

                [Test]
                public static void GoingToTheCinemaTest()
                {
                    Assert.AreEqual(43, GoingToTheCinemaTask.Movie(500, 15, 0.9));
                    Assert.AreEqual(24, GoingToTheCinemaTask.Movie(100, 10, 0.95));

                }

                [Test]
                public void DisariumNumberTest()
                {
                    Assert.AreEqual("Disarium !!", DisariumNumberTask.DisariumNumber(89));
                    Assert.AreEqual("Not !!", DisariumNumberTask.DisariumNumber(564));
                    Assert.AreEqual("Disarium !!", DisariumNumberTask.DisariumNumber(135));
                    Assert.AreEqual("Not !!", DisariumNumberTask.DisariumNumber(136586));

                }

                [Test]
                public void CurryingFunctionsMultiplyAllElementsInAnArrayTest()
                {
                    Assert.AreEqual(new int[] { 1, 2, 3 }, CurryingFunctionsMultiplyAllElementsInAnArrayTask.MultiplyAll(new int[] { 1, 2, 3 })(1));
                    Assert.AreEqual(new int[] { 2, 4, 6 }, CurryingFunctionsMultiplyAllElementsInAnArrayTask.MultiplyAll(new int[] { 1, 2, 3 })(2));
                    Assert.AreEqual(new int[] { 0, 0, 0 }, CurryingFunctionsMultiplyAllElementsInAnArrayTask.MultiplyAll(new int[] { 1, 2, 3 })(0));
                    Assert.AreEqual(new int[] { }, CurryingFunctionsMultiplyAllElementsInAnArrayTask.MultiplyAll(new int[] { })(10));

                }

                [Test]
                public void FoldingYourWayToTheMoonTest()
                {
                    Assert.AreEqual(42, FoldingYourWayToTheMoonTask.FoldTo(384000000));
                }


                [Test]
                public void FunctionalAdditionTest()
                {
                    Assert.AreEqual(4, FunctionalAdditionTask.Add(1)(3));
                }

                [Test]
                public void DigitsExplosionTest()
                {
                    Assert.AreEqual("333122", DigitsExplosionTask.Explode("312"));
                    Assert.AreEqual("12222666666999999999", DigitsExplosionTask.Explode("102269"));
                }

                [Test]
                public void IncrementerTest()
                {
                    Assert.AreEqual(new int[] { 2, 4, 6 }, IncrementerTask.Incrementer(new int[] { 1, 2, 3 }));
                    Assert.AreEqual(new int[0], IncrementerTask.Incrementer(new int[0]));
                    Assert.AreEqual(new int[] { 5, 8, 0, 5, 8 }, IncrementerTask.Incrementer(new int[] { 4, 6, 7, 1, 3 }));
                    Assert.AreEqual(new int[] { 2, 4, 6, 8, 0, 2, 4, 6, 8, 9, 0, 1, 2, 2 }, IncrementerTask.Incrementer(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 9, 9, 9, 9, 8 }));
                }

                [Test]
                public void SortByLastCharTest()
                {
                    Assert.AreEqual(new[] { "cba", "cab", "abc" }, SortByLastCharTask.Last("abc cba cab"));
                    Assert.AreEqual(new[] { "aaa", "bbb", "ccc", "ddd" }, SortByLastCharTask.Last("bbb ccc aaa ddd"));
                    Assert.AreEqual(new[] { "wa", "de", "co", "rs" }, SortByLastCharTask.Last("co de wa rs"));
                    Assert.AreEqual(new[] { "axa", "ava", "asa" }, SortByLastCharTask.Last("axa ava asa"));

                    Assert.AreEqual(new[] { "a", "need", "ubud", "i", "taxi", "man", "to", "up" },
                        SortByLastCharTask.Last("man i need a taxi up to ubud"));

                    Assert.AreEqual(new[] { "time", "are", "we", "the", "climbing", "volcano", "up", "what" },
                        SortByLastCharTask.Last("what time are we climbing up the volcano"));

                    Assert.AreEqual(new[] { "take", "me", "semynak", "to" }, SortByLastCharTask.Last("take me to semynak"));

                    Assert.AreEqual(new[] { "massage", "massage", "massage", "yes", "yes" },
                        SortByLastCharTask.Last("massage yes massage yes massage"));

                    Assert.AreEqual(new[] { "a", "and", "take", "dance", "please", "bintang" },
                        SortByLastCharTask.Last("take bintang and a dance please"));
                }

                [Test]
                public void HelpSuzukiRakeHisGardenTest()
                {
                    var garden1 = "slug spider rock gravel gravel gravel gravel gravel gravel gravel";
                    var expectedGarden1 = "gravel gravel rock gravel gravel gravel gravel gravel gravel gravel";
                    Assert.AreEqual(expectedGarden1, HelpSuzukiRakeHisGardenTask.RakeGarden(garden1));

                    var garden2 = "gravel gravel gravel gravel gravel gravel gravel gravel gravel rock slug ant gravel gravel snail rock gravel gravel gravel gravel gravel gravel gravel slug gravel ant gravel gravel gravel gravel rock slug gravel gravel gravel gravel gravel snail gravel gravel rock gravel snail slug gravel gravel spider gravel gravel gravel gravel gravel gravel gravel gravel moss gravel gravel gravel snail gravel gravel gravel ant gravel gravel moss gravel gravel gravel gravel snail gravel gravel gravel gravel slug gravel rock gravel gravel rock gravel gravel gravel gravel snail gravel gravel rock gravel gravel gravel gravel gravel spider gravel rock gravel gravel";
                    var expectedGarden2 = "gravel gravel gravel gravel gravel gravel gravel gravel gravel rock gravel gravel gravel gravel gravel rock gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel rock gravel gravel gravel gravel gravel gravel gravel gravel gravel rock gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel gravel rock gravel gravel rock gravel gravel gravel gravel gravel gravel gravel rock gravel gravel gravel gravel gravel gravel gravel rock gravel gravel";
                    Assert.AreEqual(expectedGarden2, HelpSuzukiRakeHisGardenTask.RakeGarden(garden2));
                }

                [Test]
                public void HelpSuzukiCountHisVegetablesTest()
                {
                    var grp1 = new Tuple<int, string>[]
                    {
                       new Tuple<int, string>(2, "tofu"),
                       new Tuple<int, string>(2, "potato"),
                       new Tuple<int, string>(2, "cucumber"),
                       new Tuple<int, string>(2, "cabbage"),
                       new Tuple<int, string>(1, "turnip"),
                       new Tuple<int, string>(1, "pepper"),
                       new Tuple<int, string>(1, "onion"),
                       new Tuple<int, string>(1, "mushroom"),
                       new Tuple<int, string>(1, "celery"),
                       new Tuple<int, string>(1, "carrot")
                    };

                    var str1 = "potato tofu cucumber cabbage turnip pepper onion carrot celery mushroom potato tofu cucumber cabbage";

                    var grp2 = new Tuple<int, string>[]
                    {
                       new Tuple<int, string>(15, "turnip"),
                       new Tuple<int, string>(14, "mushroom"),
                       new Tuple<int, string>(13, "cabbage"),
                       new Tuple<int, string>(10, "carrot"),
                       new Tuple<int, string>(9, "potato"),
                       new Tuple<int, string>(7, "onion"),
                       new Tuple<int, string>(6, "tofu"),
                       new Tuple<int, string>(6, "pepper"),
                       new Tuple<int, string>(5, "cucumber"),
                       new Tuple<int, string>(4, "celery")
                    };

                    var str2 = "mushroom chopsticks chopsticks turnip mushroom carrot mushroom cabbage mushroom carrot tofu pepper cabbage " +
                               "potato cucumber mushroom mushroom potato turnip chopsticks cabbage celery celery turnip pepper chopsticks " +
                               "potato potato onion cabbage cucumber onion pepper onion cabbage potato tofu carrot cabbage cabbage turnip " +
                               "mushroom cabbage cabbage cucumber cabbage chopsticks turnip pepper onion pepper onion mushroom turnip carrot " +
                               "carrot tofu onion tofu chopsticks chopsticks chopsticks mushroom cucumber chopsticks carrot potato cabbage cabbage " +
                               "carrot mushroom chopsticks mushroom celery turnip onion carrot turnip cucumber carrot potato mushroom turnip " +
                               "mushroom cabbage tofu turnip turnip turnip mushroom tofu potato pepper turnip potato turnip celery carrot turnip";

                    Assert.AreEqual(grp1, HelpSuzukiCountHisVegetablesTask.CountVegetables(str1));
                    Assert.AreEqual(grp2, HelpSuzukiCountHisVegetablesTask.CountVegetables(str2));
                }

                [Test]
                public void RotateForAMaxTest()
                {
                    Assert.AreEqual(85821534, RotateForAMaxTask.MaxRot(38458215));
                    Assert.AreEqual(988103115, RotateForAMaxTask.MaxRot(195881031));
                    Assert.AreEqual(962193428, RotateForAMaxTask.MaxRot(896219342));
                    Assert.AreEqual(85821534, RotateForAMaxTask.MaxRot(38458215));
                }

                [Test]
                public void MaximumTripletSumTest()
                {
                    Assert.AreEqual(0, MaximumTripletSumTask.MaxTriSum(new int[] { -2, 0, 2 }));
                    Assert.AreEqual(17, MaximumTripletSumTask.MaxTriSum(new int[] { 3, 2, 6, 8, 2, 3 }));
                    Assert.AreEqual(-9, MaximumTripletSumTask.MaxTriSum(new int[] { -3, -27, -4, -2, -27, -2 }));
                    Assert.AreEqual(232, MaximumTripletSumTask.MaxTriSum(new int[] { -13, -50, 57, 13, 67, -13, 57, 108, 67 }));

                }

                [Test]
                public void SortOutTheMenFromBoysTest()
                {
                    Assert.AreEqual(new int[] { 14, 17, 7, 3 }, SortOutTheMenFromBoysTask.MenFromBoys(new int[] { 7, 3, 14, 17 }));
                    Assert.AreEqual(new int[] { 2, 90, 95, 43, 37 }, SortOutTheMenFromBoysTask.MenFromBoys(new int[] { 2, 43, 95, 90, 37 }));
                    Assert.AreEqual(new int[] { 20, 34, 46, 50, 43, 33 }, SortOutTheMenFromBoysTask.MenFromBoys(new int[] { 20, 33, 50, 34, 43, 46 }));
                    Assert.AreEqual(new int[] { 72, 76, 82, 100, 91, 85 }, SortOutTheMenFromBoysTask.MenFromBoys(new int[] { 82, 91, 72, 76, 76, 100, 85 }));
                    Assert.AreEqual(new int[] { 2, 10, 17, 15, 1 }, SortOutTheMenFromBoysTask.MenFromBoys(new int[] { 2, 15, 17, 15, 2, 10, 10, 17, 1, 1 }));
                    Assert.AreEqual(new int[] { -32, -35, -39, -41 }, SortOutTheMenFromBoysTask.MenFromBoys(new int[] { -32, -39, -35, -41 }));
                    Assert.AreEqual(new int[] { -66, -64, -63, -65, -71 }, SortOutTheMenFromBoysTask.MenFromBoys(new int[] { -64, -71, -63, -66, -65 }));
                    Assert.AreEqual(new int[] { -100, -96, -94, -99 }, SortOutTheMenFromBoysTask.MenFromBoys(new int[] { -94, -99, -100, -99, -96, -99 }));
                    Assert.AreEqual(new int[] { -26, -14, -27, -49, -51, -53 }, SortOutTheMenFromBoysTask.MenFromBoys(new int[] { -53, -26, -53, -27, -49, -51, -14 }));
                    Assert.AreEqual(new int[] { -86, -56, -30, -15, -17, -33, -45, -85 }, SortOutTheMenFromBoysTask.MenFromBoys(new int[] { -17, -45, -15, -33, -85, -56, -86, -30 }));
                    Assert.AreEqual(new int[] { -78, -38, 12, 89 }, SortOutTheMenFromBoysTask.MenFromBoys(new int[] { 12, 89, -38, -78 }));
                    Assert.AreEqual(new int[] { -90, 2, 95, 37, -43 }, SortOutTheMenFromBoysTask.MenFromBoys(new int[] { 2, -43, 95, -90, 37 }));
                    Assert.AreEqual(new int[] { -12, 82, 21, 1, -61, -87 }, SortOutTheMenFromBoysTask.MenFromBoys(new int[] { 82, -61, -87, -12, 21, 1 }));
                    Assert.AreEqual(new int[] { -28, 2, 76, 88, 63, -57, -85 }, SortOutTheMenFromBoysTask.MenFromBoys(new int[] { 63, -57, 76, -85, 88, 2, -28 }));
                    Assert.AreEqual(new int[] { -282, 818, 900, 928, 281, 49, -1 }, SortOutTheMenFromBoysTask.MenFromBoys(new int[] { 49, 818, -282, 900, 928, 281, -282, -1 }));
                }

                [Test]
                public void OddEvenStringSortTest()
                {
                    Assert.AreEqual("CdWr oeas", OddEvenStringSortTask.SortMyString("CodeWars"));

                }

                [Test]
                public void TidyNumberTest()
                {
                    Assert.AreEqual(false, TidyNumberTask.TidyNumber(102));
                    Assert.AreEqual(false, TidyNumberTask.TidyNumber(9672));
                    Assert.AreEqual(true, TidyNumberTask.TidyNumber(12));
                    Assert.AreEqual(true, TidyNumberTask.TidyNumber(2789));

                }

                [Test]
                public void SimpleStringCharactersTest()
                {
                    Assert.AreEqual(new int[] { 1, 18, 3, 2 }, SimpleStringCharactersTask.Solve("Codewars@codewars123.com"));
                    Assert.AreEqual(new int[] { 7, 6, 3, 2 }, SimpleStringCharactersTask.Solve("bgA5<1d-tOwUZTS8yQ"));
                    Assert.AreEqual(new int[] { 9, 9, 6, 9 }, SimpleStringCharactersTask.Solve("P*K4%>mQUDaG$h=cx2?.Czt7!Zn16p@5H"));
                    Assert.AreEqual(new int[] { 15, 8, 6, 9 }, SimpleStringCharactersTask.Solve("RYT'>s&gO-.CM9AKeH?,5317tWGpS<*x2ukXZD"));
                }

                [Test]
                public void SumOfOddCubedNumbersTest()
                {
                    Assert.AreEqual(28, SumOfOddCubedNumbersTask.CubeOdd(new int[] { 1, 2, 3, 4 }));
                    Assert.AreEqual(0, SumOfOddCubedNumbersTask.CubeOdd(new int[] { -3, -2, 2, 3 }));
                }

                [Test]
                public void NBalancedNumberTest()
                {
                    Assert.AreEqual("Not Balanced", BalancedNumberTask.BalancedNumber(1024));
                    Assert.AreEqual("Not Balanced", BalancedNumberTask.BalancedNumber(66545));
                    Assert.AreEqual("Not Balanced", BalancedNumberTask.BalancedNumber(295591));
                    Assert.AreEqual("Not Balanced", BalancedNumberTask.BalancedNumber(1230987));
                    Assert.AreEqual("Balanced", BalancedNumberTask.BalancedNumber(7));
                    Assert.AreEqual("Balanced", BalancedNumberTask.BalancedNumber(959));
                    Assert.AreEqual("Balanced", BalancedNumberTask.BalancedNumber(13));
                    Assert.AreEqual("Balanced", BalancedNumberTask.BalancedNumber(424));
                    Assert.AreEqual("Balanced", BalancedNumberTask.BalancedNumber(56239814));
                }

                [Test]
                public void SumOfCubesTest()
                {
                    Assert.AreEqual(1, SumOfCubesTask.SumCubes(1));
                    Assert.AreEqual(9, SumOfCubesTask.SumCubes(2));
                    Assert.AreEqual(36, SumOfCubesTask.SumCubes(3));
                    Assert.AreEqual(100, SumOfCubesTask.SumCubes(4));
                    Assert.AreEqual(3025, SumOfCubesTask.SumCubes(10));
                    Assert.AreEqual(58155876, SumOfCubesTask.SumCubes(123));
                }

                [Test]
                public void FindTheMiddleElementTest()
                {
                    Assert.AreEqual(0, FindTheMiddleElementTask.Gimme(new double[] { 2, 3, 1 }));
                    Assert.AreEqual(1, FindTheMiddleElementTask.Gimme(new double[] { 5, 10, 14 }));
                }

                [Test]
                public void SortTheGiftCodeTest()
                {
                    Assert.AreEqual("abcdef", SortTheGiftCodeTask.SortGiftCode("abcdef"));
                    Assert.AreEqual("kpqsuvy", SortTheGiftCodeTask.SortGiftCode("pqksuvy"));
                    Assert.AreEqual("abcdefghijklmnopqrstuvwxyz", SortTheGiftCodeTask.SortGiftCode("zyxwvutsrqponmlkjihgfedcba"));
                }

                [Test]
                public void AlphabetSymmetryTest()
                {
                    Assert.That(AlphabetSymmetryTask.Solve(new List<string> { "abode", "ABc", "xyzD" }), Is.EqualTo(new List<int> { 4, 3, 1 }));
                    Assert.That(AlphabetSymmetryTask.Solve(new List<string> { "abide", "ABc", "xyz" }), Is.EqualTo(new List<int> { 4, 3, 0 }));
                    Assert.That(AlphabetSymmetryTask.Solve(new List<string> { "IAMDEFANDJKL", "thedefgh", "xyzDEFghijabc" }), Is.EqualTo(new List<int> { 6, 5, 7 }));
                    Assert.That(AlphabetSymmetryTask.Solve(new List<string> { "encode", "abc", "xyzD", "ABmD" }), Is.EqualTo(new List<int> { 1, 3, 1, 3 }));
                }

                [Test]
                public void OverTheRoadTest()
                {
                    Assert.AreEqual(6, OverTheRoadTask.OverTheRoad(1, 3));
                    Assert.AreEqual(4, OverTheRoadTask.OverTheRoad(3, 3));
                    Assert.AreEqual(5, OverTheRoadTask.OverTheRoad(2, 3));
                    Assert.AreEqual(8, OverTheRoadTask.OverTheRoad(3, 5));
                    Assert.AreEqual(16, OverTheRoadTask.OverTheRoad(7, 11));
                }

                [Test]
                public void DivideAndConquerTest()
                {
                    Assert.AreEqual(2, DivideAndConquerTask.DivCon(new object[] { 9, 3, "7", "3" }));
                    Assert.AreEqual(14, DivideAndConquerTask.DivCon(new object[] { "5", "0", 9, 3, 2, 1, "9", 6, 7 }));
                    Assert.AreEqual(13, DivideAndConquerTask.DivCon(new object[] { "3", 6, 6, 0, "5", 8, 5, "6", 2, "0" }));
                    Assert.AreEqual(11, DivideAndConquerTask.DivCon(new object[] { "1", "5", "8", 8, 9, 9, 2, "3" }));
                    Assert.AreEqual(61, DivideAndConquerTask.DivCon(new object[] { 8, 0, 0, 8, 5, 7, 2, 3, 7, 8, 6, 7 }));
                    Assert.AreEqual(-6, DivideAndConquerTask.DivCon(new object[] { "0", "1", "2", "3" }));
                    Assert.AreEqual(6, DivideAndConquerTask.DivCon(new object[] { 0, 1, 2, 3 }));
                    Assert.AreEqual(0, DivideAndConquerTask.DivCon(new object[] { 1, "1" }));
                    Assert.AreEqual(-2, DivideAndConquerTask.DivCon(new object[] { -1, "1" }));
                    Assert.AreEqual(2, DivideAndConquerTask.DivCon(new object[] { 1, "-1" }));
                    Assert.AreEqual(1, DivideAndConquerTask.DivCon(new object[] { 1 }));
                    Assert.AreEqual(-1, DivideAndConquerTask.DivCon(new object[] { "1" }));
                    Assert.AreEqual(0, DivideAndConquerTask.DivCon(new object[] { }));
                }

                [Test]
                public void MakeAFunctionThatDoesArithmeticTest()
                {
                    Assert.AreEqual(3, MakeAFunctionThatDoesArithmeticTask.Arithmetic(1, 2, "add"));
                    Assert.AreEqual(6, MakeAFunctionThatDoesArithmeticTask.Arithmetic(8, 2, "subtract"));
                    Assert.AreEqual(10, MakeAFunctionThatDoesArithmeticTask.Arithmetic(5, 2, "multiply"));
                    Assert.AreEqual(4, MakeAFunctionThatDoesArithmeticTask.Arithmetic(8, 2, "divide"));
                }

                [Test]
                public void MinimizeSumOfArrayTest()
                {
                    Assert.AreEqual(342, MinimizeSumOfArrayTask.MinSum(new int[] { 12, 6, 10, 26, 3, 24 }));
                    Assert.AreEqual(74, MinimizeSumOfArrayTask.MinSum(new int[] { 9, 2, 8, 7, 5, 4, 0, 6 }));

                }


                [Test]
                public void SumOfTheFirstNthTermOfSeriesTest()
                {
                    Assert.AreEqual("0.00", SumOfTheFirstNthTermOfSeriesTask.SeriesSum(0));
                    Assert.AreEqual("1.77", SumOfTheFirstNthTermOfSeriesTask.SeriesSum(9));

                }

                [Test]
                public void MaxDiffEasyTest()
                {
                    Assert.AreEqual(6, MaxDiffEasyTask.MaxDiff(new[] { 0, 1, 2, 3, 4, 5, 6 }));
                    Assert.AreEqual(11, MaxDiffEasyTask.MaxDiff(new[] { -0, 1, 2, -3, 4, 5, -6 }));
                    Assert.AreEqual(16, MaxDiffEasyTask.MaxDiff(new[] { 0, 1, 2, 3, 4, 5, 16 }));
                    Assert.AreEqual(0, MaxDiffEasyTask.MaxDiff(new[] { 16 }));
                    Assert.AreEqual(0, MaxDiffEasyTask.MaxDiff(new int[] { }));
                }

                [Test]
                public void SumOfTriangularNumbersTest()
                {
                    Assert.AreEqual(56, SumOfTriangularNumbersTask.SumTriangularNumbers(6));
                    Assert.AreEqual(7140, SumOfTriangularNumbersTask.SumTriangularNumbers(34));
                    Assert.AreEqual(0, SumOfTriangularNumbersTask.SumTriangularNumbers(-291));
                    Assert.AreEqual(140205240, SumOfTriangularNumbersTask.SumTriangularNumbers(943));
                    Assert.AreEqual(0, SumOfTriangularNumbersTask.SumTriangularNumbers(-971));
                }

                [Test]
                public void GreetMeTest()
                {
                    Assert.That(GreetMeTask.Greet("riley"), Is.EqualTo("Hello Riley!"));
                    Assert.That(GreetMeTask.Greet("DaRO"), Is.EqualTo("Hello Daro!"));
                }

                [Test]
                public static void FilterTheNumberTest()
                {
                    Assert.AreEqual(123, FilterTheNumberTask.FilterString("123"), "Just return the numbers");
                    Assert.AreEqual(123, FilterTheNumberTask.FilterString("a1b2c3"), "Just return the numbers");
                    Assert.AreEqual(123, FilterTheNumberTask.FilterString("aa1bb2cc3dd"), "Just return the numbers");
                }

                [Test]
                public void NumberOfDecimalDigitsTest()
                {
                    Assert.AreEqual(1, NumberOfDecimalDigitsTask.Digits(5ul));
                    Assert.AreEqual(5, NumberOfDecimalDigitsTask.Digits(12345ul));
                    Assert.AreEqual(10, NumberOfDecimalDigitsTask.Digits(9876543210ul));
                }
                [Test]
                public void SimpleBeadsCountTest()
                {
                    Assert.That(SimpleBeadsCountTask.CountRedBeads(0), Is.EqualTo(0));
                    Assert.That(SimpleBeadsCountTask.CountRedBeads(1), Is.EqualTo(0));
                    Assert.That(SimpleBeadsCountTask.CountRedBeads(3), Is.EqualTo(4));
                    Assert.That(SimpleBeadsCountTask.CountRedBeads(5), Is.EqualTo(8));
                }

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
					string[] s1 = new string[] { "cdIw", "tzIy", "xDu", "rThG" };
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
                    Assert.AreEqual("Mine's a Pint!", PartridgeWatchTask.Part(new string[] { "Grouse", "Partridge", "Pheasant" }));
                    Assert.AreEqual("Mine's a Pint!!!!!!!!", PartridgeWatchTask.Part(new string[] { "Grouse", "Partridge", "Pheasant", "Goose", "Starling", "Robin", "Thrush", "Emu", "PearTree", "Chat", "Dan", "Square", "Toblerone", "Lynn", "AlphaPapa", "BMW", "Graham", "Tool", "Nomad", "Finger", "Hamster" }));
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
                    Assert.AreEqual("Ths wbst s fr lsrs LL!", DisemvowelTrollsTask.Disemvowel("This website is for losers LOL!"));
                    Assert.AreEqual("Wht r y,  cmmnst?", DisemvowelTrollsTask.Disemvowel("What are you, a communist?"));
                    Assert.AreEqual("N ffns bt,\nYr wrtng s mng th wrst 'v vr rd", DisemvowelTrollsTask.Disemvowel("No offense but,\nYour writing is among the worst I've ever read"));
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

	[TestFixture]
	class TestsForProductArrayTask
	{
		[TestCase("12 20", "20 12")]
		[TestCase("3 27 4 2", "216 24 162 324")]
		[TestCase("13 10 5 2 9", "900 1170 2340 5850 1300")]
		[TestCase("16 17 4 3 5 2", "2040 1920 8160 10880 6528 16320")]
		public void BasicTest(string s, string str)
		{
			Assert.That(ProductArrayTask.ProductArray(Foo(s)), Is.EqualTo(Foo(str)));
		}
		int[] Foo(string s) => s.Split().Select(int.Parse).ToArray();
		[Test]
		public void RandomTests()
		{
			for (int i = 0; i < 40; i++)
			{
				var array = CreateArray();
				var expected = ProductArraySolution(array);
				Assert.That(ProductArrayTask.ProductArray(array), Is.EqualTo(expected));
			}
		}

		int[] CreateArray()
		{
			var rnd = new Random();
			var length = rnd.Next(3, 8);
			var list = new List<int>();
			for (int i = 0; i < length; i++)
				list.Add(rnd.Next(1, 15));
			return list.ToArray();
		}
		int[] ProductArraySolution(int[] array) => array.Select(x => array.Aggregate((a, b) => a * b) / x).ToArray();
	}
}