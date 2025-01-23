using CodeWars7kyu;

namespace CodeWarsTest;

public class LargestElements
{
    [Test]
    public void LargestElementsTest()
    {
        Assert.AreEqual(new List<int> { 9, 10 }, LargestElementsTask.Largest(2, new List<int> { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }));
        Assert.AreEqual(new List<int> { 5, 5, 5 }, LargestElementsTask.Largest(3, new List<int> { 5, 1, 5, 2, 3, 1, 2, 3, 5 }));
        Assert.AreEqual(new List<int> { 3, 5, 9, 13, 22, 50, 63 }, LargestElementsTask.Largest(7, new List<int> { 9, 1, 50, 22, 3, 13, 2, 63, 5 }));
        Assert.AreEqual(new List<int> { }, LargestElementsTask.Largest(0, new List<int> { 1, 2, 3, 4, 8, 7, 6, 5 }));
    }
}