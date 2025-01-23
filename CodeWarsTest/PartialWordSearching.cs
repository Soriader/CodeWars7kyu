using CodeWars7kyu;

namespace CodeWarsTest;

public class PartialWordSearching
{
    [Test]
    public void PartialWordSearchingTest()
    {
        Assert.AreEqual(new string[] { "ab", "abc", "zab" }, PartialWordSearchingTask.WordSearch("ab", new string[] { "za", "ab", "abc", "zab", "zbc" }));
        Assert.AreEqual(new string[] { "ab", "abc", "zab" }, PartialWordSearchingTask.WordSearch("aB", new string[] { "za", "ab", "abc", "zab", "zbc" }));
        Assert.AreEqual(new string[] { "aB", "Abc", "zAB" }, PartialWordSearchingTask.WordSearch("ab", new string[] { "za", "aB", "Abc", "zAB", "zbc" }));
        Assert.AreEqual(new string[] { "Empty" }, PartialWordSearchingTask.WordSearch("abcd", new string[] { "za", "aB", "Abc", "zAB", "zbc" }));
    }
}