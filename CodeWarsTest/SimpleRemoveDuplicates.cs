using CodeWars7kyu;

namespace CodeWarsTest;

public class SimpleRemoveDuplicates
{
    [Test]
    public void SimpleRemoveDuplicatesTest()
    {
        Assert.AreEqual(new int[] { 4, 6, 3 }, SimpleRemoveDuplicatesTask.solve(new int[] { 3, 4, 4, 3, 6, 3 }));
        Assert.AreEqual(new int[] { 1, 2, 3 }, SimpleRemoveDuplicatesTask.solve(new int[] { 1, 2, 1, 2, 1, 2, 3 }));
        Assert.AreEqual(new int[] { 1, 2, 3, 4 }, SimpleRemoveDuplicatesTask.solve(new int[] { 1, 2, 3, 4 }));
        Assert.AreEqual(new int[] { 4, 5, 2, 1 }, SimpleRemoveDuplicatesTask.solve(new int[] { 1, 1, 4, 5, 1, 2, 1 }));
    }
}