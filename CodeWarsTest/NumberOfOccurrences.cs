using CodeWars7kyu;

namespace CodeWarsTest;

public class NumberOfOccurrences
{
    [Test]
    public void NumberOfOccurrencesTest()
    {
        Assert.AreEqual(2, NumberOfOccurrencesTask.NumberOfOccurrences(4, new int[] { 4, 0, 4 }));
        Assert.AreEqual(0, NumberOfOccurrencesTask.NumberOfOccurrences(1, new int[] { 4, 0, 4 }));
        Assert.AreEqual(1, NumberOfOccurrencesTask.NumberOfOccurrences(0, new int[] { 4, 0, 4 }));
    }
}