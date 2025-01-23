using CodeWars7kyu;

namespace CodeWarsTest;

public class NthSmallestElement
{
    [Test]
    public void NthSmallestElementTest()
    {
        Assert.AreEqual(2, NthSmallestElementTask.NthSmallest(new int[] { 3, 1, 2 }, 2));
        Assert.AreEqual(7, NthSmallestElementTask.NthSmallest(new int[] { 15, 20, 7, 10, 4, 3 }, 3));
        Assert.AreEqual(2, NthSmallestElementTask.NthSmallest(new int[] { 2, 169, 13, -5, 0, -1 }, 4));
        Assert.AreEqual(2, NthSmallestElementTask.NthSmallest(new int[] { 2, 1, 3, 3, 1, 2 }, 3));
    }
}