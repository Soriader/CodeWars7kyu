using CodeWars7kyu;

namespace CodeWarsTest;

public class CompleteThePattern
{
    [Test]
    public void CompleteThePatternTest()
    {
        Assert.AreEqual("1", CompleteThePatternTask.Pattern(1));
        Assert.AreEqual("12\n2", CompleteThePatternTask.Pattern(2));
        Assert.AreEqual("12345\n2345\n345\n45\n5", CompleteThePatternTask.Pattern(5));
    }
}