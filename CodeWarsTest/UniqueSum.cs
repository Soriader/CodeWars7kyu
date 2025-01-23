using CodeWars7kyu;

namespace CodeWarsTest;

public class UniqueSum
{
    [Test]
    public void UniqueSumTest()
    {
        Assert.AreEqual(6, UniqueSumTask.UniqueSum(new List<int>() { 1, 2, 3 }));
        Assert.AreEqual(12, UniqueSumTask.UniqueSum(new List<int>() { 1, 3, 8, 1, 8 }));
        Assert.AreEqual(-1, UniqueSumTask.UniqueSum(new List<int>() { -1, -1, 5, 2, -7 }));
    }
}