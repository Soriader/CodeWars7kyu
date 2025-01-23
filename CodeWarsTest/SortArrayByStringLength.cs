using CodeWars7kyu;

namespace CodeWarsTest;

public class SortArrayByStringLength
{
    [Test]
    public void SortArrayByStringLengthTest()
    {
        Assert.AreEqual(new string[] { "I", "To", "Beg", "Life" }, SortArrayByStringLengthTask.SortByLength(new string[] { "Beg", "Life", "I", "To" }));
        Assert.AreEqual(new string[] { "", "Pizza", "Brains", "Moderately" }, SortArrayByStringLengthTask.SortByLength(new string[] { "", "Moderately", "Brains", "Pizza" }));
        Assert.AreEqual(new string[] { "Short", "Longer", "Longest" }, SortArrayByStringLengthTask.SortByLength(new string[] { "Longer", "Longest", "Short" }));
    }
}