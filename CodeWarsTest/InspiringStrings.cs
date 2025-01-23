using CodeWars7kyu;

namespace CodeWarsTest;

public class InspiringStrings
{
    [Test]
    public void InspiringStringsTest()
    {
        Assert.AreEqual("fgh", InspiringStringsTask.LongestWord("a b c d e fgh"));
        Assert.AreEqual("three", InspiringStringsTask.LongestWord("one two three"));
        Assert.AreEqual("grey", InspiringStringsTask.LongestWord("red blue grey"));
    }
}