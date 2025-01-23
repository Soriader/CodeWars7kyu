using CodeWars7kyu;

namespace CodeWarsTest;

public class HeroRoot
{
    [Test]
    public static void HeroRootTest()
    {
        Assert.AreEqual(4, HeroRootTask.IntRac(25, 1));
        Assert.AreEqual(3, HeroRootTask.IntRac(125348, 300));
    }
}