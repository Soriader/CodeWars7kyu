using CodeWars7kyu;

namespace CodeWarsTest;

public class ConvertIntegerToBinary
{
    [Test]
    public void ConvertIntegerToBinaryTest()
    {
        Assert.AreEqual("10", ConvertIntegerToBinaryTask.ToBinary(2));
        Assert.AreEqual("11", ConvertIntegerToBinaryTask.ToBinary(3));
        Assert.AreEqual("100", ConvertIntegerToBinaryTask.ToBinary(4));
        Assert.AreEqual("101", ConvertIntegerToBinaryTask.ToBinary(5));
    }
}