using CodeWars7kyu;

namespace CodeWarsTest;

public class HowManyUrinals
{
    [Test]
    public void HowManyUrinalsTest()
    {
        Assert.AreEqual(1, HowManyUrinalsTask.GetFreeUrinals("10001"));
        Assert.AreEqual(0, HowManyUrinalsTask.GetFreeUrinals("1001"));
        Assert.AreEqual(3, HowManyUrinalsTask.GetFreeUrinals("00000"));
        Assert.AreEqual(2, HowManyUrinalsTask.GetFreeUrinals("0000"));
        Assert.AreEqual(1, HowManyUrinalsTask.GetFreeUrinals("01000"));
        Assert.AreEqual(2, HowManyUrinalsTask.GetFreeUrinals("10000"));
        Assert.AreEqual(0, HowManyUrinalsTask.GetFreeUrinals("1"));
        Assert.AreEqual(1, HowManyUrinalsTask.GetFreeUrinals("0"));
        Assert.AreEqual(0, HowManyUrinalsTask.GetFreeUrinals("10"));
        Assert.AreEqual(-1, HowManyUrinalsTask.GetFreeUrinals("110"));
        Assert.AreEqual(-1, HowManyUrinalsTask.GetFreeUrinals("101100001"));
        Assert.AreEqual(-1, HowManyUrinalsTask.GetFreeUrinals("0000100000101010011"));
    }
}