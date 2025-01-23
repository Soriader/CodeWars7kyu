using CodeWars7kyu;

namespace CodeWarsTest;

public class ReverseTheBits
{
    [Test]
    public void ReverseTheBitsTest()
    {
        Assert.AreEqual(267, ReverseTheBitsTask.ReverseBits(417));
        Assert.AreEqual(417, ReverseTheBitsTask.ReverseBits(267));
        Assert.AreEqual(0, ReverseTheBitsTask.ReverseBits(0));
        Assert.AreEqual(1087, ReverseTheBitsTask.ReverseBits(2017));
        Assert.AreEqual(1023, ReverseTheBitsTask.ReverseBits(1023));
        Assert.AreEqual(1, ReverseTheBitsTask.ReverseBits(1024));
        Assert.AreEqual(long.MaxValue, ReverseTheBitsTask.ReverseBits(long.MaxValue));
    }
}