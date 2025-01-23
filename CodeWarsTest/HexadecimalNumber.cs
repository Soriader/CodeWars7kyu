using CodeWars7kyu;

namespace CodeWarsTest;

public class HexadecimalNumber
{
    [Test]
    public void HexadecimalNumberTest()
    {
        Assert.AreEqual(false, HexadecimalNumberTask.HexNumber(""));
        Assert.AreEqual(false, HexadecimalNumberTask.HexNumber("0x"));
        Assert.AreEqual(true, HexadecimalNumberTask.HexNumber("0"));
        Assert.AreEqual(true, HexadecimalNumberTask.HexNumber("0xDEADBEEF"));
        Assert.AreEqual(true, HexadecimalNumberTask.HexNumber("1337bAbe"));
    }
}