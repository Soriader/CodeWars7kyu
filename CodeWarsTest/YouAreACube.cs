using CodeWars7kyu;

namespace CodeWarsTest;

public class YouAreACube
{
    [Test]
    public void YouAreACubeTest()
    {
        Assert.AreEqual(true, YouAreACubeTask.YouAreACube(27));
        Assert.AreEqual(true, YouAreACubeTask.YouAreACube(1));
        Assert.AreEqual(false, YouAreACubeTask.YouAreACube(2));
        Assert.AreEqual(false, YouAreACubeTask.YouAreACube(99));
        Assert.AreEqual(true, YouAreACubeTask.YouAreACube(64));
    }
}