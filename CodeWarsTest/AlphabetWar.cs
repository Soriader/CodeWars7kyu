using CodeWars7kyu;

namespace CodeWarsTest;

public class AlphabetWar
{
    [Test]
    public void AlphabetWarTest()
    {
        Assert.AreEqual("Right side wins!", AlphabetWarTask.AlphabetWar("z"));
        Assert.AreEqual("Let's fight again!", AlphabetWarTask.AlphabetWar("zdqmwpbs"));
        Assert.AreEqual("Right side wins!", AlphabetWarTask.AlphabetWar("zzzzs"));
        Assert.AreEqual("Left side wins!", AlphabetWarTask.AlphabetWar("wwwwwwz"));
    }
}