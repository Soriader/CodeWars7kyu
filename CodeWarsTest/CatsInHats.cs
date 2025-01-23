using CodeWars7kyu;

namespace CodeWarsTest;

public class CatsInHats
{
    [Test]
    public void CatsInHatsTest()
    {
        Assert.AreEqual("3331148.800", CatsInHatsTask.Height(7));
        Assert.AreEqual("2000000.000", CatsInHatsTask.Height(0));
    }
}