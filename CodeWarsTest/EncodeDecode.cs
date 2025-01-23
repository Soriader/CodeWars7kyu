using CodeWars7kyu;

namespace CodeWarsTest;

public class EncodeDecode
{
    [Test]
    public void EncodeDecodeTest()
    {
        Assert.AreEqual("Gug hgs g cgt", EncodeDecodeTask.Encode("Ala has a cat"));
        Assert.AreEqual("GBCE", EncodeDecodeTask.Encode("ABCD"));
        Assert.AreEqual("Gug hgs g cgt", EncodeDecodeTask.Encode("Ala has a cat"));
        Assert.AreEqual("agedyropulik", EncodeDecodeTask.Encode("gaderypoluki"));
        Assert.AreEqual("Ala has a cat", EncodeDecodeTask.Decode("Gug hgs g cgt"));
        Assert.AreEqual("gaderypoluki", EncodeDecodeTask.Decode("agedyropulik"));
        Assert.AreEqual("ABCD", EncodeDecodeTask.Decode("GBCE"));
    }
}