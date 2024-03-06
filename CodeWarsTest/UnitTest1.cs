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