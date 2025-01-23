using CodeWars7kyu;

namespace CodeWarsTest;

public class InternationalMorseCodeEncryption
{
    [Test]
    public void InternationalMorseCodeEncryptionTest()
    {
        void Test(string morse, string english)
        {
            Assert.AreEqual(morse, InternationalMorseCodeEncryptionTask.ToMorse(english));
        }

        string english = "SOS";
        string morse = "... --- ...";
        Test(morse, english);
    }
}