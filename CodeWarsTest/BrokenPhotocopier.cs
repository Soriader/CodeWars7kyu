using CodeWars7kyu;

namespace CodeWarsTest;

public class BrokenPhotocopier
{
    [Test]
    public void BrokenPhotocopierTest()
    {
        Assert.AreEqual("0", BrokenPhotocopierTask.Broken("1"));
        Assert.AreEqual("01111111010010000001100110111", BrokenPhotocopierTask.Broken("10000000101101111110011001000"));
        Assert.AreEqual("011101", BrokenPhotocopierTask.Broken("100010"));
    }
}