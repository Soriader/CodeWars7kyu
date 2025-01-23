using CodeWars7kyu;

namespace CodeWarsTest;

public class CompoundArray
{
    [Test]
    public static void CompoundArrayTest()
    {
        Assert.AreEqual(new int[] { 1, 9, 2, 8, 3, 7, 4, 6, 5, 6 },
            CompoundArrayTask.CompoundArray(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 9, 8, 7, 6 }));
        Assert.AreEqual(new int[] { 0, 9, 1, 8, 2, 7, 6, 5, 4, 3, 2, 1, 0 },
            CompoundArrayTask.CompoundArray(new int[] { 0, 1, 2 }, new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 }));
        Assert.AreEqual(new int[] { 11, 21, 12, 22, 23, 24 },
            CompoundArrayTask.CompoundArray(new int[] { 11, 12 }, new int[] { 21, 22, 23, 24 }));
    }
}