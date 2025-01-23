using CodeWars7kyu;

namespace CodeWarsTest;

public class StringPrefixAndSuffix
{
    [Test]
    public void StringPrefixAndSuffixTest()
    {
        Assert.AreEqual(0, StringPrefixAndSuffixTask.Solve("abcd"));
        Assert.AreEqual(1, StringPrefixAndSuffixTask.Solve("abcda"));
        Assert.AreEqual(3, StringPrefixAndSuffixTask.Solve("abcdabc"));
        Assert.AreEqual(3, StringPrefixAndSuffixTask.Solve("abcabc"));
        Assert.AreEqual(1, StringPrefixAndSuffixTask.Solve("abcabca"));
        Assert.AreEqual(0, StringPrefixAndSuffixTask.Solve("abcdabcc"));
        Assert.AreEqual(2, StringPrefixAndSuffixTask.Solve("aaaaa"));
        Assert.AreEqual(2, StringPrefixAndSuffixTask.Solve("aaaa"));
        Assert.AreEqual(1, StringPrefixAndSuffixTask.Solve("aaa"));
        Assert.AreEqual(1, StringPrefixAndSuffixTask.Solve("aa"));
        Assert.AreEqual(0, StringPrefixAndSuffixTask.Solve("a"));
        Assert.AreEqual(0, StringPrefixAndSuffixTask.Solve("acbacc"));

    }
}