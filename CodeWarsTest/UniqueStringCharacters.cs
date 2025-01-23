using CodeWars7kyu;

namespace CodeWarsTest;

public class UniqueStringCharacters
{
    [Test]
    public void UniqueStringCharactersTest()
    {
        Assert.That(UniqueStringCharactersTask.Solve("xyab", "xzca"), Is.EqualTo("ybzc"));
        Assert.That(UniqueStringCharactersTask.Solve("xyabb", "xzca"), Is.EqualTo("ybbzc"));
        Assert.That(UniqueStringCharactersTask.Solve("abcd", "xyz"), Is.EqualTo("abcdxyz"));
        Assert.That(UniqueStringCharactersTask.Solve("xxx", "xzca"), Is.EqualTo("zca"));
    }
}