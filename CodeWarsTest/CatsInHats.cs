using CodeWars7kyu;

namespace CodeWarsTest;

public class CatsInHats
{
    [Test]
    public void CatsInHatsTest()
    {
        Assert.That(CatsInHatsTask.Height(7), Is.EqualTo("3331148,800"));
        Assert.That(CatsInHatsTask.Height(0), Is.EqualTo("2000000,000"));
        
    }
}