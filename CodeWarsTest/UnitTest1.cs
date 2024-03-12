using CodeWars7kyu;
using System.Reflection;
using static CodeWars7kyu.DisemvowelTrollsTask;

namespace CodeWarsTest
{
    public class Tests
    {

        [TestFixture]
        public class KataTest
        {
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
                Assert.AreEqual(new List<int> { 2, 3, 1, 1 }, RemoveTheMinimumTask.RemoveSmallest(new List<int> {1, 2, 3, 1, 1 }));
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