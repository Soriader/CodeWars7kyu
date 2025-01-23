using CodeWars7kyu;

namespace CodeWarsTest;

public class SmallEnough
{
    [Test]
    public void SmallEnoughTest()
    {
        Assert.AreEqual(true, SmallEnoughTask.SmallEnough(new int[] { 66, 101 }, 200));
        Assert.AreEqual(false, SmallEnoughTask.SmallEnough(new int[] { 78, 117, 110, 99, 104, 117, 107, 115 }, 100));
        Assert.AreEqual(true, SmallEnoughTask.SmallEnough(new int[] { 101, 45, 75, 105, 99, 107 }, 107));
        Assert.AreEqual(true, SmallEnoughTask.SmallEnough(new int[] { 80, 117, 115, 104, 45, 85, 112, 115 }, 120));
    }
}