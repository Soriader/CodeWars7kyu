using CodeWars7kyu;

namespace CodeWarsTest;

public class ReverseList
{
    [Test]
    public void ReverseListTest()
    {
        Assert.AreEqual(new int[0], ReverseListTask.ReverseList(new int[0]));
        Assert.AreEqual(new int[] { 3, 2, 1 }, ReverseListTask.ReverseList(new int[] { 1, 2, 3 }));
    }
}