using CodeWars7kyu;

namespace CodeWarsTest
{
    public class Tests
    {

        [TestFixture]
        public class KataTest
        {

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