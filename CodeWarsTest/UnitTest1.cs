using CodeWars7kyu;

namespace CodeWarsTest
{
    public class Tests
    {

        [TestFixture]
        public class KataTest
        {
            [Test]
            public static void AccumTest()
            {
                Assert.AreEqual("N-Yy-Fff-Ffff-Sssss-Gggggg-Eeeeeee-Yyyyyyyy-Yyyyyyyyy-Llllllllll-Bbbbbbbbbbb", Kata.Accum("NyffsGeyylB"));
                Assert.AreEqual("M-Jj-Ttt-Kkkk-Uuuuu-Bbbbbb-Ooooooo-Vvvvvvvv-Qqqqqqqqq-Rrrrrrrrrr-Uuuuuuuuuuu", Kata.Accum("MjtkuBovqrU"));
                Assert.AreEqual("E-Vv-Iii-Dddd-Jjjjj-Uuuuuu-Nnnnnnn-Oooooooo-Kkkkkkkkk-Mmmmmmmmmm-Mmmmmmmmmmm", Kata.Accum("EvidjUnokmM"));
            }
            [Test]
            public void ReverseWordsTest()
            {
                Assert.AreEqual("sihT si na !elpmaxe", Kata.ReverseWords("This is an example!"));
            }

            [Test]
            public void FriendOrFoeTest()
            {
                string[] expected = { "Ryan", "Mark" };
                string[] names = { "Ryan", "Kieran", "Mark", "Jimmy" };
                CollectionAssert.AreEqual(expected, Kata.FriendOrFoe(names));
            }
            [Test]
            public void MakeComplementTest()
            {
                Assert.That(Kata.MakeComplement("ATGC"), Is.EqualTo("TACG"));
                Assert.That(Kata.MakeComplement("AAGG"), Is.EqualTo("TTCC"));
                Assert.That(Kata.MakeComplement("ATTGC"), Is.EqualTo("TAACG"));
            }

        }
    }
}