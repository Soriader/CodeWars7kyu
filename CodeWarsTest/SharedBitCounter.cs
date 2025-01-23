using CodeWars7kyu;

namespace CodeWarsTest;

public class SharedBitCounter
{
    [Test]
    public void SharedBitCounterTest()
    {
        Assert.AreEqual(true, SharedBitCounterTask.SharedBits(7, 15));
        Assert.AreEqual(true, SharedBitCounterTask.SharedBits(23, 7));
        Assert.AreEqual(true, SharedBitCounterTask.SharedBits(43, 77));
        Assert.AreEqual(false, SharedBitCounterTask.SharedBits(7, 10));
        Assert.AreEqual(false, SharedBitCounterTask.SharedBits(2, 3));
        Assert.AreEqual(false, SharedBitCounterTask.SharedBits(1, 1));
        Assert.AreEqual(false, SharedBitCounterTask.SharedBits(16, 8));
        Assert.AreEqual(false, SharedBitCounterTask.SharedBits(1, 2));

    }
}