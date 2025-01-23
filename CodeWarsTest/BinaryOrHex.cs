using CodeWars7kyu;

namespace CodeWarsTest;

public class BinaryOrHex
{
    [Test]
    public void BinaryOrHexTest()
    {
        Assert.AreEqual("10", BinaryOrHexTask.EvensAndOdds(2));
        Assert.AreEqual("d", BinaryOrHexTask.EvensAndOdds(13));
        Assert.AreEqual("2f", BinaryOrHexTask.EvensAndOdds(47));
        Assert.AreEqual("0", BinaryOrHexTask.EvensAndOdds(0));
        Assert.AreEqual("11001000000000", BinaryOrHexTask.EvensAndOdds(12800));
    }
}