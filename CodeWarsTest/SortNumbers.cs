using CodeWars7kyu;

namespace CodeWarsTest;

public class SortNumbers
{
    [Test]
    public void SortNumbersTest()
    {
        Assert.AreEqual(new int[] { 1, 2, 3, 5, 10 }, SortNumbersTask.SortNumbers(new int[] { 1, 2, 3, 10, 5 }));
        Assert.AreEqual(new int[] { }, SortNumbersTask.SortNumbers(new int[] { }));
        Assert.AreEqual(new int[] { 2, 10, 20 }, SortNumbersTask.SortNumbers(new int[] { 20, 2, 10 }));
        Assert.AreEqual(new int[] { 1, 2, 3, 5, 10 }, SortNumbersTask.SortNumbers(new int[] { 1, 2, 3, 10, 5 }));
        Assert.AreEqual(new int[] { 1, 2, 3, 5, 10 }, SortNumbersTask.SortNumbers(new int[] { 1, 2, 3, 10, 5 }));
    }
}