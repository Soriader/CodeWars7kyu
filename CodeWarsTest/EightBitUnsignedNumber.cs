using CodeWars7kyu;

namespace CodeWarsTest;

public class EightBitUnsignedNumber
{
    [Test]
    public void EightBitUnsignedNumberTest()
    {
        Assert.AreEqual(false, EightBitUnsignedNumberTask.EightBitNumber(""));
        Assert.AreEqual(true, EightBitUnsignedNumberTask.EightBitNumber("0"));
        Assert.AreEqual(false, EightBitUnsignedNumberTask.EightBitNumber("00"));
        Assert.AreEqual(true, EightBitUnsignedNumberTask.EightBitNumber("55"));
        Assert.AreEqual(false, EightBitUnsignedNumberTask.EightBitNumber("042"));
        Assert.AreEqual(true, EightBitUnsignedNumberTask.EightBitNumber("123"));
        Assert.AreEqual(true, EightBitUnsignedNumberTask.EightBitNumber("255"));
        Assert.AreEqual(false, EightBitUnsignedNumberTask.EightBitNumber("256"));
        Assert.AreEqual(false, EightBitUnsignedNumberTask.EightBitNumber("999"));
        Assert.AreEqual(false, EightBitUnsignedNumberTask.EightBitNumber("-1"));
    }
}