using CodeWars7kyu;

namespace CodeWarsTest;

public class WordValues
{
    [Test]
    public void WordValuesTest()
    {
        Assert.AreEqual(new int[] { 88, 12, 225 }, WordValuesTask.WordValue(new string[] { "codewars", "abc", "xyz" }));
        Assert.AreEqual(new int[] { 12, 24, 18, 24 }, WordValuesTask.WordValue(new string[] { "abc abc", "abc abc", "abc", "abc" }));

    }
}