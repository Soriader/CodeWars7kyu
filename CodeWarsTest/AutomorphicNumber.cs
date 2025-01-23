using CodeWars7kyu;

namespace CodeWarsTest;

public class AutomorphicNumber
{
    [Test]
    public void AutomorphicNumberTest()
    {
        Assert.AreEqual("Automorphic", AutomorphicNumberTask.Automorphic(1));
        Assert.AreEqual("Automorphic", AutomorphicNumberTask.Automorphic(6));
        Assert.AreEqual("Automorphic", AutomorphicNumberTask.Automorphic(625));
        Assert.AreEqual("Not!!", AutomorphicNumberTask.Automorphic(3));
        Assert.AreEqual("Not!!", AutomorphicNumberTask.Automorphic(95));
        Assert.AreEqual("Not!!", AutomorphicNumberTask.Automorphic(225));
    }
}