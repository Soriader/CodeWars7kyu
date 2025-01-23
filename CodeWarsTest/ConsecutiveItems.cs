using CodeWars7kyu;

namespace CodeWarsTest;

public class ConsecutiveItems
{
    [Test]
    public void ConsecutiveItemsTest()
    {
        Assert.AreEqual(false, ConsecutiveItemsTask.Consecutive(new int[] { 1, 3, 5, 7 }, 3, 7));
        Assert.AreEqual(true, ConsecutiveItemsTask.Consecutive(new int[] { 1, 3, 5, 7 }, 3, 1));
        Assert.AreEqual(true, ConsecutiveItemsTask.Consecutive(new int[] { 1, 6, 9, -3, 4, -78, 0 }, -3, 4));
    }
}