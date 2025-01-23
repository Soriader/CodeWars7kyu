using CodeWars7kyu;

namespace CodeWarsTest;

public class FixMyPhoneNumbers
{
    [Test]
    public void FixMyPhoneNumbersTest()
    {
        Assert.AreEqual("02078834982", FixMyPhoneNumbersTask.IsItANum("S:)0207ERGQREG88349F82!efRF)"));
        Assert.AreEqual("Not a phone number", FixMyPhoneNumbersTask.IsItANum("sjfniebienvr12312312312ehfWh"));
        Assert.AreEqual("Not a phone number", FixMyPhoneNumbersTask.IsItANum("0192387415456"));
        Assert.AreEqual("02084564165", FixMyPhoneNumbersTask.IsItANum("v   uf  f 0tt2eg qe0b 8rtyq4eyq564()(((((165"));
        Assert.AreEqual("Not a phone number", FixMyPhoneNumbersTask.IsItANum("stop calling me no I have never been in an accident"));
    }
}