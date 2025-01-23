using CodeWars7kyu;

namespace CodeWarsTest;

public class SortByLastChar
{
    [Test]
    public void SortByLastCharTest()
    {
        Assert.AreEqual(new[] { "cba", "cab", "abc" }, SortByLastCharTask.Last("abc cba cab"));
        Assert.AreEqual(new[] { "aaa", "bbb", "ccc", "ddd" }, SortByLastCharTask.Last("bbb ccc aaa ddd"));
        Assert.AreEqual(new[] { "wa", "de", "co", "rs" }, SortByLastCharTask.Last("co de wa rs"));
        Assert.AreEqual(new[] { "axa", "ava", "asa" }, SortByLastCharTask.Last("axa ava asa"));

        Assert.AreEqual(new[] { "a", "need", "ubud", "i", "taxi", "man", "to", "up" },
            SortByLastCharTask.Last("man i need a taxi up to ubud"));

        Assert.AreEqual(new[] { "time", "are", "we", "the", "climbing", "volcano", "up", "what" },
            SortByLastCharTask.Last("what time are we climbing up the volcano"));

        Assert.AreEqual(new[] { "take", "me", "semynak", "to" }, SortByLastCharTask.Last("take me to semynak"));

        Assert.AreEqual(new[] { "massage", "massage", "massage", "yes", "yes" },
            SortByLastCharTask.Last("massage yes massage yes massage"));

        Assert.AreEqual(new[] { "a", "and", "take", "dance", "please", "bintang" },
            SortByLastCharTask.Last("take bintang and a dance please"));
    }
}